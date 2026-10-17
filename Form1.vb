Imports MySql.Data.MySqlClient

Public Class frmRegister

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default program selection (optional)
        If cmbProgram.Items.Count > 0 Then
            cmbProgram.SelectedIndex = 0
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckShowPass.CheckedChanged
        Dim showPassword As Boolean = chckShowPass.Checked
        txtPassword.UseSystemPasswordChar = Not showPassword
        txtConfirmPass.UseSystemPasswordChar = Not showPassword
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            Dim studentNum As String = txtStudentNum.Text.Trim()
            Dim email As String = txtEmail.Text.Trim().ToLower()
            Dim firstName As String = txtFirstName.Text.Trim()
            Dim middleName As String = txtMidName.Text.Trim()
            Dim lastName As String = txtLastName.Text.Trim()

            ' Suffix handling
            Dim suffixVal As String = ""
            If cmbSuffix.SelectedIndex > 0 Then
                suffixVal = cmbSuffix.SelectedItem.ToString().Trim()
                If suffixVal.Equals("(None)", StringComparison.OrdinalIgnoreCase) Then suffixVal = ""
            End If

            ' Read selected program directly from cmbProgram
            Dim degreeProgram As String = If(cmbProgram.SelectedItem IsNot Nothing, cmbProgram.SelectedItem.ToString(), "")
            Dim yearLevel As String = If(cmbYearLevel.SelectedItem IsNot Nothing, cmbYearLevel.SelectedItem.ToString(), "")
            Dim password As String = txtPassword.Text
            Dim confirmPwd As String = txtConfirmPass.Text

            ' Hardcode College since the UI input was removed
            Dim college As String = "College of Computer Studies (CCS)"

            ' 1. Validations
            If String.IsNullOrWhiteSpace(studentNum) OrElse String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) Then
                MessageBox.Show("Please fill out all required name and contact fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not email.EndsWith("@plpasig.edu.ph") Then
                MessageBox.Show("Please enter a valid official PLP webmail address (@plpasig.edu.ph).", "Invalid Email Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(degreeProgram) Then
                MessageBox.Show("Please select your Degree Program.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(yearLevel) Then
                MessageBox.Show("Please select your Year Level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

            ' 2. Hash Password
            Dim salt As String = BCrypt.Net.BCrypt.GenerateSalt(11)
            Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password, salt)

            ' 3. Database Insertion into eportfoliodb
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "INSERT INTO students (student_number, first_name, middle_name, suffix, last_name, email, password_hash, college, degree_program, year_level) " &
                                      "VALUES (@student_number, @first_name, @middle_name, @suffix, @last_name, @email, @password_hash, @college, @degree_program, @year_level)"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@student_number", studentNum)
                        cmd.Parameters.AddWithValue("@first_name", firstName)
                        cmd.Parameters.AddWithValue("@middle_name", middleName)
                        cmd.Parameters.AddWithValue("@suffix", suffixVal)
                        cmd.Parameters.AddWithValue("@last_name", lastName)
                        cmd.Parameters.AddWithValue("@email", email)
                        cmd.Parameters.AddWithValue("@password_hash", hashedPassword)
                        cmd.Parameters.AddWithValue("@college", college)
                        cmd.Parameters.AddWithValue("@degree_program", degreeProgram)
                        cmd.Parameters.AddWithValue("@year_level", yearLevel)

                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Account successfully created! Redirecting to login...", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim loginForm As New frmLogin()
                        loginForm.Show()
                        Me.Hide()
                    End Using
                End If
            End Using

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("A student record with this Student Number or Email already exists.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error Details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginForm As New frmLogin()
        loginForm.Show()
        Me.Hide()
    End Sub

End Class