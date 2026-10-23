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
        Me.pnlCenterCard = New System.Windows.Forms.Panel()
        Me.lnkRegister = New System.Windows.Forms.LinkLabel()
        Me.lblPLPHeader = New System.Windows.Forms.Label()
        Me.chckShowPass = New System.Windows.Forms.CheckBox()
        Me.lblSubLogin = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblStudNum = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.pbLoginBG = New System.Windows.Forms.PictureBox()
        Me.pnlCenterCard.SuspendLayout()
        CType(Me.pbLoginBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCenterCard
        '
        Me.pnlCenterCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCenterCard.BackColor = System.Drawing.Color.Transparent
        Me.pnlCenterCard.Controls.Add(Me.lnkRegister)
        Me.pnlCenterCard.Controls.Add(Me.lblPLPHeader)
        Me.pnlCenterCard.Controls.Add(Me.chckShowPass)
        Me.pnlCenterCard.Controls.Add(Me.lblSubLogin)
        Me.pnlCenterCard.Controls.Add(Me.btnLogin)
        Me.pnlCenterCard.Controls.Add(Me.lblLogin)
        Me.pnlCenterCard.Controls.Add(Me.lblPassword)
        Me.pnlCenterCard.Controls.Add(Me.lblStudNum)
        Me.pnlCenterCard.Controls.Add(Me.txtPass)
        Me.pnlCenterCard.Controls.Add(Me.txtUsername)
        Me.pnlCenterCard.Controls.Add(Me.pbLoginBG)
        Me.pnlCenterCard.Location = New System.Drawing.Point(355, 90)
        Me.pnlCenterCard.Name = "pnlCenterCard"
        Me.pnlCenterCard.Size = New System.Drawing.Size(1000, 660)
        Me.pnlCenterCard.TabIndex = 0
        '
        'lnkRegister
        '
        Me.lnkRegister.AutoSize = True
        Me.lnkRegister.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lnkRegister.LinkColor = System.Drawing.Color.White
        Me.lnkRegister.Location = New System.Drawing.Point(386, 618)
        Me.lnkRegister.Name = "lnkRegister"
        Me.lnkRegister.Size = New System.Drawing.Size(145, 21)
        Me.lnkRegister.TabIndex = 29
        Me.lnkRegister.TabStop = True
        Me.lnkRegister.Text = "Register As Student"
        '
        'lblPLPHeader
        '
        Me.lblPLPHeader.AutoSize = True
        Me.lblPLPHeader.BackColor = System.Drawing.Color.White
        Me.lblPLPHeader.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLPHeader.Location = New System.Drawing.Point(36, 22)
        Me.lblPLPHeader.Name = "lblPLPHeader"
        Me.lblPLPHeader.Size = New System.Drawing.Size(276, 46)
        Me.lblPLPHeader.TabIndex = 28
        Me.lblPLPHeader.Text = "E-PLPORTFOLIO"
        '
        'chckShowPass
        '
        Me.chckShowPass.AutoSize = True
        Me.chckShowPass.BackColor = System.Drawing.Color.White
        Me.chckShowPass.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.chckShowPass.Location = New System.Drawing.Point(375, 385)
        Me.chckShowPass.Name = "chckShowPass"
        Me.chckShowPass.Size = New System.Drawing.Size(55, 25)
        Me.chckShowPass.TabIndex = 27
        Me.chckShowPass.Text = "👁"
        Me.chckShowPass.UseVisualStyleBackColor = False
        '
        'lblSubLogin
        '
        Me.lblSubLogin.AutoSize = True
        Me.lblSubLogin.BackColor = System.Drawing.Color.White
        Me.lblSubLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblSubLogin.Location = New System.Drawing.Point(44, 155)
        Me.lblSubLogin.Name = "lblSubLogin"
        Me.lblSubLogin.Size = New System.Drawing.Size(247, 40)
        Me.lblSubLogin.TabIndex = 26
        Me.lblSubLogin.Text = "Welcome Back!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please enter your details to sign in."
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.Location = New System.Drawing.Point(65, 470)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(372, 38)
        Me.btnLogin.TabIndex = 25
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.White
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.Location = New System.Drawing.Point(38, 94)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(287, 40)
        Me.lblLogin.TabIndex = 23
        Me.lblLogin.Text = "Login your Account"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.White
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(40, 350)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(92, 25)
        Me.lblPassword.TabIndex = 22
        Me.lblPassword.Text = "Password"
        '
        'lblStudNum
        '
        Me.lblStudNum.AutoSize = True
        Me.lblStudNum.BackColor = System.Drawing.Color.White
        Me.lblStudNum.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudNum.Location = New System.Drawing.Point(40, 248)
        Me.lblStudNum.Name = "lblStudNum"
        Me.lblStudNum.Size = New System.Drawing.Size(251, 21)
        Me.lblStudNum.TabIndex = 6
        Me.lblStudNum.Text = "STUDENT NUMBER / PLP EMAIL"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.txtPass.Location = New System.Drawing.Point(45, 380)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(320, 33)
        Me.txtPass.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.txtUsername.Location = New System.Drawing.Point(45, 275)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(320, 33)
        Me.txtUsername.TabIndex = 2
        '
        'pbLoginBG
        '
        Me.pbLoginBG.BackgroundImage = Global.e_plp.My.Resources.Resources.Pamantasan_ng_Lungsod_ng_Pasig__3_
        Me.pbLoginBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoginBG.Image = Global.e_plp.My.Resources.Resources.Pamantasan_ng_Lungsod_ng_Pasig__3_
        Me.pbLoginBG.Location = New System.Drawing.Point(0, 0)
        Me.pbLoginBG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbLoginBG.Name = "pbLoginBG"
        Me.pbLoginBG.Size = New System.Drawing.Size(1000, 600)
        Me.pbLoginBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoginBG.TabIndex = 1
        Me.pbLoginBG.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1710, 840)
        Me.Controls.Add(Me.pnlCenterCard)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlCenterCard.ResumeLayout(False)
        Me.pnlCenterCard.PerformLayout()
        CType(Me.pbLoginBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCenterCard As System.Windows.Forms.Panel
    Friend WithEvents pbLoginBG As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblStudNum As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblSubLogin As Label
    Friend WithEvents chckShowPass As CheckBox
    Friend WithEvents lblPLPHeader As Label
    Friend WithEvents lnkRegister As LinkLabel
End Class