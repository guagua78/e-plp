<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnlTopNav = New System.Windows.Forms.Panel()
        Me.lblTopLeftNav = New System.Windows.Forms.Label()
        Me.lblServerStatus = New System.Windows.Forms.Label()
        Me.pnlBottomFooter = New System.Windows.Forms.Panel()
        Me.pnlCenterCard = New System.Windows.Forms.Panel()
        Me.pnlRightSide = New System.Windows.Forms.Panel()
        Me.lblBadgePill = New System.Windows.Forms.Label()
        Me.picCenterLogo = New System.Windows.Forms.PictureBox()
        Me.lblRightTitle = New System.Windows.Forms.Label()
        Me.lblRightSubtitle = New System.Windows.Forms.Label()
        Me.lblMotto = New System.Windows.Forms.Label()
        Me.pnlLeftForm = New System.Windows.Forms.Panel()
        Me.flpRegisterContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblRegisterPrompt = New System.Windows.Forms.Label()
        Me.lnkRegister = New System.Windows.Forms.LinkLabel()
        Me.lblEyeToggle = New System.Windows.Forms.Label()
        Me.lblHeaderSub = New System.Windows.Forms.Label()
        Me.lblSupportDesk = New System.Windows.Forms.Label()
        Me.lblPLPHeader = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblSubLogin = New System.Windows.Forms.Label()
        Me.lblStudNum = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pnlTopNav.SuspendLayout()
        Me.pnlCenterCard.SuspendLayout()
        Me.pnlRightSide.SuspendLayout()
        CType(Me.picCenterLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeftForm.SuspendLayout()
        Me.flpRegisterContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopNav
        '
        Me.pnlTopNav.BackColor = System.Drawing.Color.Transparent
        Me.pnlTopNav.Controls.Add(Me.lblTopLeftNav)
        Me.pnlTopNav.Controls.Add(Me.lblServerStatus)
        Me.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopNav.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopNav.Name = "pnlTopNav"
        Me.pnlTopNav.Size = New System.Drawing.Size(1280, 50)
        Me.pnlTopNav.TabIndex = 0
        '
        'lblTopLeftNav
        '
        Me.lblTopLeftNav.AutoSize = True
        Me.lblTopLeftNav.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTopLeftNav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblTopLeftNav.Location = New System.Drawing.Point(30, 18)
        Me.lblTopLeftNav.Name = "lblTopLeftNav"
        Me.lblTopLeftNav.Size = New System.Drawing.Size(399, 20)
        Me.lblTopLeftNav.TabIndex = 0
        Me.lblTopLeftNav.Text = "PAMANTASAN NG LUNGSOD NG PASIG • E-PLPortfolio"
        '
        'lblServerStatus
        '
        Me.lblServerStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblServerStatus.AutoSize = True
        Me.lblServerStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblServerStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblServerStatus.Location = New System.Drawing.Point(1131, 18)
        Me.lblServerStatus.Name = "lblServerStatus"
        Me.lblServerStatus.Size = New System.Drawing.Size(114, 20)
        Me.lblServerStatus.TabIndex = 1
        Me.lblServerStatus.Text = " AY 2025-2026"
        '
        'pnlBottomFooter
        '
        Me.pnlBottomFooter.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomFooter.Location = New System.Drawing.Point(0, 750)
        Me.pnlBottomFooter.Name = "pnlBottomFooter"
        Me.pnlBottomFooter.Size = New System.Drawing.Size(1280, 50)
        Me.pnlBottomFooter.TabIndex = 1
        '
        'pnlCenterCard
        '
        Me.pnlCenterCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCenterCard.BackColor = System.Drawing.Color.White
        Me.pnlCenterCard.Controls.Add(Me.pnlRightSide)
        Me.pnlCenterCard.Controls.Add(Me.pnlLeftForm)
        Me.pnlCenterCard.Location = New System.Drawing.Point(120, 80)
        Me.pnlCenterCard.Name = "pnlCenterCard"
        Me.pnlCenterCard.Size = New System.Drawing.Size(1040, 640)
        Me.pnlCenterCard.TabIndex = 2
        '
        'pnlRightSide
        '
        Me.pnlRightSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlRightSide.Controls.Add(Me.lblBadgePill)
        Me.pnlRightSide.Controls.Add(Me.picCenterLogo)
        Me.pnlRightSide.Controls.Add(Me.lblRightTitle)
        Me.pnlRightSide.Controls.Add(Me.lblRightSubtitle)
        Me.pnlRightSide.Controls.Add(Me.lblMotto)
        Me.pnlRightSide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRightSide.Location = New System.Drawing.Point(540, 0)
        Me.pnlRightSide.Name = "pnlRightSide"
        Me.pnlRightSide.Size = New System.Drawing.Size(500, 640)
        Me.pnlRightSide.TabIndex = 1
        '
        'lblBadgePill
        '
        Me.lblBadgePill.AutoSize = True
        Me.lblBadgePill.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblBadgePill.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblBadgePill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblBadgePill.Location = New System.Drawing.Point(333, 21)
        Me.lblBadgePill.Name = "lblBadgePill"
        Me.lblBadgePill.Size = New System.Drawing.Size(145, 17)
        Me.lblBadgePill.TabIndex = 0
        Me.lblBadgePill.Text = "● CCS ACADEMIC HUB"
        '
        'picCenterLogo
        '
        Me.picCenterLogo.Image = CType(resources.GetObject("picCenterLogo.Image"), System.Drawing.Image)
        Me.picCenterLogo.Location = New System.Drawing.Point(167, 103)
        Me.picCenterLogo.Name = "picCenterLogo"
        Me.picCenterLogo.Size = New System.Drawing.Size(212, 180)
        Me.picCenterLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCenterLogo.TabIndex = 1
        Me.picCenterLogo.TabStop = False
        '
        'lblRightTitle
        '
        Me.lblRightTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblRightTitle.ForeColor = System.Drawing.Color.White
        Me.lblRightTitle.Location = New System.Drawing.Point(40, 325)
        Me.lblRightTitle.Name = "lblRightTitle"
        Me.lblRightTitle.Size = New System.Drawing.Size(420, 70)
        Me.lblRightTitle.TabIndex = 2
        Me.lblRightTitle.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
        Me.lblRightTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRightSubtitle
        '
        Me.lblRightSubtitle.AutoSize = True
        Me.lblRightSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRightSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblRightSubtitle.Location = New System.Drawing.Point(135, 395)
        Me.lblRightSubtitle.Name = "lblRightSubtitle"
        Me.lblRightSubtitle.Size = New System.Drawing.Size(244, 20)
        Me.lblRightSubtitle.TabIndex = 3
        Me.lblRightSubtitle.Text = "COLLEGE OF COMPUTER STUDIES"
        '
        'lblMotto
        '
        Me.lblMotto.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lblMotto.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblMotto.Location = New System.Drawing.Point(50, 445)
        Me.lblMotto.Name = "lblMotto"
        Me.lblMotto.Size = New System.Drawing.Size(400, 45)
        Me.lblMotto.TabIndex = 4
        Me.lblMotto.Text = """Center of Academic Excellence, Technological Leadership, and Community Innovatio" &
    "n."""
        Me.lblMotto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlLeftForm
        '
        Me.pnlLeftForm.BackColor = System.Drawing.Color.White
        Me.pnlLeftForm.Controls.Add(Me.flpRegisterContainer)
        Me.pnlLeftForm.Controls.Add(Me.lblEyeToggle)
        Me.pnlLeftForm.Controls.Add(Me.lblHeaderSub)
        Me.pnlLeftForm.Controls.Add(Me.lblSupportDesk)
        Me.pnlLeftForm.Controls.Add(Me.lblPLPHeader)
        Me.pnlLeftForm.Controls.Add(Me.lblSubtitle)
        Me.pnlLeftForm.Controls.Add(Me.lblLogin)
        Me.pnlLeftForm.Controls.Add(Me.lblSubLogin)
        Me.pnlLeftForm.Controls.Add(Me.lblStudNum)
        Me.pnlLeftForm.Controls.Add(Me.txtUsername)
        Me.pnlLeftForm.Controls.Add(Me.lblPassword)
        Me.pnlLeftForm.Controls.Add(Me.txtPass)
        Me.pnlLeftForm.Controls.Add(Me.btnLogin)
        Me.pnlLeftForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftForm.Name = "pnlLeftForm"
        Me.pnlLeftForm.Size = New System.Drawing.Size(540, 640)
        Me.pnlLeftForm.TabIndex = 0
        '
        'flpRegisterContainer
        '
        Me.flpRegisterContainer.AutoSize = True
        Me.flpRegisterContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpRegisterContainer.Controls.Add(Me.lblRegisterPrompt)
        Me.flpRegisterContainer.Controls.Add(Me.lnkRegister)
        Me.flpRegisterContainer.Location = New System.Drawing.Point(90, 525)
        Me.flpRegisterContainer.Name = "flpRegisterContainer"
        Me.flpRegisterContainer.Size = New System.Drawing.Size(315, 20)
        Me.flpRegisterContainer.TabIndex = 12
        '
        'lblRegisterPrompt
        '
        Me.lblRegisterPrompt.AutoSize = True
        Me.lblRegisterPrompt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRegisterPrompt.ForeColor = System.Drawing.Color.Gray
        Me.lblRegisterPrompt.Location = New System.Drawing.Point(0, 0)
        Me.lblRegisterPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegisterPrompt.Name = "lblRegisterPrompt"
        Me.lblRegisterPrompt.Size = New System.Drawing.Size(167, 20)
        Me.lblRegisterPrompt.TabIndex = 0
        Me.lblRegisterPrompt.Text = "Don't have an account? "
        '
        'lnkRegister
        '
        Me.lnkRegister.AutoSize = True
        Me.lnkRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lnkRegister.Location = New System.Drawing.Point(167, 0)
        Me.lnkRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkRegister.Name = "lnkRegister"
        Me.lnkRegister.Size = New System.Drawing.Size(148, 20)
        Me.lnkRegister.TabIndex = 1
        Me.lnkRegister.TabStop = True
        Me.lnkRegister.Text = "Register As Student"
        '
        'lblEyeToggle
        '
        Me.lblEyeToggle.AutoSize = True
        Me.lblEyeToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEyeToggle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblEyeToggle.Location = New System.Drawing.Point(450, 382)
        Me.lblEyeToggle.Name = "lblEyeToggle"
        Me.lblEyeToggle.Size = New System.Drawing.Size(33, 25)
        Me.lblEyeToggle.TabIndex = 11
        Me.lblEyeToggle.Text = "👁"
        '
        'lblHeaderSub
        '
        Me.lblHeaderSub.AutoSize = True
        Me.lblHeaderSub.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblHeaderSub.Location = New System.Drawing.Point(40, 40)
        Me.lblHeaderSub.Name = "lblHeaderSub"
        Me.lblHeaderSub.Size = New System.Drawing.Size(312, 19)
        Me.lblHeaderSub.TabIndex = 0
        Me.lblHeaderSub.Text = "PAMANTASAN NG LUNGSOD NG PASIG • CCS"
        '
        'lblSupportDesk
        '
        Me.lblSupportDesk.AutoSize = True
        Me.lblSupportDesk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSupportDesk.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSupportDesk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSupportDesk.Location = New System.Drawing.Point(385, 40)
        Me.lblSupportDesk.Name = "lblSupportDesk"
        Me.lblSupportDesk.Size = New System.Drawing.Size(119, 20)
        Me.lblSupportDesk.TabIndex = 1
        Me.lblSupportDesk.Text = "Support Desk ↗"
        '
        'lblPLPHeader
        '
        Me.lblPLPHeader.AutoSize = True
        Me.lblPLPHeader.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblPLPHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblPLPHeader.Location = New System.Drawing.Point(35, 75)
        Me.lblPLPHeader.Name = "lblPLPHeader"
        Me.lblPLPHeader.Size = New System.Drawing.Size(322, 54)
        Me.lblPLPHeader.TabIndex = 2
        Me.lblPLPHeader.Text = "E-PLPORTFOLIO"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(40, 128)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(312, 20)
        Me.lblSubtitle.TabIndex = 3
        Me.lblSubtitle.Text = "STUDENT FACULTY ACADEMIC PORTFOLIO"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblLogin.Location = New System.Drawing.Point(38, 175)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(292, 41)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "Login your Account"
        '
        'lblSubLogin
        '
        Me.lblSubLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubLogin.ForeColor = System.Drawing.Color.Gray
        Me.lblSubLogin.Location = New System.Drawing.Point(40, 220)
        Me.lblSubLogin.Name = "lblSubLogin"
        Me.lblSubLogin.Size = New System.Drawing.Size(440, 40)
        Me.lblSubLogin.TabIndex = 5
        Me.lblSubLogin.Text = "Welcome Back! Please enter your academic credentials to sign in."
        '
        'lblStudNum
        '
        Me.lblStudNum.AutoSize = True
        Me.lblStudNum.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblStudNum.Location = New System.Drawing.Point(40, 275)
        Me.lblStudNum.Name = "lblStudNum"
        Me.lblStudNum.Size = New System.Drawing.Size(218, 19)
        Me.lblStudNum.TabIndex = 6
        Me.lblStudNum.Text = "STUDENT NUMBER / PLP EMAIL"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.txtUsername.Location = New System.Drawing.Point(40, 298)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(400, 33)
        Me.txtUsername.TabIndex = 7
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(40, 355)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 19)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "PASSWORD"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.txtPass.Location = New System.Drawing.Point(40, 378)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(400, 33)
        Me.txtPass.TabIndex = 9
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(40, 445)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(440, 46)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "LOGIN  →"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.pnlCenterCard)
        Me.Controls.Add(Me.pnlBottomFooter)
        Me.Controls.Add(Me.pnlTopNav)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-PLPORTFOLIO - Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTopNav.ResumeLayout(False)
        Me.pnlTopNav.PerformLayout()
        Me.pnlCenterCard.ResumeLayout(False)
        Me.pnlRightSide.ResumeLayout(False)
        Me.pnlRightSide.PerformLayout()
        CType(Me.picCenterLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeftForm.ResumeLayout(False)
        Me.pnlLeftForm.PerformLayout()
        Me.flpRegisterContainer.ResumeLayout(False)
        Me.flpRegisterContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopNav As System.Windows.Forms.Panel
    Friend WithEvents lblTopLeftNav As System.Windows.Forms.Label
    Friend WithEvents lblServerStatus As System.Windows.Forms.Label
    Friend WithEvents pnlBottomFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlCenterCard As System.Windows.Forms.Panel
    Friend WithEvents pnlLeftForm As System.Windows.Forms.Panel
    Friend WithEvents pnlRightSide As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderSub As System.Windows.Forms.Label
    Friend WithEvents lblSupportDesk As System.Windows.Forms.Label
    Friend WithEvents lblPLPHeader As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblSubLogin As System.Windows.Forms.Label
    Friend WithEvents lblStudNum As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblEyeToggle As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents flpRegisterContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblRegisterPrompt As System.Windows.Forms.Label
    Friend WithEvents lnkRegister As System.Windows.Forms.LinkLabel
    Friend WithEvents lblBadgePill As System.Windows.Forms.Label
    Friend WithEvents picCenterLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblRightTitle As System.Windows.Forms.Label
    Friend WithEvents lblRightSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblMotto As System.Windows.Forms.Label

End Class