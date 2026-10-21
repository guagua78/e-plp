Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmViewEntry
    Public SelectedEntryID As Integer = 0
    Private attachedFilePath As String = ""

    Private Sub frmViewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SelectedEntryID > 0 Then
            LoadEntryDetails()
        End If
    End Sub

    Private Sub LoadEntryDetails()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT pe.title, c.category_name, at.type_name, pe.date_completed, pe.description, " &
                                          "a.file_name, a.file_path " &
                                          "FROM portfolio_entries pe " &
                                          "INNER JOIN categories c ON pe.category_id = c.category_id " &
                                          "INNER JOIN activity_types at ON pe.activity_type_id = at.activity_type_id " &
                                          "LEFT JOIN attachments a ON pe.entry_id = a.entry_id " &
                                          "WHERE pe.entry_id = @id"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", SelectedEntryID)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                lblTitleVal.Text = reader("title").ToString()
                                lblCategoryVal.Text = reader("category_name").ToString()
                                lblTypeVal.Text = reader("type_name").ToString()
                                lblDateVal.Text = Convert.ToDateTime(reader("date_completed")).ToString("MMMM dd, yyyy")
                                txtDescriptionVal.Text = reader("description").ToString()

                                If Not IsDBNull(reader("file_path")) AndAlso Not String.IsNullOrEmpty(reader("file_path").ToString()) Then
                                    attachedFilePath = reader("file_path").ToString()
                                    lblFileName.Text = reader("file_name").ToString()
                                    btnViewFile.Enabled = True
                                Else
                                    lblFileName.Text = "No attached supporting evidence"
                                    btnViewFile.Enabled = False
                                End If
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Open Attached File using Windows Default System Viewer
    Private Sub btnViewFile_Click(sender As Object, e As EventArgs) Handles btnViewFile.Click
        If File.Exists(attachedFilePath) Then
            Process.Start(New ProcessStartInfo(attachedFilePath) With {.UseShellExecute = True})
        Else
            MessageBox.Show("The attached file could not be found in local storage.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class