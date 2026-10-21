<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditProfile
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblStudentNum = New System.Windows.Forms.Label()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.btnSaveProfile = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(236, 32)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Edit Student Profile"
        '
        'lblStudentNum
        '
        Me.lblStudentNum.AutoSize = True
        Me.lblStudentNum.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentNum.Location = New System.Drawing.Point(24, 65)
        Me.lblStudentNum.Name = "lblStudentNum"
        Me.lblStudentNum.Size = Me.lblStudentNum.Size
        Me.lblStudentNum.TabIndex = 1
        Me.lblStudentNum.Text = "Student Number (Read Only)"
        '
        'txtStudentNum
        '
        Me.txtStudentNum.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStudentNum.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStudentNum.Location = New System.Drawing.Point(25, 90)
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.ReadOnly = True
        Me.txtStudentNum.Size = New System.Drawing.Size(430, 30)
        Me.txtStudentNum.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(24, 130)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(167, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Full Name (Read Only)"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtName.Location = New System.Drawing.Point(25, 155)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(430, 30)
        Me.txtName.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(24, 195)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(158, 20)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Webmail (Read Only)"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(25, 220)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(430, 30)
        Me.txtEmail.TabIndex = 6
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblYearLevel.Location = New System.Drawing.Point(24, 260)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(90, 20)
        Me.lblYearLevel.TabIndex = 7
        Me.lblYearLevel.Text = "Year Level *"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(25, 285)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(430, 31)
        Me.cmbYearLevel.TabIndex = 8
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewPassword.Location = New System.Drawing.Point(24, 325)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(262, 20)
        Me.lblNewPassword.TabIndex = 9
        Me.lblNewPassword.Text = "New Password (leave blank to keep)"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNewPassword.Location = New System.Drawing.Point(25, 350)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(430, 30)
        Me.txtNewPassword.TabIndex = 10
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProfile.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveProfile.ForeColor = System.Drawing.Color.White
        Me.btnSaveProfile.Location = New System.Drawing.Point(205, 405)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(120, 38)
        Me.btnSaveProfile.TabIndex = 11
        Me.btnSaveProfile.Text = "Save Changes"
        Me.btnSaveProfile.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(335, 405)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 38)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmEditProfile
        '
        Me.ClientSize = New System.Drawing.Size(480, 465)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveProfile)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.cmbYearLevel)
        Me.Controls.Add(Me.lblYearLevel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtStudentNum)
        Me.Controls.Add(Me.lblStudentNum)
        Me.Controls.Add(Me.lblFormTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Profile Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblStudentNum As System.Windows.Forms.Label
    Friend WithEvents txtStudentNum As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents cmbYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveProfile As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class