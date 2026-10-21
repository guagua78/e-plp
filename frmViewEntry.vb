Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmViewEntry
    Public SelectedEntryID As Integer = 0
    Private currentFilePath As String = ""
    Private newSelectedFilePath As String = ""

    Private Sub frmViewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDropdowns()
        If SelectedEntryID > 0 Then
            LoadEntryDetails()
        End If
    End Sub

    ' Populate Categories & Activity Types
    Private Sub PopulateDropdowns()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim catCmd As New MySqlCommand("SELECT category_id, category_name FROM categories ORDER BY category_name ASC", conn)
                    Dim catAdapter As New MySqlDataAdapter(catCmd)
                    Dim catTable As New DataTable()
                    catAdapter.Fill(catTable)
                    cmbCategoryVal.DataSource = catTable
                    cmbCategoryVal.DisplayMember = "category_name"
                    cmbCategoryVal.ValueMember = "category_id"

                    Dim typeCmd As New MySqlCommand("SELECT activity_type_id, type_name FROM activity_types ORDER BY type_name ASC", conn)
                    Dim typeAdapter As New MySqlDataAdapter(typeCmd)
                    Dim typeTable As New DataTable()
                    typeAdapter.Fill(typeTable)
                    cmbTypeVal.DataSource = typeTable
                    cmbTypeVal.DisplayMember = "type_name"
                    cmbTypeVal.ValueMember = "activity_type_id"
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub

    ' Fetch Existing Record Values into Input Controls
    Private Sub LoadEntryDetails()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT pe.title, pe.category_id, pe.activity_type_id, pe.date_completed, pe.description, " &
                                          "a.file_name, a.file_path " &
                                          "FROM portfolio_entries pe " &
                                          "LEFT JOIN attachments a ON pe.entry_id = a.entry_id " &
                                          "WHERE pe.entry_id = @id"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", SelectedEntryID)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                txtTitleVal.Text = reader("title").ToString()
                                cmbCategoryVal.SelectedValue = Convert.ToInt32(reader("category_id"))
                                cmbTypeVal.SelectedValue = Convert.ToInt32(reader("activity_type_id"))
                                dtpDateVal.Value = Convert.ToDateTime(reader("date_completed"))
                                txtDescriptionVal.Text = reader("description").ToString()

                                If Not IsDBNull(reader("file_path")) AndAlso Not String.IsNullOrEmpty(reader("file_path").ToString()) Then
                                    currentFilePath = reader("file_path").ToString()
                                    lblFileName.Text = reader("file_name").ToString()
                                    btnViewFile.Enabled = True
                                Else
                                    lblFileName.Text = "No attached file"
                                    btnViewFile.Enabled = False
                                End If
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading entry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Open Existing Attached File in Windows
    Private Sub btnViewFile_Click(sender As Object, e As EventArgs) Handles btnViewFile.Click
        Dim fileToOpen As String = If(Not String.IsNullOrEmpty(newSelectedFilePath), newSelectedFilePath, currentFilePath)
        If File.Exists(fileToOpen) Then
            Process.Start(New ProcessStartInfo(fileToOpen) With {.UseShellExecute = True})
        Else
            MessageBox.Show("File not found in local storage.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Replace or Add New Evidence File
    Private Sub btnChangeFile_Click(sender As Object, e As EventArgs) Handles btnChangeFile.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select New Supporting Evidence File"
            ofd.Filter = "Image and PDF Files|*.jpg;*.jpeg;*.png;*.pdf|All Files|*.*"

            If ofd.ShowDialog() = DialogResult.OK Then
                newSelectedFilePath = ofd.FileName
                lblFileName.Text = Path.GetFileName(newSelectedFilePath) & " (New File Selected)"
                btnViewFile.Enabled = True
            End If
        End Using
    End Sub

    ' Save Updated Changes to Database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtTitleVal.Text) Then
            MessageBox.Show("Please enter an accomplishment title.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    ' 1. Update Portfolio Entry Record
                    Dim updateQuery As String = "UPDATE portfolio_entries SET title = @title, category_id = @cat, " &
                                                "activity_type_id = @type, date_completed = @date, description = @desc " &
                                                "WHERE entry_id = @id"

                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@title", txtTitleVal.Text.Trim())
                        cmd.Parameters.AddWithValue("@cat", cmbCategoryVal.SelectedValue)
                        cmd.Parameters.AddWithValue("@type", cmbTypeVal.SelectedValue)
                        cmd.Parameters.AddWithValue("@date", dtpDateVal.Value.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@desc", txtDescriptionVal.Text.Trim())
                        cmd.Parameters.AddWithValue("@id", SelectedEntryID)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 2. Handle File Replacement if a new file was chosen
                    If Not String.IsNullOrEmpty(newSelectedFilePath) Then
                        Dim uploadsFolder As String = Path.Combine(Application.StartupPath, "Uploads")
                        If Not Directory.Exists(uploadsFolder) Then Directory.CreateDirectory(uploadsFolder)

                        Dim newFileName As String = $"{SelectedEntryID}_{Path.GetFileName(newSelectedFilePath)}"
                        Dim destinationPath As String = Path.Combine(uploadsFolder, newFileName)
                        File.Copy(newSelectedFilePath, destinationPath, True)

                        ' Delete old attachment record
                        Dim delAttach As New MySqlCommand("DELETE FROM attachments WHERE entry_id = @id", conn)
                        delAttach.Parameters.AddWithValue("@id", SelectedEntryID)
                        delAttach.ExecuteNonQuery()

                        ' Insert updated attachment record
                        Dim addAttach As New MySqlCommand("INSERT INTO attachments (entry_id, file_name, file_path) VALUES (@id, @name, @path)", conn)
                        addAttach.Parameters.AddWithValue("@id", SelectedEntryID)
                        addAttach.Parameters.AddWithValue("@name", newFileName)
                        addAttach.Parameters.AddWithValue("@path", destinationPath)
                        addAttach.ExecuteNonQuery()
                    End If

                    MessageBox.Show("Entry updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating entry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Delete Entry Action
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this portfolio entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = database.GetConnection()
                    If conn IsNot Nothing Then
                        ' 1. Delete associated file attachment record
                        Dim delAttach As New MySqlCommand("DELETE FROM attachments WHERE entry_id = @id", conn)
                        delAttach.Parameters.AddWithValue("@id", SelectedEntryID)
                        delAttach.ExecuteNonQuery()

                        ' 2. Delete primary entry record
                        Dim delEntry As New MySqlCommand("DELETE FROM portfolio_entries WHERE entry_id = @id", conn)
                        delEntry.Parameters.AddWithValue("@id", SelectedEntryID)
                        Dim rowsAffected As Integer = delEntry.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Entry deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        Else
                            MessageBox.Show("Record was not found in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting entry: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class