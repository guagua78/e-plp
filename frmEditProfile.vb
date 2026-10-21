Imports MySql.Data.MySqlClient

Public Class frmEditProfile

    Private Sub frmEditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStudentNum.Text = CurrentStudentNumber
        txtName.Text = CurrentUserFullName
        txtEmail.Text = CurrentUserEmail

        ' Select Current Year Level in Dropdown
        If cmbYearLevel.Items.Contains(CurrentUserYearLevel) Then
            cmbYearLevel.SelectedItem = CurrentUserYearLevel
        Else
            cmbYearLevel.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        If cmbYearLevel.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Year Level.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim newYearLevel As String = cmbYearLevel.SelectedItem.ToString()
                    Dim query As String = "UPDATE students SET year_level = @year "

                    ' Optional Password Update using BCrypt
                    Dim newPassword As String = txtNewPassword.Text.Trim()
                    If Not String.IsNullOrEmpty(newPassword) Then
                        If newPassword.Length < 8 Then
                            MessageBox.Show("New password must be at least 8 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        Dim salt As String = BCrypt.Net.BCrypt.GenerateSalt(11)
                        Dim hashed As String = BCrypt.Net.BCrypt.HashPassword(newPassword, salt)
                        query &= ", password_hash = @hash "
                    End If

                    query &= "WHERE student_number = @stud"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@year", newYearLevel)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)
                        If Not String.IsNullOrEmpty(newPassword) Then
                            cmd.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(newPassword, BCrypt.Net.BCrypt.GenerateSalt(11)))
                        End If

                        cmd.ExecuteNonQuery()
                    End Using

                    ' Update Session Variables
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