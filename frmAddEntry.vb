Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmAddEntry
    Private selectedFilePath As String = ""

    Private Sub frmAddEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDropdowns()
        PopulateCoursesDropdown()
    End Sub

    ' 1. Populate Dropdown Options from Database (Categories & Activity Types)
    Private Sub PopulateDropdowns()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    ' Load Categories
                    Dim catCmd As New MySqlCommand("SELECT category_id, category_name FROM categories ORDER BY category_name ASC", conn)
                    Dim catAdapter As New MySqlDataAdapter(catCmd)
                    Dim catTable As New DataTable()
                    catAdapter.Fill(catTable)

                    cmbCategory.DataSource = catTable
                    cmbCategory.DisplayMember = "category_name"
                    cmbCategory.ValueMember = "category_id"

                    ' Load Activity Types
                    Dim typeCmd As New MySqlCommand("SELECT activity_type_id, type_name FROM activity_types ORDER BY type_name ASC", conn)
                    Dim typeAdapter As New MySqlDataAdapter(typeCmd)
                    Dim typeTable As New DataTable()
                    typeAdapter.Fill(typeTable)

                    cmbActivityType.DataSource = typeTable
                    cmbActivityType.DisplayMember = "type_name"
                    cmbActivityType.ValueMember = "activity_type_id"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading dropdown options: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateCoursesDropdown()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    ' Selects courses matching student's program AND up to their current year level
                    Dim query As String = "SELECT c.course_code, CONCAT(c.course_code, ' - ', c.course_name) AS display_name " &
                                      "FROM courses c " &
                                      "INNER JOIN students s ON (c.program = s.degree_program OR c.program = 'BOTH') " &
                                      "WHERE s.student_number = @stud " &
                                      "AND c.year_level <= CASE " &
                                      "    WHEN s.year_level LIKE '%1st%' THEN 1 " &
                                      "    WHEN s.year_level LIKE '%2nd%' THEN 2 " &
                                      "    WHEN s.year_level LIKE '%3rd%' THEN 3 " &
                                      "    WHEN s.year_level LIKE '%4th%' THEN 4 " &
                                      "    ELSE 1 END " &
                                      "ORDER BY c.year_level ASC, c.course_code ASC"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)
                        Dim adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        ' Add default General / Non-Academic option at top
                        Dim dr As DataRow = dt.NewRow()
                        dr("course_code") = DBNull.Value
                        dr("display_name") = "-- General / Non-Academic --"
                        dt.Rows.InsertAt(dr, 0)

                        cmbCourseCode.DataSource = dt
                        cmbCourseCode.DisplayMember = "display_name"
                        cmbCourseCode.ValueMember = "course_code"
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Catch silently or handle notice
        End Try
    End Sub

    ' 3. Browse Evidence File Action
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Supporting Evidence File"
            ofd.Filter = "Image and PDF Files|*.jpg;*.jpeg;*.png;*.pdf|All Files|*.*"

            If ofd.ShowDialog() = DialogResult.OK Then
                selectedFilePath = ofd.FileName
                lblFilePath.Text = Path.GetFileName(selectedFilePath)
            End If
        End Using
    End Sub

    ' 4. Insert Entry, Linked Course Code, & Attach Evidence File
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim titleText As String = txtTitle.Text.Trim()

        ' Validation
        If String.IsNullOrWhiteSpace(titleText) Then
            MessageBox.Show("Please enter an accomplishment title.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbCategory.SelectedValue Is Nothing OrElse cmbActivityType.SelectedValue Is Nothing Then
            MessageBox.Show("Please select both a Skill Competency and an Activity Type.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    ' Insert Portfolio Entry with Course Code Link
                    Dim insertQuery As String = "INSERT INTO portfolio_entries (student_number, title, activity_type_id, category_id, course_code, description, date_completed) " &
                                                "VALUES (@stud, @title, @type, @cat, @course, @desc, @date); SELECT LAST_INSERT_ID();"

                    Dim newEntryId As Integer = 0
                    Using cmd As New MySqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)
                        cmd.Parameters.AddWithValue("@title", titleText)
                        cmd.Parameters.AddWithValue("@type", cmbActivityType.SelectedValue)
                        cmd.Parameters.AddWithValue("@cat", cmbCategory.SelectedValue)

                        ' Handle NULL value if "-- General / Non-Academic --" is selected
                        If cmbCourseCode.SelectedValue IsNot DBNull.Value AndAlso cmbCourseCode.SelectedValue IsNot Nothing Then
                            cmd.Parameters.AddWithValue("@course", cmbCourseCode.SelectedValue.ToString())
                        Else
                            cmd.Parameters.AddWithValue("@course", DBNull.Value)
                        End If

                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim())
                        cmd.Parameters.AddWithValue("@date", dtpDateCompleted.Value.ToString("yyyy-MM-dd"))

                        newEntryId = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using

                    ' Copy Attached File to Uploads Folder & Record in DB
                    If Not String.IsNullOrEmpty(selectedFilePath) AndAlso newEntryId > 0 Then
                        Dim uploadsFolder As String = Path.Combine(Application.StartupPath, "Uploads")
                        If Not Directory.Exists(uploadsFolder) Then Directory.CreateDirectory(uploadsFolder)

                        Dim uniqueFileName As String = $"{newEntryId}_{Path.GetFileName(selectedFilePath)}"
                        Dim destinationPath As String = Path.Combine(uploadsFolder, uniqueFileName)
                        File.Copy(selectedFilePath, destinationPath, True)

                        Dim attachQuery As String = "INSERT INTO attachments (entry_id, file_name, file_path) VALUES (@entry, @name, @path)"
                        Using attachCmd As New MySqlCommand(attachQuery, conn)
                            attachCmd.Parameters.AddWithValue("@entry", newEntryId)
                            attachCmd.Parameters.AddWithValue("@name", uniqueFileName)
                            attachCmd.Parameters.AddWithValue("@path", destinationPath)
                            attachCmd.ExecuteNonQuery()
                        End Using
                    End If

                    MessageBox.Show("Portfolio accomplishment successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class