<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbSuffix = New System.Windows.Forms.ComboBox()
        Me.lblYrLevel = New System.Windows.Forms.Label()
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox()
        Me.lblCollege = New System.Windows.Forms.Label()
        Me.cmbCollege = New System.Windows.Forms.ComboBox()
        Me.pnlPrograms = New System.Windows.Forms.Panel()
        Me.lblPrograms = New System.Windows.Forms.Label()
        Me.rdoProg4 = New System.Windows.Forms.RadioButton()
        Me.rdoProg3 = New System.Windows.Forms.RadioButton()
        Me.rdoProg2 = New System.Windows.Forms.RadioButton()
        Me.rdoProg1 = New System.Windows.Forms.RadioButton()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.chckShowPass = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlRegisterCard = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlPrograms.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRegisterCard.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 381)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 23)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "SUFFIX"
        '
        'cmbSuffix
        '
        Me.cmbSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSuffix.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuffix.FormattingEnabled = True
        Me.cmbSuffix.Items.AddRange(New Object() {"(None)", "Jr.", "Sr.", "II.", "III.", "IV.", "V."})
        Me.cmbSuffix.Location = New System.Drawing.Point(62, 408)
        Me.cmbSuffix.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSuffix.Name = "cmbSuffix"
        Me.cmbSuffix.Size = New System.Drawing.Size(353, 33)
        Me.cmbSuffix.TabIndex = 15
        '
        'lblYrLevel
        '
        Me.lblYrLevel.AutoSize = True
        Me.lblYrLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblYrLevel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYrLevel.Location = New System.Drawing.Point(482, 237)
        Me.lblYrLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYrLevel.Name = "lblYrLevel"
        Me.lblYrLevel.Size = New System.Drawing.Size(104, 23)
        Me.lblYrLevel.TabIndex = 16
        Me.lblYrLevel.Text = "YEAR LEVEL"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(483, 263)
        Me.cmbYearLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(539, 33)
        Me.cmbYearLevel.TabIndex = 17
        '
        'lblCollege
        '
        Me.lblCollege.AutoSize = True
        Me.lblCollege.BackColor = System.Drawing.Color.Transparent
        Me.lblCollege.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollege.Location = New System.Drawing.Point(482, 313)
        Me.lblCollege.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCollege.Name = "lblCollege"
        Me.lblCollege.Size = New System.Drawing.Size(82, 23)
        Me.lblCollege.TabIndex = 18
        Me.lblCollege.Text = "COLLEGE"
        '
        'cmbCollege
        '
        Me.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCollege.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCollege.FormattingEnabled = True
        Me.cmbCollege.Items.AddRange(New Object() {"CAS", "CBA", "CCS", "COED", "COE", "CIHM", "CON"})
        Me.cmbCollege.Location = New System.Drawing.Point(483, 338)
        Me.cmbCollege.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCollege.Name = "cmbCollege"
        Me.cmbCollege.Size = New System.Drawing.Size(539, 33)
        Me.cmbCollege.TabIndex = 19
        '
        'pnlPrograms
        '
        Me.pnlPrograms.BackColor = System.Drawing.Color.Transparent
        Me.pnlPrograms.Controls.Add(Me.lblPrograms)
        Me.pnlPrograms.Controls.Add(Me.rdoProg4)
        Me.pnlPrograms.Controls.Add(Me.rdoProg3)
        Me.pnlPrograms.Controls.Add(Me.rdoProg2)
        Me.pnlPrograms.Controls.Add(Me.rdoProg1)
        Me.pnlPrograms.Enabled = False
        Me.pnlPrograms.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPrograms.Location = New System.Drawing.Point(477, 381)
        Me.pnlPrograms.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlPrograms.Name = "pnlPrograms"
        Me.pnlPrograms.Size = New System.Drawing.Size(545, 223)
        Me.pnlPrograms.TabIndex = 20
        Me.pnlPrograms.Visible = False
        '
        'lblPrograms
        '
        Me.lblPrograms.AutoSize = True
        Me.lblPrograms.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrograms.Location = New System.Drawing.Point(4, 9)
        Me.lblPrograms.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrograms.Name = "lblPrograms"
        Me.lblPrograms.Size = New System.Drawing.Size(99, 25)
        Me.lblPrograms.TabIndex = 21
        Me.lblPrograms.Text = "Programs"
        '
        'rdoProg4
        '
        Me.rdoProg4.AutoSize = True
        Me.rdoProg4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoProg4.Location = New System.Drawing.Point(9, 172)
        Me.rdoProg4.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoProg4.Name = "rdoProg4"
        Me.rdoProg4.Size = New System.Drawing.Size(135, 27)
        Me.rdoProg4.TabIndex = 3
        Me.rdoProg4.TabStop = True
        Me.rdoProg4.Text = "RadioButton4"
        Me.rdoProg4.UseVisualStyleBackColor = True
        '
        'rdoProg3
        '
        Me.rdoProg3.AutoSize = True
        Me.rdoProg3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoProg3.Location = New System.Drawing.Point(9, 130)
        Me.rdoProg3.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoProg3.Name = "rdoProg3"
        Me.rdoProg3.Size = New System.Drawing.Size(135, 27)
        Me.rdoProg3.TabIndex = 2
        Me.rdoProg3.TabStop = True
        Me.rdoProg3.Text = "RadioButton3"
        Me.rdoProg3.UseVisualStyleBackColor = True
        '
        'rdoProg2
        '
        Me.rdoProg2.AutoSize = True
        Me.rdoProg2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoProg2.Location = New System.Drawing.Point(9, 85)
        Me.rdoProg2.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoProg2.Name = "rdoProg2"
        Me.rdoProg2.Size = New System.Drawing.Size(135, 27)
        Me.rdoProg2.TabIndex = 1
        Me.rdoProg2.TabStop = True
        Me.rdoProg2.Text = "RadioButton2"
        Me.rdoProg2.UseVisualStyleBackColor = True
        '
        'rdoProg1
        '
        Me.rdoProg1.AutoSize = True
        Me.rdoProg1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoProg1.Location = New System.Drawing.Point(9, 41)
        Me.rdoProg1.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoProg1.Name = "rdoProg1"
        Me.rdoProg1.Size = New System.Drawing.Size(135, 27)
        Me.rdoProg1.TabIndex = 0
        Me.rdoProg1.TabStop = True
        Me.rdoProg1.Text = "RadioButton1"
        Me.rdoProg1.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(61, 481)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(246, 32)
        Me.txtPassword.TabIndex = 22
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(61, 559)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(246, 32)
        Me.txtConfirmPass.TabIndex = 24
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'chckShowPass
        '
        Me.chckShowPass.AutoSize = True
        Me.chckShowPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckShowPass.Location = New System.Drawing.Point(343, 563)
        Me.chckShowPass.Margin = New System.Windows.Forms.Padding(4)
        Me.chckShowPass.Name = "chckShowPass"
        Me.chckShowPass.Size = New System.Drawing.Size(56, 27)
        Me.chckShowPass.TabIndex = 25
        Me.chckShowPass.Text = "👁"
        Me.chckShowPass.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel1.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SeaGreen
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(352, 698)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(357, 244)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "PLPORTFOLIO empowers Pasigueño scholars to catalog capstone works, verify curricu" &
    "lar competencies, and showcase achievements to institutional partners."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SeaGreen
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(352, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(357, 203)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Build your verified digital academic footprint."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SeaGreen
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(352, 169)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(357, 737)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'pnlRegisterCard
        '
        Me.pnlRegisterCard.BackColor = System.Drawing.Color.White
        Me.pnlRegisterCard.Controls.Add(Me.PictureBox3)
        Me.pnlRegisterCard.Controls.Add(Me.PictureBox2)
        Me.pnlRegisterCard.Controls.Add(Me.Label11)
        Me.pnlRegisterCard.Controls.Add(Me.chckShowPass)
        Me.pnlRegisterCard.Controls.Add(Me.btnRegister)
        Me.pnlRegisterCard.Controls.Add(Me.cmbSuffix)
        Me.pnlRegisterCard.Controls.Add(Me.txtConfirmPass)
        Me.pnlRegisterCard.Controls.Add(Me.Label9)
        Me.pnlRegisterCard.Controls.Add(Me.Label1)
        Me.pnlRegisterCard.Controls.Add(Me.pnlPrograms)
        Me.pnlRegisterCard.Controls.Add(Me.Label8)
        Me.pnlRegisterCard.Controls.Add(Me.cmbCollege)
        Me.pnlRegisterCard.Controls.Add(Me.lblCollege)
        Me.pnlRegisterCard.Controls.Add(Me.txtPassword)
        Me.pnlRegisterCard.Controls.Add(Me.Label7)
        Me.pnlRegisterCard.Controls.Add(Me.Label5)
        Me.pnlRegisterCard.Controls.Add(Me.Label4)
        Me.pnlRegisterCard.Controls.Add(Me.Label3)
        Me.pnlRegisterCard.Controls.Add(Me.Label2)
        Me.pnlRegisterCard.Controls.Add(Me.cmbYearLevel)
        Me.pnlRegisterCard.Controls.Add(Me.lblYrLevel)
        Me.pnlRegisterCard.Controls.Add(Me.Label14)
        Me.pnlRegisterCard.Controls.Add(Me.TextBox2)
        Me.pnlRegisterCard.Controls.Add(Me.TextBox3)
        Me.pnlRegisterCard.Controls.Add(Me.TextBox4)
        Me.pnlRegisterCard.Controls.Add(Me.txtStudentNum)
        Me.pnlRegisterCard.ForeColor = System.Drawing.Color.DarkGreen
        Me.pnlRegisterCard.Location = New System.Drawing.Point(706, 169)
        Me.pnlRegisterCard.Name = "pnlRegisterCard"
        Me.pnlRegisterCard.Size = New System.Drawing.Size(1051, 773)
        Me.pnlRegisterCard.TabIndex = 30
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(841, 193)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(408, 193)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(365, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "e.g., 25-00123"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.SeaGreen
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(119, 686)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(845, 51)
        Me.btnRegister.TabIndex = 18
        Me.btnRegister.Text = "Register Account"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "CONFIRM PASSWORD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 454)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "PASSWORD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(479, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "EMAIL ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(58, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "LAST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(58, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "FIRST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(58, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "STUDENT NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(71, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(620, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sign up to start building your academic e-portfolio with your student profile."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label14.Location = New System.Drawing.Point(63, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(406, 54)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Create Your Account"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(482, 187)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(406, 34)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(62, 338)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(393, 34)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(61, 263)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(395, 34)
        Me.TextBox4.TabIndex = 1
        '
        'txtStudentNum
        '
        Me.txtStudentNum.BackColor = System.Drawing.Color.White
        Me.txtStudentNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentNum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNum.Location = New System.Drawing.Point(61, 187)
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.Size = New System.Drawing.Size(394, 34)
        Me.txtStudentNum.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Location = New System.Drawing.Point(0, -14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2120, 127)
        Me.Panel1.TabIndex = 31
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlRegisterCard)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlPrograms.ResumeLayout(False)
        Me.pnlPrograms.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRegisterCard.ResumeLayout(False)
        Me.pnlRegisterCard.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSuffix As ComboBox
    Friend WithEvents lblYrLevel As Label
    Friend WithEvents cmbYearLevel As ComboBox
    Friend WithEvents lblCollege As Label
    Friend WithEvents cmbCollege As ComboBox
    Friend WithEvents pnlPrograms As Panel
    Friend WithEvents rdoProg4 As RadioButton
    Friend WithEvents rdoProg3 As RadioButton
    Friend WithEvents rdoProg2 As RadioButton
    Friend WithEvents rdoProg1 As RadioButton
    Friend WithEvents lblPrograms As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents chckShowPass As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlRegisterCard As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtStudentNum As TextBox
    Friend WithEvents Panel1 As Panel
End Class
