Imports MySql.Data.MySqlClient

Public Class frmEditProfile

    Private Sub frmEditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStudentNum.ReadOnly = True
        txtStudentNum.Text = CurrentStudentNumber

        ' Fetch current name breakdown directly from DB
        LoadStudentProfileData()

        txtEmail.ReadOnly = False
        txtEmail.Text = CurrentUserEmail

        If cmbYearLevel.Items.Contains(CurrentUserYearLevel) Then
            cmbYearLevel.SelectedItem = CurrentUserYearLevel
        ElseIf cmbYearLevel.Items.Count > 0 Then
            cmbYearLevel.SelectedIndex = 0
        End If
    End Sub

    Private Sub LoadStudentProfileData()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT first_name, middle_name, last_name, suffix FROM students WHERE student_number = @stud"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)
                        Using rdr As MySqlDataReader = cmd.ExecuteReader()
                            If rdr.Read() Then
                                txtFirstName.Text = rdr("first_name").ToString()
                                txtMiddleName.Text = If(IsDBNull(rdr("middle_name")), "", rdr("middle_name").ToString())
                                txtLastName.Text = rdr("last_name").ToString()
                                txtSuffix.Text = If(IsDBNull(rdr("suffix")), "", rdr("suffix").ToString())
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading profile details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        ' Validations
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MessageBox.Show("First Name cannot be left blank.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("Last Name cannot be left blank.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim inputEmail As String = txtEmail.Text.Trim()
        If String.IsNullOrWhiteSpace(inputEmail) OrElse Not inputEmail.ToLower().EndsWith("@plpasig.edu.ph") Then
            MessageBox.Show("Please enter a valid PLP webmail ending with '@plpasig.edu.ph'.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbYearLevel.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Year Level.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim newYearLevel As String = cmbYearLevel.SelectedItem.ToString()
                    Dim newPassword As String = txtNewPassword.Text.Trim()
                    Dim hashedPassword As String = ""

                    ' SQL Update mapped directly to separate columns
                    Dim query As String = "UPDATE students SET first_name = @fname, middle_name = @mname, last_name = @lname, suffix = @suffix, email = @email, year_level = @year "

                    If Not String.IsNullOrEmpty(newPassword) Then
                        If newPassword.Length < 8 Then
                            MessageBox.Show("New password must be at least 8 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword, BCrypt.Net.BCrypt.GenerateSalt(11))
                        query &= ", password_hash = @hash "
                    End If

                    query &= "WHERE student_number = @stud"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim())
                        cmd.Parameters.AddWithValue("@mname", If(String.IsNullOrWhiteSpace(txtMiddleName.Text), DBNull.Value, txtMiddleName.Text.Trim()))
                        cmd.Parameters.AddWithValue("@lname", txtLastName.Text.Trim())
                        cmd.Parameters.AddWithValue("@suffix", If(String.IsNullOrWhiteSpace(txtSuffix.Text), DBNull.Value, txtSuffix.Text.Trim()))
                        cmd.Parameters.AddWithValue("@email", inputEmail)
                        cmd.Parameters.AddWithValue("@year", newYearLevel)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)

                        If Not String.IsNullOrEmpty(hashedPassword) Then
                            cmd.Parameters.AddWithValue("@hash", hashedPassword)
                        End If

                        cmd.ExecuteNonQuery()
                    End Using

                    ' Reconstruct Full Name for session variable
                    Dim formattedFullName As String = txtFirstName.Text.Trim()
                    If Not String.IsNullOrWhiteSpace(txtMiddleName.Text) Then formattedFullName &= " " & txtMiddleName.Text.Trim()
                    formattedFullName &= " " & txtLastName.Text.Trim()
                    If Not String.IsNullOrWhiteSpace(txtSuffix.Text) Then formattedFullName &= " " & txtSuffix.Text.Trim()

                    CurrentUserFullName = formattedFullName
                    CurrentUserEmail = inputEmail
                    CurrentUserYearLevel = newYearLevel

                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating profile: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class