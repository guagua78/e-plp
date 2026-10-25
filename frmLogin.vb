Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class frmLogin

    Private isPasswordVisible As Boolean = False

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        ' Reset input fields
        txtUsername.Text = ""
        txtPass.Text = ""
        txtPass.UseSystemPasswordChar = True
        isPasswordVisible = False
    End Sub

    ' Display Support Desk Info Message
    Private Sub lblSupportDesk_Click(sender As Object, e As EventArgs) Handles lblSupportDesk.Click
        Dim supportMsg As String = "PLP College of Computer Studies — Support Desk" & vbCrLf & vbCrLf &
                               "Please proceed to the MIS Office at the 1st Floor in the Main Building, " &
                               "or email ccs.support@plpasig.edu.ph for login assistance."

        MessageBox.Show(supportMsg, "CCS Support Desk", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Optional: Interactive Link Hover Effect
    Private Sub lblSupportDesk_MouseEnter(sender As Object, e As EventArgs) Handles lblSupportDesk.MouseEnter
        lblSupportDesk.ForeColor = Color.FromArgb(20, 160, 90)
        lblSupportDesk.Font = New Font(lblSupportDesk.Font, FontStyle.Underline Or FontStyle.Bold)
    End Sub

    Private Sub lblSupportDesk_MouseLeave(sender As Object, e As EventArgs) Handles lblSupportDesk.MouseLeave
        lblSupportDesk.ForeColor = Color.FromArgb(12, 105, 60)
        lblSupportDesk.Font = New Font(lblSupportDesk.Font, FontStyle.Bold)
    End Sub
    ' Background GDI+ Grid Pattern
    Private Sub frmLogin_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Using gridPen As New Pen(Color.FromArgb(18, 55, 36), 1.0F)
            For x As Integer = 0 To Me.Width Step 30
                g.DrawLine(gridPen, x, 0, x, Me.Height)
            Next
            For y As Integer = 0 To Me.Height Step 30
                g.DrawLine(gridPen, 0, y, Me.Width, y)
            Next
        End Using
    End Sub

    ' Password Toggle Icon Click
    Private Sub lblEyeToggle_Click(sender As Object, e As EventArgs) Handles lblEyeToggle.Click
        isPasswordVisible = Not isPasswordVisible
        txtPass.UseSystemPasswordChar = Not isPasswordVisible
        lblEyeToggle.Text = If(isPasswordVisible, "🙈", "👁")
    End Sub

    ' Sign In Action
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
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

                                ' Inside frmLogin.vb -> btnLogin_Click
                                If BCrypt.Net.BCrypt.Verify(passwordInput, storedHash) Then
                                    ' Save session attributes to Globals
                                    CurrentStudentNumber = reader("student_number").ToString()
                                    CurrentUserFullName = $"{reader("first_name")} {reader("last_name")}".Trim()
                                    CurrentUserEmail = reader("email").ToString()
                                    CurrentUserCollege = reader("college").ToString()
                                    CurrentUserProgram = reader("degree_program").ToString()
                                    CurrentUserYearLevel = reader("year_level").ToString()

                                    MessageBox.Show($"Welcome back, {CurrentUserFullName}!", "Authentication Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    ' Launch Dashboard
                                    Dim mainDashboard As New maindashboard()
                                    mainDashboard.Show()
                                    Me.Hide()
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

    ' Open Registration Form
    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Dim regForm As New frmRegister()
        regForm.Show()
        Me.Hide()
    End Sub

End Class