Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

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

    ' Restrict Key Input: Allow only numbers and a single hyphen (-)
    Private Sub txtStudentNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentNum.KeyPress
        ' Allow Control keys (Backspace, Delete, etc.)
        If Char.IsControl(e.KeyChar) Then Return

        ' Allow Digits
        If Char.IsDigit(e.KeyChar) Then Return

        ' Allow single hyphen (-) if not already entered
        If e.KeyChar = "-"c AndAlso Not txtStudentNum.Text.Contains("-") Then Return

        ' Block all other characters (such as '=')
        e.Handled = True
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

            ' 1. Basic Field Validation
            If String.IsNullOrWhiteSpace(studentNum) OrElse String.IsNullOrWhiteSpace(email) OrElse
               String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse
               String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' 2. Enforce Strict Student Number Format (Must be YY-XXXXX using a hyphen)
            Dim studentNoPattern As String = "^\d{2}-\d{5}$"
            If Not Regex.IsMatch(studentNum, studentNoPattern) Then
                MessageBox.Show("Invalid Student Number format. It must follow the format 'YY-XXXXX' (e.g., 25-00123) using a hyphen (-).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtStudentNum.Focus()
                Return
            End If

            ' 3. PLP Webmail Domain Validation
            If Not email.EndsWith("@plpasig.edu.ph", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Please use a valid PLP webmail address (@plpasig.edu.ph).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Focus()
                Return
            End If

            ' 4. Password Length & Match Validation
            If password.Length < 8 Then
                MessageBox.Show("Password must be at least 8 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If password <> confirmPwd Then
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' 5. Insert Into Database
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

                    Dim insertQuery As String = "INSERT INTO students (student_number, email, first_name, middle_name, last_name, suffix, degree_program, year_level, password_hash) " &
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

                    ' Navigate to login screen
                    Dim loginForm As New frmLogin()
                    loginForm.Show()
                    Me.Hide()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Registration error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class