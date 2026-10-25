Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms

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
                    ' Load Categories / Competencies
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

    ' 2. Populate Course Dropdown directly from courses table based on Student Program and Year Level
    ' Populate Course Dropdown directly from courses table matching the student's program and year level
    Private Sub PopulateCoursesDropdown()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    ' 1. Determine numerical year level from Globals session (e.g., "2nd Year" -> 2)
                    Dim yearNum As Integer = 1
                    If Not String.IsNullOrWhiteSpace(CurrentUserYearLevel) Then
                        If CurrentUserYearLevel.Contains("1") Then
                            yearNum = 1
                        ElseIf CurrentUserYearLevel.Contains("2") Then
                            yearNum = 2
                        ElseIf CurrentUserYearLevel.Contains("3") Then
                            yearNum = 3
                        ElseIf CurrentUserYearLevel.Contains("4") Then
                            yearNum = 4
                        End If
                    End If

                    ' 2. Normalize Program string (e.g., "BS Information Technology" -> "BSIT", "BS Computer Science" -> "BSCS")
                    Dim progCode As String = "BSIT"
                    If Not String.IsNullOrWhiteSpace(CurrentUserProgram) Then
                        If CurrentUserProgram.ToUpper().Contains("COMPUTER SCIENCE") OrElse CurrentUserProgram.ToUpper().Contains("BSCS") Then
                            progCode = "BSCS"
                        ElseIf CurrentUserProgram.ToUpper().Contains("INFORMATION TECHNOLOGY") OrElse CurrentUserProgram.ToUpper().Contains("BSIT") Then
                            progCode = "BSIT"
                        End If
                    End If

                    ' 3. Direct query on courses matching program code or 'BOTH', up to current year level
                    Dim query As String = "SELECT course_code, CONCAT(course_code, ' - ', course_name) AS display_name " &
                                          "FROM courses " &
                                          "WHERE (UPPER(program) = @prog OR UPPER(program) = 'BOTH') " &
                                          "  AND year_level <= @yearLvl " &
                                          "ORDER BY year_level ASC, course_code ASC"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@prog", progCode)
                        cmd.Parameters.AddWithValue("@yearLvl", yearNum)

                        Dim adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        ' Add default General / Non-Academic option at position 0
                        Dim dr As DataRow = dt.NewRow()
                        dr("course_code") = DBNull.Value
                        dr("display_name") = "-- General / Non-Academic --"
                        dt.Rows.InsertAt(dr, 0)

                        cmbCourseCode.DataSource = dt
                        cmbCourseCode.DisplayMember = "display_name"
                        cmbCourseCode.ValueMember = "course_code"
                        cmbCourseCode.SelectedIndex = 0
                    End Using
                End If
            End Using
        Catch ex As Exception
            ' Fallback error handling
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