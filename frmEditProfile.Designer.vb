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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
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
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(45, Byte), Integer))
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
        Me.lblStudentNum.Size = New System.Drawing.Size(210, 20)
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
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.Location = New System.Drawing.Point(24, 130)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(96, 20)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name *"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(25, 155)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(205, 30)
        Me.txtFirstName.TabIndex = 4
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMiddleName.Location = New System.Drawing.Point(246, 130)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(103, 20)
        Me.lblMiddleName.TabIndex = 5
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMiddleName.Location = New System.Drawing.Point(250, 155)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(205, 30)
        Me.txtMiddleName.TabIndex = 6
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.Location = New System.Drawing.Point(24, 195)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(94, 20)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name *"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtLastName.Location = New System.Drawing.Point(25, 220)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(280, 30)
        Me.txtLastName.TabIndex = 8
        '
        'lblSuffix
        '
        Me.lblSuffix.AutoSize = True
        Me.lblSuffix.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSuffix.Location = New System.Drawing.Point(321, 195)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(51, 20)
        Me.lblSuffix.TabIndex = 9
        Me.lblSuffix.Text = "Suffix"
        '
        'txtSuffix
        '
        Me.txtSuffix.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSuffix.Location = New System.Drawing.Point(325, 220)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(130, 30)
        Me.txtSuffix.TabIndex = 10
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(24, 260)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(81, 20)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Webmail *"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(25, 285)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(430, 30)
        Me.txtEmail.TabIndex = 12
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblYearLevel.Location = New System.Drawing.Point(24, 325)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(90, 20)
        Me.lblYearLevel.TabIndex = 13
        Me.lblYearLevel.Text = "Year Level *"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(25, 350)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(430, 31)
        Me.cmbYearLevel.TabIndex = 14
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewPassword.Location = New System.Drawing.Point(24, 390)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(262, 20)
        Me.lblNewPassword.TabIndex = 15
        Me.lblNewPassword.Text = "New Password (leave blank to keep)"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNewPassword.Location = New System.Drawing.Point(25, 415)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(430, 30)
        Me.txtNewPassword.TabIndex = 16
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProfile.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveProfile.ForeColor = System.Drawing.Color.White
        Me.btnSaveProfile.Location = New System.Drawing.Point(205, 470)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(120, 38)
        Me.btnSaveProfile.TabIndex = 17
        Me.btnSaveProfile.Text = "Save Changes"
        Me.btnSaveProfile.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(335, 470)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 38)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmEditProfile
        '
        Me.ClientSize = New System.Drawing.Size(480, 530)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveProfile)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.cmbYearLevel)
        Me.Controls.Add(Me.lblYearLevel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtSuffix)
        Me.Controls.Add(Me.lblSuffix)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
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
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents cmbYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveProfile As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class