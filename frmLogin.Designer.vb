<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbLoginBG = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblStudNum = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblSubLogin = New System.Windows.Forms.Label()
        Me.chckShowPass = New System.Windows.Forms.CheckBox()
        Me.lblPLPHeader = New System.Windows.Forms.Label()
        Me.lnkRegister = New System.Windows.Forms.LinkLabel()
        CType(Me.pbLoginBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLoginBG
        '
        Me.pbLoginBG.BackgroundImage = Global.e_plp.My.Resources.Resources.Pamantasan_ng_Lungsod_ng_Pasig__3_
        Me.pbLoginBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoginBG.Image = Global.e_plp.My.Resources.Resources.Pamantasan_ng_Lungsod_ng_Pasig__3_
        Me.pbLoginBG.Location = New System.Drawing.Point(338, 148)
        Me.pbLoginBG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbLoginBG.Name = "pbLoginBG"
        Me.pbLoginBG.Size = New System.Drawing.Size(1037, 557)
        Me.pbLoginBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoginBG.TabIndex = 1
        Me.pbLoginBG.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(387, 409)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(306, 34)
        Me.txtUsername.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(387, 526)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(306, 34)
        Me.txtPass.TabIndex = 3
        '
        'lblStudNum
        '
        Me.lblStudNum.AutoSize = True
        Me.lblStudNum.BackColor = System.Drawing.Color.White
        Me.lblStudNum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudNum.Location = New System.Drawing.Point(382, 370)
        Me.lblStudNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudNum.Name = "lblStudNum"
        Me.lblStudNum.Size = New System.Drawing.Size(267, 23)
        Me.lblStudNum.TabIndex = 6
        Me.lblStudNum.Text = "STUDENT NUMBER / PLP EMAIL"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.White
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(381, 486)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(97, 25)
        Me.lblPassword.TabIndex = 22
        Me.lblPassword.Text = "Password"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.White
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(351, 242)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(267, 37)
        Me.lblLogin.TabIndex = 23
        Me.lblLogin.Text = "Login your Account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(533, 50)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "picture for login is temporary, testing lng (not the final design)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*Remove this " &
    "label" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(409, 620)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(372, 33)
        Me.btnLogin.TabIndex = 25
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblSubLogin
        '
        Me.lblSubLogin.AutoSize = True
        Me.lblSubLogin.BackColor = System.Drawing.Color.White
        Me.lblSubLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubLogin.Location = New System.Drawing.Point(367, 287)
        Me.lblSubLogin.Name = "lblSubLogin"
        Me.lblSubLogin.Size = New System.Drawing.Size(247, 40)
        Me.lblSubLogin.TabIndex = 26
        Me.lblSubLogin.Text = "Welcome Back!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please enter your details to sign in."
        '
        'chckShowPass
        '
        Me.chckShowPass.AutoSize = True
        Me.chckShowPass.BackColor = System.Drawing.Color.White
        Me.chckShowPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckShowPass.Location = New System.Drawing.Point(699, 530)
        Me.chckShowPass.Margin = New System.Windows.Forms.Padding(4)
        Me.chckShowPass.Name = "chckShowPass"
        Me.chckShowPass.Size = New System.Drawing.Size(56, 27)
        Me.chckShowPass.TabIndex = 27
        Me.chckShowPass.Text = "👁"
        Me.chckShowPass.UseVisualStyleBackColor = False
        '
        'lblPLPHeader
        '
        Me.lblPLPHeader.AutoSize = True
        Me.lblPLPHeader.BackColor = System.Drawing.Color.White
        Me.lblPLPHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLPHeader.Location = New System.Drawing.Point(352, 158)
        Me.lblPLPHeader.Name = "lblPLPHeader"
        Me.lblPLPHeader.Size = New System.Drawing.Size(465, 32)
        Me.lblPLPHeader.TabIndex = 28
        Me.lblPLPHeader.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
        '
        'lnkRegister
        '
        Me.lnkRegister.AutoSize = True
        Me.lnkRegister.Location = New System.Drawing.Point(636, 735)
        Me.lnkRegister.Name = "lnkRegister"
        Me.lnkRegister.Size = New System.Drawing.Size(125, 16)
        Me.lnkRegister.TabIndex = 29
        Me.lnkRegister.TabStop = True
        Me.lnkRegister.Text = "Register As Student"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1710, 840)
        Me.Controls.Add(Me.lnkRegister)
        Me.Controls.Add(Me.lblPLPHeader)
        Me.Controls.Add(Me.chckShowPass)
        Me.Controls.Add(Me.lblSubLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblStudNum)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.pbLoginBG)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbLoginBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLoginBG As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblStudNum As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblSubLogin As Label
    Friend WithEvents chckShowPass As CheckBox
    Friend WithEvents lblPLPHeader As Label
    Friend WithEvents lnkRegister As LinkLabel
End Class
