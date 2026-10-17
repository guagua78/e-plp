Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtPass.Text = ""
        txtPass.UseSystemPasswordChar = True
    End Sub

    ' Toggle Password Visibility
    Private Sub chckShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chckShowPass.CheckedChanged
        txtPass.UseSystemPasswordChar = Not chckShowPass.Checked
    End Sub

    ' Sign In Action
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim inputIdentifier As String = txtUsername.Text.Trim().ToLower()
        Dim passwordInput As String = txtPass.Text

        ' 1. Check for empty inputs
        If String.IsNullOrWhiteSpace(inputIdentifier) OrElse String.IsNullOrWhiteSpace(passwordInput) Then
            MessageBox.Show("Please enter your Student Number / Webmail and Password.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    ' 2. Query checks both LOWER(email) OR LOWER(student_number)
                    Dim query As String = "SELECT student_number, first_name, last_name, email, password_hash, college, degree_program, year_level " &
                                          "FROM students " &
                                          "WHERE LOWER(email) = @input OR LOWER(student_number) = @input LIMIT 1"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@input", inputIdentifier)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                Dim storedHash As String = reader("password_hash").ToString()

                                ' 3. Verify BCrypt password hash
                                If BCrypt.Net.BCrypt.Verify(passwordInput, storedHash) Then
                                    ' Set Session Variables in Globals.vb
                                    CurrentStudentNumber = reader("student_number").ToString()
                                    CurrentUserFullName = $"{reader("first_name")} {reader("last_name")}"
                                    CurrentUserEmail = reader("email").ToString()
                                    CurrentUserCollege = reader("college").ToString()
                                    CurrentUserProgram = reader("degree_program").ToString()
                                    CurrentUserYearLevel = reader("year_level").ToString()

                                    MessageBox.Show($"Welcome back, {CurrentUserFullName}!", "Authentication Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)


                                Else
                                    MessageBox.Show("Invalid password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("No account found matching that Student Number or Webmail.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Login Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        ' Open Registration Form
        Dim regForm As New frmRegister()
        regForm.Show()
        Me.Hide()
    End Sub
End Class