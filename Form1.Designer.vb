<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblAlreadyReg = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblMainLogo = New System.Windows.Forms.Label()
        Me.btnNavLogin = New System.Windows.Forms.Button()
        Me.pnlMainCard = New System.Windows.Forms.Panel()
        Me.pnlRightForm = New System.Windows.Forms.Panel()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.cmbSuffix = New System.Windows.Forms.ComboBox()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.txtMidName = New System.Windows.Forms.TextBox()
        Me.lblMidName = New System.Windows.Forms.Label()
        Me.cmbProgram = New System.Windows.Forms.ComboBox()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.lblStudNumHint = New System.Windows.Forms.Label()
        Me.lblStudentNum = New System.Windows.Forms.Label()
        Me.lblFormSubHeader = New System.Windows.Forms.Label()
        Me.lblFormHeader = New System.Windows.Forms.Label()
        Me.pnlLeftBanner = New System.Windows.Forms.Panel()
        Me.lblFooterDesc = New System.Windows.Forms.Label()
        Me.picCampus = New System.Windows.Forms.PictureBox()
        Me.lblBannerTitle = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMainCard.SuspendLayout()
        Me.pnlRightForm.SuspendLayout()
        Me.pnlLeftBanner.SuspendLayout()
        CType(Me.picCampus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblAlreadyReg)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)
        Me.pnlHeader.Controls.Add(Me.lblMainLogo)
        Me.pnlHeader.Controls.Add(Me.btnNavLogin)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 75)
        Me.pnlHeader.TabIndex = 0
        '
        'lblAlreadyReg
        '
        Me.lblAlreadyReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlreadyReg.AutoSize = True
        Me.lblAlreadyReg.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblAlreadyReg.ForeColor = System.Drawing.Color.White
        Me.lblAlreadyReg.Location = New System.Drawing.Point(955, 27)
        Me.lblAlreadyReg.Name = "lblAlreadyReg"
        Me.lblAlreadyReg.Size = New System.Drawing.Size(144, 21)
        Me.lblAlreadyReg.TabIndex = 3
        Me.lblAlreadyReg.Text = "Already registered?"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblSubTitle.Location = New System.Drawing.Point(32, 45)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(135, 20)
        Me.lblSubTitle.TabIndex = 2
        Me.lblSubTitle.Text = "Student E-Portfolio"
        '
        'lblMainLogo
        '
        Me.lblMainLogo.AutoSize = True
        Me.lblMainLogo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMainLogo.ForeColor = System.Drawing.Color.White
        Me.lblMainLogo.Location = New System.Drawing.Point(30, 12)
        Me.lblMainLogo.Name = "lblMainLogo"
        Me.lblMainLogo.Size = New System.Drawing.Size(172, 32)
        Me.lblMainLogo.TabIndex = 1
        Me.lblMainLogo.Text = "PLPORTFOLIO"
        '
        'btnNavLogin
        '
        Me.btnNavLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnNavLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNavLogin.FlatAppearance.BorderSize = 2
        Me.btnNavLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavLogin.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNavLogin.ForeColor = System.Drawing.Color.White
        Me.btnNavLogin.Location = New System.Drawing.Point(1090, 18)
        Me.btnNavLogin.Name = "btnNavLogin"
        Me.btnNavLogin.Size = New System.Drawing.Size(85, 38)
        Me.btnNavLogin.TabIndex = 0
        Me.btnNavLogin.Text = "Log In"
        Me.btnNavLogin.UseVisualStyleBackColor = False
        '
        'pnlMainCard
        '
        Me.pnlMainCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlMainCard.BackColor = System.Drawing.Color.White
        Me.pnlMainCard.Controls.Add(Me.pnlRightForm)
        Me.pnlMainCard.Controls.Add(Me.pnlLeftBanner)
        Me.pnlMainCard.Location = New System.Drawing.Point(135, 95)
        Me.pnlMainCard.Name = "pnlMainCard"
        Me.pnlMainCard.Size = New System.Drawing.Size(930, 580)
        Me.pnlMainCard.TabIndex = 1
        '
        'pnlRightForm
        '
        Me.pnlRightForm.Controls.Add(Me.btnRegister)
        Me.pnlRightForm.Controls.Add(Me.chkShowPass)
        Me.pnlRightForm.Controls.Add(Me.txtConfirmPass)
        Me.pnlRightForm.Controls.Add(Me.lblConfirmPassword)
        Me.pnlRightForm.Controls.Add(Me.txtPassword)
        Me.pnlRightForm.Controls.Add(Me.lblPassword)
        Me.pnlRightForm.Controls.Add(Me.cmbSuffix)
        Me.pnlRightForm.Controls.Add(Me.lblSuffix)
        Me.pnlRightForm.Controls.Add(Me.txtMidName)
        Me.pnlRightForm.Controls.Add(Me.lblMidName)
        Me.pnlRightForm.Controls.Add(Me.cmbProgram)
        Me.pnlRightForm.Controls.Add(Me.lblProgram)
        Me.pnlRightForm.Controls.Add(Me.cmbYearLevel)
        Me.pnlRightForm.Controls.Add(Me.lblYearLevel)
        Me.pnlRightForm.Controls.Add(Me.txtLastName)
        Me.pnlRightForm.Controls.Add(Me.lblLastName)
        Me.pnlRightForm.Controls.Add(Me.txtFirstName)
        Me.pnlRightForm.Controls.Add(Me.lblFirstName)
        Me.pnlRightForm.Controls.Add(Me.txtEmail)
        Me.pnlRightForm.Controls.Add(Me.lblEmail)
        Me.pnlRightForm.Controls.Add(Me.txtStudentNum)
        Me.pnlRightForm.Controls.Add(Me.lblStudNumHint)
        Me.pnlRightForm.Controls.Add(Me.lblStudentNum)
        Me.pnlRightForm.Controls.Add(Me.lblFormSubHeader)
        Me.pnlRightForm.Controls.Add(Me.lblFormHeader)
        Me.pnlRightForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRightForm.Location = New System.Drawing.Point(310, 0)
        Me.pnlRightForm.Name = "pnlRightForm"
        Me.pnlRightForm.Padding = New System.Windows.Forms.Padding(25, 15, 25, 15)
        Me.pnlRightForm.Size = New System.Drawing.Size(620, 580)
        Me.pnlRightForm.TabIndex = 1
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(28, 465)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(564, 42)
        Me.btnRegister.TabIndex = 24
        Me.btnRegister.Text = "Register Account"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPass.ForeColor = System.Drawing.Color.Black
        Me.chkShowPass.Location = New System.Drawing.Point(504, 390)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(62, 32)
        Me.chkShowPass.TabIndex = 23
        Me.chkShowPass.Text = "👁"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPass.Location = New System.Drawing.Point(318, 395)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(180, 27)
        Me.txtConfirmPass.TabIndex = 22
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblConfirmPassword.Location = New System.Drawing.Point(315, 375)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(155, 19)
        Me.lblConfirmPassword.TabIndex = 21
        Me.lblConfirmPassword.Text = "CONFIRM PASSWORD"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.Location = New System.Drawing.Point(123, 395)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(180, 27)
        Me.txtPassword.TabIndex = 20
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPassword.Location = New System.Drawing.Point(120, 375)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 19)
        Me.lblPassword.TabIndex = 19
        Me.lblPassword.Text = "PASSWORD"
        '
        'cmbSuffix
        '
        Me.cmbSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSuffix.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbSuffix.FormattingEnabled = True
        Me.cmbSuffix.Items.AddRange(New Object() {"(None)", "Jr.", "Sr.", "III", "IV"})
        Me.cmbSuffix.Location = New System.Drawing.Point(28, 332)
        Me.cmbSuffix.Name = "cmbSuffix"
        Me.cmbSuffix.Size = New System.Drawing.Size(274, 28)
        Me.cmbSuffix.TabIndex = 18
        '
        'lblSuffix
        '
        Me.lblSuffix.AutoSize = True
        Me.lblSuffix.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblSuffix.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblSuffix.Location = New System.Drawing.Point(25, 312)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(54, 19)
        Me.lblSuffix.TabIndex = 17
        Me.lblSuffix.Text = "SUFFIX"
        '
        'txtMidName
        '
        Me.txtMidName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMidName.Location = New System.Drawing.Point(28, 274)
        Me.txtMidName.Name = "txtMidName"
        Me.txtMidName.Size = New System.Drawing.Size(274, 27)
        Me.txtMidName.TabIndex = 16
        '
        'lblMidName
        '
        Me.lblMidName.AutoSize = True
        Me.lblMidName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblMidName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMidName.Location = New System.Drawing.Point(25, 254)
        Me.lblMidName.Name = "lblMidName"
        Me.lblMidName.Size = New System.Drawing.Size(100, 19)
        Me.lblMidName.TabIndex = 15
        Me.lblMidName.Text = "Middle Name"
        '
        'cmbProgram
        '
        Me.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgram.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Items.AddRange(New Object() {"Bachelor of Science in Information Technology", "Bachelor of Science in Computer Science"})
        Me.cmbProgram.Location = New System.Drawing.Point(318, 216)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(274, 28)
        Me.cmbProgram.TabIndex = 14
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblProgram.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblProgram.Location = New System.Drawing.Point(315, 196)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(80, 19)
        Me.lblProgram.TabIndex = 13
        Me.lblProgram.Text = "PROGRAM"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(318, 158)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(274, 28)
        Me.cmbYearLevel.TabIndex = 10
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblYearLevel.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblYearLevel.Location = New System.Drawing.Point(315, 138)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(85, 19)
        Me.lblYearLevel.TabIndex = 9
        Me.lblYearLevel.Text = "YEAR LEVEL"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastName.Location = New System.Drawing.Point(28, 216)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(274, 27)
        Me.txtLastName.TabIndex = 12
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblLastName.Location = New System.Drawing.Point(25, 196)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(87, 19)
        Me.lblLastName.TabIndex = 11
        Me.lblLastName.Text = "LAST NAME"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(28, 158)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(274, 27)
        Me.txtFirstName.TabIndex = 8
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFirstName.Location = New System.Drawing.Point(25, 138)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(90, 19)
        Me.lblFirstName.TabIndex = 7
        Me.lblFirstName.Text = "FIRST NAME"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.Location = New System.Drawing.Point(318, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(274, 27)
        Me.txtEmail.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEmail.Location = New System.Drawing.Point(315, 80)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(116, 19)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "EMAIL ADDRESS"
        '
        'txtStudentNum
        '
        Me.txtStudentNum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudentNum.Location = New System.Drawing.Point(28, 100)
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.Size = New System.Drawing.Size(274, 27)
        Me.txtStudentNum.TabIndex = 4
        '
        'lblStudNumHint
        '
        Me.lblStudNumHint.AutoSize = True
        Me.lblStudNumHint.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lblStudNumHint.ForeColor = System.Drawing.Color.Gray
        Me.lblStudNumHint.Location = New System.Drawing.Point(220, 81)
        Me.lblStudNumHint.Name = "lblStudNumHint"
        Me.lblStudNumHint.Size = New System.Drawing.Size(79, 15)
        Me.lblStudNumHint.TabIndex = 3
        Me.lblStudNumHint.Text = "e.g., 25-00123"
        '
        'lblStudentNum
        '
        Me.lblStudentNum.AutoSize = True
        Me.lblStudentNum.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudentNum.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblStudentNum.Location = New System.Drawing.Point(25, 80)
        Me.lblStudentNum.Name = "lblStudentNum"
        Me.lblStudentNum.Size = New System.Drawing.Size(134, 19)
        Me.lblStudentNum.TabIndex = 2
        Me.lblStudentNum.Text = "STUDENT NUMBER"
        '
        'lblFormSubHeader
        '
        Me.lblFormSubHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblFormSubHeader.ForeColor = System.Drawing.Color.Gray
        Me.lblFormSubHeader.Location = New System.Drawing.Point(25, 48)
        Me.lblFormSubHeader.Name = "lblFormSubHeader"
        Me.lblFormSubHeader.Size = New System.Drawing.Size(560, 22)
        Me.lblFormSubHeader.TabIndex = 1
        Me.lblFormSubHeader.Text = "Sign up to start building your academic e-portfolio with your student profile."
        '
        'lblFormHeader
        '
        Me.lblFormHeader.AutoSize = True
        Me.lblFormHeader.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblFormHeader.Location = New System.Drawing.Point(22, 10)
        Me.lblFormHeader.Name = "lblFormHeader"
        Me.lblFormHeader.Size = New System.Drawing.Size(303, 41)
        Me.lblFormHeader.TabIndex = 0
        Me.lblFormHeader.Text = "Create Your Account"
        '
        'pnlLeftBanner
        '
        Me.pnlLeftBanner.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlLeftBanner.Controls.Add(Me.lblFooterDesc)
        Me.pnlLeftBanner.Controls.Add(Me.picCampus)
        Me.pnlLeftBanner.Controls.Add(Me.lblBannerTitle)
        Me.pnlLeftBanner.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftBanner.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftBanner.Name = "pnlLeftBanner"
        Me.pnlLeftBanner.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlLeftBanner.Size = New System.Drawing.Size(310, 580)
        Me.pnlLeftBanner.TabIndex = 0
        '
        'lblFooterDesc
        '
        Me.lblFooterDesc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblFooterDesc.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblFooterDesc.ForeColor = System.Drawing.Color.LightGray
        Me.lblFooterDesc.Location = New System.Drawing.Point(20, 485)
        Me.lblFooterDesc.Name = "lblFooterDesc"
        Me.lblFooterDesc.Size = New System.Drawing.Size(270, 75)
        Me.lblFooterDesc.TabIndex = 2
        Me.lblFooterDesc.Text = "PLPORTFOLIO empowers Pasigueño scholars to catalog capstone works, verify curricu" &
    "lar competencies, and showcase achievements to institutional partners."
        '
        'picCampus
        '
        Me.picCampus.Location = New System.Drawing.Point(20, 140)
        Me.picCampus.Name = "picCampus"
        Me.picCampus.Size = New System.Drawing.Size(270, 200)
        Me.picCampus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCampus.TabIndex = 1
        Me.picCampus.TabStop = False
        '
        'lblBannerTitle
        '
        Me.lblBannerTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblBannerTitle.ForeColor = System.Drawing.Color.White
        Me.lblBannerTitle.Location = New System.Drawing.Point(20, 25)
        Me.lblBannerTitle.Name = "lblBannerTitle"
        Me.lblBannerTitle.Size = New System.Drawing.Size(270, 100)
        Me.lblBannerTitle.TabIndex = 0
        Me.lblBannerTitle.Text = "Build your verified digital academic footprint."
        '
        'frmRegister
        '
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlMainCard)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Account - PLPORTFOLIO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMainCard.ResumeLayout(False)
        Me.pnlRightForm.ResumeLayout(False)
        Me.pnlRightForm.PerformLayout()
        Me.pnlLeftBanner.ResumeLayout(False)
        CType(Me.picCampus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents btnNavLogin As System.Windows.Forms.Button
    Friend WithEvents lblMainLogo As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents lblAlreadyReg As System.Windows.Forms.Label
    Friend WithEvents pnlMainCard As System.Windows.Forms.Panel
    Friend WithEvents pnlLeftBanner As System.Windows.Forms.Panel
    Friend WithEvents lblBannerTitle As System.Windows.Forms.Label
    Friend WithEvents picCampus As System.Windows.Forms.PictureBox
    Friend WithEvents lblFooterDesc As System.Windows.Forms.Label
    Friend WithEvents pnlRightForm As System.Windows.Forms.Panel
    Friend WithEvents lblFormHeader As System.Windows.Forms.Label
    Friend WithEvents lblFormSubHeader As System.Windows.Forms.Label
    Friend WithEvents lblStudentNum As System.Windows.Forms.Label
    Friend WithEvents lblStudNumHint As System.Windows.Forms.Label
    Friend WithEvents txtStudentNum As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents cmbYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents cmbProgram As System.Windows.Forms.ComboBox
    Friend WithEvents lblMidName As System.Windows.Forms.Label
    Friend WithEvents txtMidName As System.Windows.Forms.TextBox
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Friend WithEvents cmbSuffix As System.Windows.Forms.ComboBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents chkShowPass As System.Windows.Forms.CheckBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
End Class