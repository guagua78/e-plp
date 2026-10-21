Imports MySql.Data.MySqlClient

Public Class frmRegister

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default password masking on form launch
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True

        If cmbProgram.Items.Count > 0 Then cmbProgram.SelectedIndex = 0
        If cmbYearLevel.Items.Count > 0 Then cmbYearLevel.SelectedIndex = 0
        If cmbSuffix.Items.Count > 0 Then cmbSuffix.SelectedIndex = 0
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        ' When checked = False, mask input with system bullet dots (●)
        ' When checked = True, unmask input to plain text
        Dim hidePassword As Boolean = Not chkShowPass.Checked
        txtPassword.UseSystemPasswordChar = hidePassword
        txtConfirmPass.UseSystemPasswordChar = hidePassword
    End Sub

    ' Navigation to Login
    Private Sub btnNavLogin_Click(sender As Object, e As EventArgs) Handles btnNavLogin.Click
        Dim loginForm As New frmLogin()
        loginForm.Show()
        Me.Hide() ' Keeps the main app thread alive
    End Sub

    ' Registration Action Handler
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            Dim studentNum As String = txtStudentNum.Text.Trim()
            Dim email As String = txtEmail.Text.Trim().ToLower()
            Dim firstName As String = txtFirstName.Text.Trim()
            Dim middleName As String = txtMidName.Text.Trim()
            Dim lastName As String = txtLastName.Text.Trim()

            Dim suffixVal As String = ""
            If cmbSuffix.SelectedIndex > 0 Then
                suffixVal = cmbSuffix.SelectedItem.ToString().Trim()
                If suffixVal.Equals("(None)", StringComparison.OrdinalIgnoreCase) Then suffixVal = ""
            End If

            Dim degreeProgram As String = If(cmbProgram.SelectedItem IsNot Nothing, cmbProgram.SelectedItem.ToString(), "")
            Dim yearLevel As String = If(cmbYearLevel.SelectedItem IsNot Nothing, cmbYearLevel.SelectedItem.ToString(), "")
            Dim password As String = txtPassword.Text
            Dim confirmPwd As String = txtConfirmPass.Text

            ' Basic Input Validation
            If String.IsNullOrWhiteSpace(studentNum) OrElse String.IsNullOrWhiteSpace(email) OrElse
               String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse
               String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If password.Length < 8 Then
                MessageBox.Show("Password must be at least 8 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If password <> confirmPwd Then
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Insert Into Database
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim checkQuery As String = "SELECT COUNT(*) FROM students WHERE student_number = @stud OR email = @email"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@stud", studentNum)
                        checkCmd.Parameters.AddWithValue("@email", email)

                        If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                            MessageBox.Show("A student with this Student Number or Email already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End Using

                    Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(password)

                    Dim insertQuery As String = "INSERT INTO students (student_number, email, first_name, middle_name, last_name, suffix, program, year_level, password_hash) " &
                                                "VALUES (@stud, @email, @fname, @mname, @lname, @suffix, @program, @year, @passHash)"

                    Using insertCmd As New MySqlCommand(insertQuery, conn)
                        insertCmd.Parameters.AddWithValue("@stud", studentNum)
                        insertCmd.Parameters.AddWithValue("@email", email)
                        insertCmd.Parameters.AddWithValue("@fname", firstName)
                        insertCmd.Parameters.AddWithValue("@mname", middleName)
                        insertCmd.Parameters.AddWithValue("@lname", lastName)
                        insertCmd.Parameters.AddWithValue("@suffix", suffixVal)
                        insertCmd.Parameters.AddWithValue("@program", degreeProgram)
                        insertCmd.Parameters.AddWithValue("@year", yearLevel)
                        insertCmd.Parameters.AddWithValue("@passHash", passwordHash)

                        insertCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Account registered successfully! You may now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim loginForm As New frmLogin()
                    loginForm.Show()
                    Me.Close()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Registration error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class