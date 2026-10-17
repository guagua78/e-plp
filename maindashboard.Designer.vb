<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class maindashboard
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
        Me.lblHeaderStudentInfo = New System.Windows.Forms.Label()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.grpStudentProfile = New System.Windows.Forms.GroupBox()
        Me.lblProgramVal = New System.Windows.Forms.Label()
        Me.lblCollegeVal = New System.Windows.Forms.Label()
        Me.lblEmailVal = New System.Windows.Forms.Label()
        Me.lblStudentNumVal = New System.Windows.Forms.Label()
        Me.lblNameVal = New System.Windows.Forms.Label()
        Me.pnlStatTotal = New System.Windows.Forms.Panel()
        Me.lblTotalVal = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.pnlStatCategories = New System.Windows.Forms.Panel()
        Me.lblCategoriesVal = New System.Windows.Forms.Label()
        Me.lblCategoriesTitle = New System.Windows.Forms.Label()
        Me.lblProgressTitle = New System.Windows.Forms.Label()
        Me.dgvProgressSummary = New System.Windows.Forms.DataGridView()
        Me.lblArtifactsTitle = New System.Windows.Forms.Label()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.dgvPortfolio = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.grpStudentProfile.SuspendLayout()
        Me.pnlStatTotal.SuspendLayout()
        Me.pnlStatCategories.SuspendLayout()
        CType(Me.dgvProgressSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(100, Byte), CType(0, Byte))
        Me.pnlHeader.Controls.Add(Me.lblHeaderStudentInfo)
        Me.pnlHeader.Controls.Add(Me.lblAppTitle)
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 65)
        Me.pnlHeader.TabIndex = 0
        '
        ' lblHeaderStudentInfo
        '
        Me.lblHeaderStudentInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeaderStudentInfo.AutoSize = True
        Me.lblHeaderStudentInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderStudentInfo.ForeColor = System.Drawing.Color.White
        Me.lblHeaderStudentInfo.Location = New System.Drawing.Point(820, 22)
        Me.lblHeaderStudentInfo.Name = "lblHeaderStudentInfo"
        Me.lblHeaderStudentInfo.Size = New System.Drawing.Size(220, 23)
        Me.lblHeaderStudentInfo.TabIndex = 2
        Me.lblHeaderStudentInfo.Text = "Student Profile Loading..."
        '
        ' lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppTitle.ForeColor = System.Drawing.Color.White
        Me.lblAppTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(288, 35)
        Me.lblAppTitle.TabIndex = 0
        Me.lblAppTitle.Text = "Portfolioboxd | e-PLP"
        '
        ' btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.Firebrick
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1075, 16)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 35)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        ' pnlMainContent
        '
        Me.pnlMainContent.Controls.Add(Me.grpStudentProfile)
        Me.pnlMainContent.Controls.Add(Me.pnlStatTotal)
        Me.pnlMainContent.Controls.Add(Me.pnlStatCategories)
        Me.pnlMainContent.Controls.Add(Me.lblProgressTitle)
        Me.pnlMainContent.Controls.Add(Me.dgvProgressSummary)
        Me.pnlMainContent.Controls.Add(Me.lblArtifactsTitle)
        Me.pnlMainContent.Controls.Add(Me.btnAddEntry)
        Me.pnlMainContent.Controls.Add(Me.dgvPortfolio)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(0, 65)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMainContent.Size = New System.Drawing.Size(1200, 655)
        Me.pnlMainContent.TabIndex = 1
        '
        ' grpStudentProfile
        '
        Me.grpStudentProfile.Controls.Add(Me.lblProgramVal)
        Me.grpStudentProfile.Controls.Add(Me.lblCollegeVal)
        Me.grpStudentProfile.Controls.Add(Me.lblEmailVal)
        Me.grpStudentProfile.Controls.Add(Me.lblStudentNumVal)
        Me.grpStudentProfile.Controls.Add(Me.lblNameVal)
        Me.grpStudentProfile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpStudentProfile.Location = New System.Drawing.Point(23, 15)
        Me.grpStudentProfile.Name = "grpStudentProfile"
        Me.grpStudentProfile.Size = New System.Drawing.Size(1152, 110)
        Me.grpStudentProfile.TabIndex = 0
        Me.grpStudentProfile.TabStop = False
        Me.grpStudentProfile.Text = "STUDENT PROFILE OVERVIEW"
        '
        ' lblNameVal
        '
        Me.lblNameVal.AutoSize = True
        Me.lblNameVal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNameVal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblNameVal.Location = New System.Drawing.Point(18, 30)
        Me.lblNameVal.Name = "lblNameVal"
        Me.lblNameVal.Size = New System.Drawing.Size(185, 28)
        Me.lblNameVal.TabIndex = 0
        Me.lblNameVal.Text = "Loading Student..."
        '
        ' lblStudentNumVal
        '
        Me.lblStudentNumVal.AutoSize = True
        Me.lblStudentNumVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblStudentNumVal.Location = New System.Drawing.Point(20, 68)
        Me.lblStudentNumVal.Name = "lblStudentNumVal"
        Me.lblStudentNumVal.Size = New System.Drawing.Size(125, 21)
        Me.lblStudentNumVal.TabIndex = 1
        Me.lblStudentNumVal.Text = "Student No: -----"
        '
        ' lblEmailVal
        '
        Me.lblEmailVal.AutoSize = True
        Me.lblEmailVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblEmailVal.Location = New System.Drawing.Point(260, 68)
        Me.lblEmailVal.Name = "lblEmailVal"
        Me.lblEmailVal.Size = New System.Drawing.Size(108, 21)
        Me.lblEmailVal.TabIndex = 2
        Me.lblEmailVal.Text = "Webmail: -----"
        '
        ' lblCollegeVal
        '
        Me.lblCollegeVal.AutoSize = True
        Me.lblCollegeVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblCollegeVal.Location = New System.Drawing.Point(620, 35)
        Me.lblCollegeVal.Name = "lblCollegeVal"
        Me.lblCollegeVal.Size = New System.Drawing.Size(250, 21)
        Me.lblCollegeVal.TabIndex = 3
        Me.lblCollegeVal.Text = "College: College of Computer Studies"
        '
        ' lblProgramVal
        '
        Me.lblProgramVal.AutoSize = True
        Me.lblProgramVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblProgramVal.Location = New System.Drawing.Point(620, 68)
        Me.lblProgramVal.Name = "lblProgramVal"
        Me.lblProgramVal.Size = New System.Drawing.Size(111, 21)
        Me.lblProgramVal.TabIndex = 4
        Me.lblProgramVal.Text = "Program: -----"
        '
        ' pnlStatTotal
        '
        Me.pnlStatTotal.BackColor = System.Drawing.Color.SeaShell
        Me.pnlStatTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatTotal.Controls.Add(Me.lblTotalVal)
        Me.pnlStatTotal.Controls.Add(Me.lblTotalTitle)
        Me.pnlStatTotal.Location = New System.Drawing.Point(23, 138)
        Me.pnlStatTotal.Name = "pnlStatTotal"
        Me.pnlStatTotal.Size = New System.Drawing.Size(560, 80)
        Me.pnlStatTotal.TabIndex = 1
        '
        ' lblTotalTitle
        '
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(201, 20)
        Me.lblTotalTitle.TabIndex = 0
        Me.lblTotalTitle.Text = "TOTAL PORTFOLIO RECORDS"
        '
        ' lblTotalVal
        '
        Me.lblTotalVal.AutoSize = True
        Me.lblTotalVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalVal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTotalVal.Location = New System.Drawing.Point(12, 30)
        Me.lblTotalVal.Name = "lblTotalVal"
        Me.lblTotalVal.Size = New System.Drawing.Size(39, 46)
        Me.lblTotalVal.TabIndex = 1
        Me.lblTotalVal.Text = "0"
        '
        ' pnlStatCategories
        '
        Me.pnlStatCategories.BackColor = System.Drawing.Color.Honeydew
        Me.pnlStatCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatCategories.Controls.Add(Me.lblCategoriesVal)
        Me.pnlStatCategories.Controls.Add(Me.lblCategoriesTitle)
        Me.pnlStatCategories.Location = New System.Drawing.Point(615, 138)
        Me.pnlStatCategories.Name = "pnlStatCategories"
        Me.pnlStatCategories.Size = New System.Drawing.Size(560, 80)
        Me.pnlStatCategories.TabIndex = 2
        '
        ' lblCategoriesTitle
        '
        Me.lblCategoriesTitle.AutoSize = True
        Me.lblCategoriesTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategoriesTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblCategoriesTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblCategoriesTitle.Name = "lblCategoriesTitle"
        Me.lblCategoriesTitle.Size = New System.Drawing.Size(228, 20)
        Me.lblCategoriesTitle.TabIndex = 0
        Me.lblCategoriesTitle.Text = "SKILL COMPETENCIES COVERED"
        '
        ' lblCategoriesVal
        '
        Me.lblCategoriesVal.AutoSize = True
        Me.lblCategoriesVal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategoriesVal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblCategoriesVal.Location = New System.Drawing.Point(12, 30)
        Me.lblCategoriesVal.Name = "lblCategoriesVal"
        Me.lblCategoriesVal.Size = New System.Drawing.Size(95, 46)
        Me.lblCategoriesVal.TabIndex = 1
        Me.lblCategoriesVal.Text = "0 / 7"
        '
        ' lblProgressTitle
        '
        Me.lblProgressTitle.AutoSize = True
        Me.lblProgressTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblProgressTitle.Location = New System.Drawing.Point(23, 235)
        Me.lblProgressTitle.Name = "lblProgressTitle"
        Me.lblProgressTitle.Size = New System.Drawing.Size(298, 25)
        Me.lblProgressTitle.TabIndex = 3
        Me.lblProgressTitle.Text = "Competency Progress Summary"
        '
        ' dgvProgressSummary
        '
        Me.dgvProgressSummary.AllowUserToAddRows = False
        Me.dgvProgressSummary.AllowUserToDeleteRows = False
        Me.dgvProgressSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProgressSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgressSummary.Location = New System.Drawing.Point(23, 270)
        Me.dgvProgressSummary.Name = "dgvProgressSummary"
        Me.dgvProgressSummary.ReadOnly = True
        Me.dgvProgressSummary.RowHeadersWidth = 51
        Me.dgvProgressSummary.RowTemplate.Height = 28
        Me.dgvProgressSummary.Size = New System.Drawing.Size(420, 360)
        Me.dgvProgressSummary.TabIndex = 4
        '
        ' lblArtifactsTitle
        '
        Me.lblArtifactsTitle.AutoSize = True
        Me.lblArtifactsTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblArtifactsTitle.Location = New System.Drawing.Point(465, 235)
        Me.lblArtifactsTitle.Name = "lblArtifactsTitle"
        Me.lblArtifactsTitle.Size = New System.Drawing.Size(228, 25)
        Me.lblArtifactsTitle.TabIndex = 5
        Me.lblArtifactsTitle.Text = "Recent Portfolio Artifacts"
        '
        ' btnAddEntry
        '
        Me.btnAddEntry.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEntry.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAddEntry.ForeColor = System.Drawing.Color.White
        Me.btnAddEntry.Location = New System.Drawing.Point(1020, 227)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(155, 36)
        Me.btnAddEntry.TabIndex = 6
        Me.btnAddEntry.Text = "+ Add New Entry"
        Me.btnAddEntry.UseVisualStyleBackColor = False
        '
        ' dgvPortfolio
        '
        Me.dgvPortfolio.AllowUserToAddRows = False
        Me.dgvPortfolio.AllowUserToDeleteRows = False
        Me.dgvPortfolio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPortfolio.Location = New System.Drawing.Point(465, 270)
        Me.dgvPortfolio.Name = "dgvPortfolio"
        Me.dgvPortfolio.ReadOnly = True
        Me.dgvPortfolio.RowHeadersWidth = 51
        Me.dgvPortfolio.RowTemplate.Height = 28
        Me.dgvPortfolio.Size = New System.Drawing.Size(710, 360)
        Me.dgvPortfolio.TabIndex = 7
        '
        ' frmStudentDashboard
        '
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "frmStudentDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Dashboard - Portfolioboxd (e-PLP)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlMainContent.PerformLayout()
        Me.grpStudentProfile.ResumeLayout(False)
        Me.grpStudentProfile.PerformLayout()
        Me.pnlStatTotal.ResumeLayout(False)
        Me.pnlStatTotal.PerformLayout()
        Me.pnlStatCategories.ResumeLayout(False)
        Me.pnlStatCategories.PerformLayout()
        CType(Me.dgvProgressSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblAppTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderStudentInfo As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlMainContent As System.Windows.Forms.Panel
    Friend WithEvents grpStudentProfile As System.Windows.Forms.GroupBox
    Friend WithEvents lblNameVal As System.Windows.Forms.Label
    Friend WithEvents lblStudentNumVal As System.Windows.Forms.Label
    Friend WithEvents lblEmailVal As System.Windows.Forms.Label
    Friend WithEvents lblCollegeVal As System.Windows.Forms.Label
    Friend WithEvents lblProgramVal As System.Windows.Forms.Label
    Friend WithEvents pnlStatTotal As System.Windows.Forms.Panel
    Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalVal As System.Windows.Forms.Label
    Friend WithEvents pnlStatCategories As System.Windows.Forms.Panel
    Friend WithEvents lblCategoriesTitle As System.Windows.Forms.Label
    Friend WithEvents lblCategoriesVal As System.Windows.Forms.Label
    Friend WithEvents lblProgressTitle As System.Windows.Forms.Label
    Friend WithEvents dgvProgressSummary As System.Windows.Forms.DataGridView
    Friend WithEvents lblArtifactsTitle As System.Windows.Forms.Label
    Friend WithEvents btnAddEntry As System.Windows.Forms.Button
    Friend WithEvents dgvPortfolio As System.Windows.Forms.DataGridView
End Class