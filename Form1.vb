Public Class frmRegister
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate PLP Colleges
        cmbCollege.Items.Clear()
        cmbCollege.Items.AddRange(New Object() {
            "College of Arts and Sciences (CAS)",
            "College of Business and Accountancy (CBA)",
            "College of Computer Studies (CCS)",
            "College of Education (COED)",
            "College of Engineering (COE)",
            "College of International Hospitality Management (CIHM)",
            "College of Nursing (CON)"
        })

        ' Keep program section hidden initially
        pnlPrograms.Visible = False
        pnlPrograms.Enabled = False
    End Sub

    Private Sub cmbCollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCollege.SelectedIndexChanged
        ' Reset states
        rdoProg1.Checked = False : rdoProg2.Checked = False
        rdoProg3.Checked = False : rdoProg4.Checked = False

        rdoProg1.Visible = False : rdoProg2.Visible = False
        rdoProg3.Visible = False : rdoProg4.Visible = False

        Dim selectedCollege As String = cmbCollege.Text

        If String.IsNullOrWhiteSpace(selectedCollege) Then
            pnlPrograms.Visible = False
            pnlPrograms.Enabled = False
            Return
        Else
            pnlPrograms.Visible = True
            pnlPrograms.Enabled = True
        End If

        ' Map PLP Programs to Selected College
        Select Case True
            Case selectedCollege.Contains("CAS")
                rdoProg1.Text = "Bachelor of Arts in Psychology (AB Psych)"
                rdoProg1.Visible = True

            Case selectedCollege.Contains("CBA")
                rdoProg1.Text = "Bachelor of Science in Accountancy (BSA)"
                rdoProg2.Text = "BSBA major in Marketing Management (BSBA MM)"
                rdoProg3.Text = "Bachelor of Science in Entrepreneurship (BS Entrep)"
                rdoProg1.Visible = True
                rdoProg2.Visible = True
                rdoProg3.Visible = True

            Case selectedCollege.Contains("CCS")
                rdoProg1.Text = "Bachelor of Science in Information Technology (BSIT)"
                rdoProg2.Text = "Bachelor of Science in Computer Science (BSCS)"
                rdoProg1.Visible = True
                rdoProg2.Visible = True

            Case selectedCollege.Contains("COED")
                rdoProg1.Text = "Bachelor of Elementary Education (BEED)"
                rdoProg2.Text = "BSED major in English (BSED English)"
                rdoProg3.Text = "BSED major in Filipino (BSED Filipino)"
                rdoProg4.Text = "BSED major in Mathematics (BSED Mathematics)"
                rdoProg1.Visible = True
                rdoProg2.Visible = True
                rdoProg3.Visible = True
                rdoProg4.Visible = True

            Case selectedCollege.Contains("COE") AndAlso Not selectedCollege.Contains("COED")
                rdoProg1.Text = "BS in Electronics Engineering (BSECE)"
                rdoProg1.Visible = True

            Case selectedCollege.Contains("CIHM")
                rdoProg1.Text = "BS in Hospitality Management (BSHM)"
                rdoProg1.Visible = True

            Case selectedCollege.Contains("CON")
                rdoProg1.Text = "Bachelor of Science in Nursing (BSN)"
                rdoProg1.Visible = True
        End Select
    End Sub

    Private Function GetSelectedProgram() As String
        If Not pnlPrograms.Enabled Then Return String.Empty

        If rdoProg1.Checked AndAlso rdoProg1.Visible Then Return rdoProg1.Text
        If rdoProg2.Checked AndAlso rdoProg2.Visible Then Return rdoProg2.Text
        If rdoProg3.Checked AndAlso rdoProg3.Visible Then Return rdoProg3.Text
        If rdoProg4.Checked AndAlso rdoProg4.Visible Then Return rdoProg4.Text

        Return String.Empty
    End Function

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckShowPass.CheckedChanged
        ' Toggle system password character for both textboxes
        Dim showPassword As Boolean = chckShowPass.Checked

        txtPassword.UseSystemPasswordChar = Not showPassword
        txtConfirmPass.UseSystemPasswordChar = Not showPassword
    End Sub
End Class
