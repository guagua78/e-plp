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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnNavEditProfile = New System.Windows.Forms.Button()
        Me.pnlCompetenciesSubMenu = New System.Windows.Forms.Panel()
        Me.btnSubPersonalDev = New System.Windows.Forms.Button()
        Me.btnSubCommunity = New System.Windows.Forms.Button()
        Me.btnSubProfDev = New System.Windows.Forms.Button()
        Me.btnSubTechnical = New System.Windows.Forms.Button()
        Me.btnSubTeamwork = New System.Windows.Forms.Button()
        Me.btnSubCommunication = New System.Windows.Forms.Button()
        Me.btnSubLeadership = New System.Windows.Forms.Button()
        Me.btnToggleCompetencies = New System.Windows.Forms.Button()
        Me.btnNavDashboard = New System.Windows.Forms.Button()
        Me.pnlSidebarHeader = New System.Windows.Forms.Panel()
        Me.lblSubBrand = New System.Windows.Forms.Label()
        Me.lblAppBrand = New System.Windows.Forms.Label()
        Me.pnlTopHeader = New System.Windows.Forms.Panel()
        Me.lblStudentDetails = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.cmbCategoryFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.pnlMainContainer = New System.Windows.Forms.Panel()
        Me.pnlPortfolioCard = New System.Windows.Forms.Panel()
        Me.dgvPortfolio = New System.Windows.Forms.DataGridView()
        Me.lblPortfolioTitle = New System.Windows.Forms.Label()
        Me.pnlChartCard = New System.Windows.Forms.Panel()
        Me.btnViewAcademicChart = New System.Windows.Forms.Button()
        Me.btnViewCompetencyChart = New System.Windows.Forms.Button()
        Me.lblChartTitle = New System.Windows.Forms.Label()
        Me.pnlSummaryCard = New System.Windows.Forms.Panel()
        Me.flpProgressCards = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblSummaryTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlCompetenciesSubMenu.SuspendLayout()
        Me.pnlSidebarHeader.SuspendLayout()
        Me.pnlTopHeader.SuspendLayout()
        Me.pnlMainContainer.SuspendLayout()
        Me.pnlPortfolioCard.SuspendLayout()
        CType(Me.dgvPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChartCard.SuspendLayout()
        Me.pnlSummaryCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.AutoScroll = True
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnGenerateReport)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnNavEditProfile)
        Me.pnlSidebar.Controls.Add(Me.pnlCompetenciesSubMenu)
        Me.pnlSidebar.Controls.Add(Me.btnToggleCompetencies)
        Me.pnlSidebar.Controls.Add(Me.btnNavDashboard)
        Me.pnlSidebar.Controls.Add(Me.pnlSidebarHeader)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(240, 720)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGenerateReport.FlatAppearance.BorderSize = 0
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.Location = New System.Drawing.Point(0, 585)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(240, 45)
        Me.btnGenerateReport.TabIndex = 6
        Me.btnGenerateReport.Text = "📄 Generate Portfolio Report (PDF)"
        Me.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Firebrick
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 630)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 45)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "    Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnNavEditProfile
        '
        Me.btnNavEditProfile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnNavEditProfile.FlatAppearance.BorderSize = 0
        Me.btnNavEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavEditProfile.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNavEditProfile.ForeColor = System.Drawing.Color.White
        Me.btnNavEditProfile.Location = New System.Drawing.Point(0, 675)
        Me.btnNavEditProfile.Name = "btnNavEditProfile"
        Me.btnNavEditProfile.Size = New System.Drawing.Size(240, 45)
        Me.btnNavEditProfile.TabIndex = 4
        Me.btnNavEditProfile.Text = "    Edit Student Profile"
        Me.btnNavEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavEditProfile.UseVisualStyleBackColor = True
        '
        'pnlCompetenciesSubMenu
        '
        Me.pnlCompetenciesSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlCompetenciesSubMenu.Controls.Add(Me.btnSubPersonalDev)
        Me.pnlCompetenciesSubMenu.Controls.Add(Me.btnSubCommunity)
        Me.pnlCompetenciesSubMenu.Controls.Add(Me.btnSubProfDev)
        Me.pnlCompetenciesSubMenu.Controls.Add(Me.btnSubTechnical)
        Me.pnlCompetenciesSubMenu.Controls.Add(Me.btnSubTeamwork)
        Me.pnlCompetenciesSubMenu.Controls.Add(Me.btnSubCommunication)
        Me.pnlCompetenciesSubMenu.Controls.Add(Me.btnSubLeadership)
        Me.pnlCompetenciesSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCompetenciesSubMenu.Location = New System.Drawing.Point(0, 160)
        Me.pnlCompetenciesSubMenu.Name = "pnlCompetenciesSubMenu"
        Me.pnlCompetenciesSubMenu.Size = New System.Drawing.Size(240, 230)
        Me.pnlCompetenciesSubMenu.TabIndex = 3
        '
        'btnSubPersonalDev
        '
        Me.btnSubPersonalDev.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubPersonalDev.FlatAppearance.BorderSize = 0
        Me.btnSubPersonalDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubPersonalDev.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubPersonalDev.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSubPersonalDev.Location = New System.Drawing.Point(0, 192)
        Me.btnSubPersonalDev.Name = "btnSubPersonalDev"
        Me.btnSubPersonalDev.Size = New System.Drawing.Size(240, 32)
        Me.btnSubPersonalDev.TabIndex = 6
        Me.btnSubPersonalDev.Text = "       └ Personal Dev."
        Me.btnSubPersonalDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubPersonalDev.UseVisualStyleBackColor = True
        '
        'btnSubCommunity
        '
        Me.btnSubCommunity.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubCommunity.FlatAppearance.BorderSize = 0
        Me.btnSubCommunity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubCommunity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubCommunity.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSubCommunity.Location = New System.Drawing.Point(0, 160)
        Me.btnSubCommunity.Name = "btnSubCommunity"
        Me.btnSubCommunity.Size = New System.Drawing.Size(240, 32)
        Me.btnSubCommunity.TabIndex = 5
        Me.btnSubCommunity.Text = "       ├ Community Engagement"
        Me.btnSubCommunity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCommunity.UseVisualStyleBackColor = True
        '
        'btnSubProfDev
        '
        Me.btnSubProfDev.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubProfDev.FlatAppearance.BorderSize = 0
        Me.btnSubProfDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubProfDev.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubProfDev.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSubProfDev.Location = New System.Drawing.Point(0, 128)
        Me.btnSubProfDev.Name = "btnSubProfDev"
        Me.btnSubProfDev.Size = New System.Drawing.Size(240, 32)
        Me.btnSubProfDev.TabIndex = 4
        Me.btnSubProfDev.Text = "       ├ Professional Dev."
        Me.btnSubProfDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubProfDev.UseVisualStyleBackColor = True
        '
        'btnSubTechnical
        '
        Me.btnSubTechnical.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubTechnical.FlatAppearance.BorderSize = 0
        Me.btnSubTechnical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubTechnical.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubTechnical.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSubTechnical.Location = New System.Drawing.Point(0, 96)
        Me.btnSubTechnical.Name = "btnSubTechnical"
        Me.btnSubTechnical.Size = New System.Drawing.Size(240, 32)
        Me.btnSubTechnical.TabIndex = 3
        Me.btnSubTechnical.Text = "       ├ Technical Skills"
        Me.btnSubTechnical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubTechnical.UseVisualStyleBackColor = True
        '
        'btnSubTeamwork
        '
        Me.btnSubTeamwork.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubTeamwork.FlatAppearance.BorderSize = 0
        Me.btnSubTeamwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubTeamwork.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubTeamwork.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSubTeamwork.Location = New System.Drawing.Point(0, 64)
        Me.btnSubTeamwork.Name = "btnSubTeamwork"
        Me.btnSubTeamwork.Size = New System.Drawing.Size(240, 32)
        Me.btnSubTeamwork.TabIndex = 2
        Me.btnSubTeamwork.Text = "       ├ Teamwork"
        Me.btnSubTeamwork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubTeamwork.UseVisualStyleBackColor = True
        '
        'btnSubCommunication
        '
        Me.btnSubCommunication.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubCommunication.FlatAppearance.BorderSize = 0
        Me.btnSubCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubCommunication.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubCommunication.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSubCommunication.Location = New System.Drawing.Point(0, 32)
        Me.btnSubCommunication.Name = "btnSubCommunication"
        Me.btnSubCommunication.Size = New System.Drawing.Size(240, 32)
        Me.btnSubCommunication.TabIndex = 1
        Me.btnSubCommunication.Text = "       ├ Communication"
        Me.btnSubCommunication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubCommunication.UseVisualStyleBackColor = True
        '
        'btnSubLeadership
        '
        Me.btnSubLeadership.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubLeadership.FlatAppearance.BorderSize = 0
        Me.btnSubLeadership.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubLeadership.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubLeadership.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSubLeadership.Location = New System.Drawing.Point(0, 0)
        Me.btnSubLeadership.Name = "btnSubLeadership"
        Me.btnSubLeadership.Size = New System.Drawing.Size(240, 32)
        Me.btnSubLeadership.TabIndex = 0
        Me.btnSubLeadership.Text = "       ├ Leadership"
        Me.btnSubLeadership.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubLeadership.UseVisualStyleBackColor = True
        '
        'btnToggleCompetencies
        '
        Me.btnToggleCompetencies.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnToggleCompetencies.FlatAppearance.BorderSize = 0
        Me.btnToggleCompetencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleCompetencies.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnToggleCompetencies.ForeColor = System.Drawing.Color.White
        Me.btnToggleCompetencies.Location = New System.Drawing.Point(0, 115)
        Me.btnToggleCompetencies.Name = "btnToggleCompetencies"
        Me.btnToggleCompetencies.Size = New System.Drawing.Size(240, 45)
        Me.btnToggleCompetencies.TabIndex = 2
        Me.btnToggleCompetencies.Text = "    Skill Competencies  ▼"
        Me.btnToggleCompetencies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToggleCompetencies.UseVisualStyleBackColor = True
        '
        'btnNavDashboard
        '
        Me.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavDashboard.FlatAppearance.BorderSize = 0
        Me.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNavDashboard.ForeColor = System.Drawing.Color.White
        Me.btnNavDashboard.Location = New System.Drawing.Point(0, 70)
        Me.btnNavDashboard.Name = "btnNavDashboard"
        Me.btnNavDashboard.Size = New System.Drawing.Size(240, 45)
        Me.btnNavDashboard.TabIndex = 1
        Me.btnNavDashboard.Text = "    Dashboard"
        Me.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavDashboard.UseVisualStyleBackColor = True
        '
        'pnlSidebarHeader
        '
        Me.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.pnlSidebarHeader.Controls.Add(Me.lblSubBrand)
        Me.pnlSidebarHeader.Controls.Add(Me.lblAppBrand)
        Me.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSidebarHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarHeader.Name = "pnlSidebarHeader"
        Me.pnlSidebarHeader.Size = New System.Drawing.Size(240, 70)
        Me.pnlSidebarHeader.TabIndex = 0
        '
        'lblSubBrand
        '
        Me.lblSubBrand.AutoSize = True
        Me.lblSubBrand.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblSubBrand.ForeColor = System.Drawing.Color.LightGray
        Me.lblSubBrand.Location = New System.Drawing.Point(18, 42)
        Me.lblSubBrand.Name = "lblSubBrand"
        Me.lblSubBrand.Size = New System.Drawing.Size(55, 17)
        Me.lblSubBrand.TabIndex = 1
        Me.lblSubBrand.Text = "PLP CCS"
        '
        'lblAppBrand
        '
        Me.lblAppBrand.AutoSize = True
        Me.lblAppBrand.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppBrand.ForeColor = System.Drawing.Color.White
        Me.lblAppBrand.Location = New System.Drawing.Point(16, 12)
        Me.lblAppBrand.Name = "lblAppBrand"
        Me.lblAppBrand.Size = New System.Drawing.Size(180, 30)
        Me.lblAppBrand.TabIndex = 0
        Me.lblAppBrand.Text = "E-PLPORTFOLIO"
        '
        'pnlTopHeader
        '
        Me.pnlTopHeader.BackColor = System.Drawing.Color.White
        Me.pnlTopHeader.Controls.Add(Me.lblStudentDetails)
        Me.pnlTopHeader.Controls.Add(Me.Label2)
        Me.pnlTopHeader.Controls.Add(Me.btnAddEntry)
        Me.pnlTopHeader.Controls.Add(Me.cmbCategoryFilter)
        Me.pnlTopHeader.Controls.Add(Me.txtSearch)
        Me.pnlTopHeader.Controls.Add(Me.lblGreeting)
        Me.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopHeader.Location = New System.Drawing.Point(240, 0)
        Me.pnlTopHeader.Name = "pnlTopHeader"
        Me.pnlTopHeader.Size = New System.Drawing.Size(960, 80)
        Me.pnlTopHeader.TabIndex = 1
        '
        'lblStudentDetails
        '
        Me.lblStudentDetails.AutoSize = True
        Me.lblStudentDetails.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblStudentDetails.ForeColor = System.Drawing.Color.DimGray
        Me.lblStudentDetails.Location = New System.Drawing.Point(20, 38)
        Me.lblStudentDetails.Name = "lblStudentDetails"
        Me.lblStudentDetails.Size = New System.Drawing.Size(259, 40)
        Me.lblStudentDetails.TabIndex = 5
        Me.lblStudentDetails.Text = "BS Information Technology • 2nd Year" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "25-00760"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(604, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Artifact Title:"
        '
        'btnAddEntry
        '
        Me.btnAddEntry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEntry.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAddEntry.ForeColor = System.Drawing.Color.White
        Me.btnAddEntry.Location = New System.Drawing.Point(795, 22)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(145, 34)
        Me.btnAddEntry.TabIndex = 3
        Me.btnAddEntry.Text = "+ Add New Entry"
        Me.btnAddEntry.UseVisualStyleBackColor = False
        '
        'cmbCategoryFilter
        '
        Me.cmbCategoryFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoryFilter.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbCategoryFilter.FormattingEnabled = True
        Me.cmbCategoryFilter.Location = New System.Drawing.Point(575, 24)
        Me.cmbCategoryFilter.Name = "cmbCategoryFilter"
        Me.cmbCategoryFilter.Size = New System.Drawing.Size(205, 29)
        Me.cmbCategoryFilter.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearch.Location = New System.Drawing.Point(345, 24)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(215, 29)
        Me.txtSearch.TabIndex = 1
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblGreeting.Location = New System.Drawing.Point(20, 10)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(223, 28)
        Me.lblGreeting.TabIndex = 0
        Me.lblGreeting.Text = "Hello, Student Profile!"
        '
        'pnlMainContainer
        '
        Me.pnlMainContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlMainContainer.Controls.Add(Me.pnlPortfolioCard)
        Me.pnlMainContainer.Controls.Add(Me.pnlChartCard)
        Me.pnlMainContainer.Controls.Add(Me.pnlSummaryCard)
        Me.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContainer.Location = New System.Drawing.Point(240, 80)
        Me.pnlMainContainer.Name = "pnlMainContainer"
        Me.pnlMainContainer.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMainContainer.Size = New System.Drawing.Size(960, 640)
        Me.pnlMainContainer.TabIndex = 2
        '
        'pnlPortfolioCard
        '
        Me.pnlPortfolioCard.BackColor = System.Drawing.Color.White
        Me.pnlPortfolioCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPortfolioCard.Controls.Add(Me.dgvPortfolio)
        Me.pnlPortfolioCard.Controls.Add(Me.lblPortfolioTitle)
        Me.pnlPortfolioCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPortfolioCard.Location = New System.Drawing.Point(20, 391)
        Me.pnlPortfolioCard.Name = "pnlPortfolioCard"
        Me.pnlPortfolioCard.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlPortfolioCard.Size = New System.Drawing.Size(920, 229)
        Me.pnlPortfolioCard.TabIndex = 2
        '
        'dgvPortfolio
        '
        Me.dgvPortfolio.AllowUserToAddRows = False
        Me.dgvPortfolio.AllowUserToDeleteRows = False
        Me.dgvPortfolio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPortfolio.BackgroundColor = System.Drawing.Color.White
        Me.dgvPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPortfolio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPortfolio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPortfolio.ColumnHeadersHeight = 32
        Me.dgvPortfolio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPortfolio.EnableHeadersVisualStyles = False
        Me.dgvPortfolio.Location = New System.Drawing.Point(12, 35)
        Me.dgvPortfolio.Name = "dgvPortfolio"
        Me.dgvPortfolio.ReadOnly = True
        Me.dgvPortfolio.RowHeadersVisible = False
        Me.dgvPortfolio.RowHeadersWidth = 51
        Me.dgvPortfolio.RowTemplate.Height = 28
        Me.dgvPortfolio.Size = New System.Drawing.Size(894, 180)
        Me.dgvPortfolio.TabIndex = 1
        '
        'lblPortfolioTitle
        '
        Me.lblPortfolioTitle.AutoSize = True
        Me.lblPortfolioTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPortfolioTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPortfolioTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblPortfolioTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblPortfolioTitle.Name = "lblPortfolioTitle"
        Me.lblPortfolioTitle.Size = New System.Drawing.Size(238, 23)
        Me.lblPortfolioTitle.TabIndex = 0
        Me.lblPortfolioTitle.Text = "Submitted Artifacts Records"
        '
        'pnlChartCard
        '
        Me.pnlChartCard.BackColor = System.Drawing.Color.White
        Me.pnlChartCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChartCard.Controls.Add(Me.btnViewAcademicChart)
        Me.pnlChartCard.Controls.Add(Me.btnViewCompetencyChart)
        Me.pnlChartCard.Controls.Add(Me.lblChartTitle)
        Me.pnlChartCard.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlChartCard.Location = New System.Drawing.Point(20, 180)
        Me.pnlChartCard.Name = "pnlChartCard"
        Me.pnlChartCard.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlChartCard.Size = New System.Drawing.Size(920, 211)
        Me.pnlChartCard.TabIndex = 3
        '
        'btnViewAcademicChart
        '
        Me.btnViewAcademicChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewAcademicChart.BackColor = System.Drawing.Color.Gainsboro
        Me.btnViewAcademicChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAcademicChart.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnViewAcademicChart.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnViewAcademicChart.Location = New System.Drawing.Point(760, 8)
        Me.btnViewAcademicChart.Name = "btnViewAcademicChart"
        Me.btnViewAcademicChart.Size = New System.Drawing.Size(145, 28)
        Me.btnViewAcademicChart.TabIndex = 2
        Me.btnViewAcademicChart.Text = "📚 Academic Courses"
        Me.btnViewAcademicChart.UseVisualStyleBackColor = False
        '
        'btnViewCompetencyChart
        '
        Me.btnViewCompetencyChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewCompetencyChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnViewCompetencyChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewCompetencyChart.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnViewCompetencyChart.ForeColor = System.Drawing.Color.White
        Me.btnViewCompetencyChart.Location = New System.Drawing.Point(608, 8)
        Me.btnViewCompetencyChart.Name = "btnViewCompetencyChart"
        Me.btnViewCompetencyChart.Size = New System.Drawing.Size(145, 28)
        Me.btnViewCompetencyChart.TabIndex = 1
        Me.btnViewCompetencyChart.Text = "📊 Competencies"
        Me.btnViewCompetencyChart.UseVisualStyleBackColor = False
        '
        'lblChartTitle
        '
        Me.lblChartTitle.AutoSize = True
        Me.lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblChartTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblChartTitle.Name = "lblChartTitle"
        Me.lblChartTitle.Size = New System.Drawing.Size(296, 23)
        Me.lblChartTitle.TabIndex = 0
        Me.lblChartTitle.Text = "Competency Progression Over Time"
        '
        'pnlSummaryCard
        '
        Me.pnlSummaryCard.BackColor = System.Drawing.Color.White
        Me.pnlSummaryCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSummaryCard.Controls.Add(Me.flpProgressCards)
        Me.pnlSummaryCard.Controls.Add(Me.lblSummaryTitle)
        Me.pnlSummaryCard.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSummaryCard.Location = New System.Drawing.Point(20, 20)
        Me.pnlSummaryCard.Name = "pnlSummaryCard"
        Me.pnlSummaryCard.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlSummaryCard.Size = New System.Drawing.Size(920, 160)
        Me.pnlSummaryCard.TabIndex = 1
        '
        'flpProgressCards
        '
        Me.flpProgressCards.AutoScroll = True
        Me.flpProgressCards.BackColor = System.Drawing.Color.Transparent
        Me.flpProgressCards.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpProgressCards.Location = New System.Drawing.Point(12, 35)
        Me.flpProgressCards.Name = "flpProgressCards"
        Me.flpProgressCards.Size = New System.Drawing.Size(894, 111)
        Me.flpProgressCards.TabIndex = 1
        '
        'lblSummaryTitle
        '
        Me.lblSummaryTitle.AutoSize = True
        Me.lblSummaryTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSummaryTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblSummaryTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblSummaryTitle.Name = "lblSummaryTitle"
        Me.lblSummaryTitle.Size = New System.Drawing.Size(306, 23)
        Me.lblSummaryTitle.TabIndex = 0
        Me.lblSummaryTitle.Text = "Skill Competency Progress Summary"
        '
        'maindashboard
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.pnlMainContainer)
        Me.Controls.Add(Me.pnlTopHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "maindashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Portfolioboxd - Student E-Portfolio System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlCompetenciesSubMenu.ResumeLayout(False)
        Me.pnlSidebarHeader.ResumeLayout(False)
        Me.pnlSidebarHeader.PerformLayout()
        Me.pnlTopHeader.ResumeLayout(False)
        Me.pnlTopHeader.PerformLayout()
        Me.pnlMainContainer.ResumeLayout(False)
        Me.pnlPortfolioCard.ResumeLayout(False)
        Me.pnlPortfolioCard.PerformLayout()
        CType(Me.dgvPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChartCard.ResumeLayout(False)
        Me.pnlChartCard.PerformLayout()
        Me.pnlSummaryCard.ResumeLayout(False)
        Me.pnlSummaryCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlSidebarHeader As System.Windows.Forms.Panel
    Friend WithEvents lblAppBrand As System.Windows.Forms.Label
    Friend WithEvents lblSubBrand As System.Windows.Forms.Label
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents btnToggleCompetencies As Button
    Friend WithEvents pnlCompetenciesSubMenu As System.Windows.Forms.Panel
    Friend WithEvents btnSubLeadership As Button
    Friend WithEvents btnSubCommunication As Button
    Friend WithEvents btnSubTeamwork As Button
    Friend WithEvents btnSubTechnical As Button
    Friend WithEvents btnSubProfDev As Button
    Friend WithEvents btnSubCommunity As Button
    Friend WithEvents btnSubPersonalDev As Button
    Friend WithEvents btnNavEditProfile As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlTopHeader As System.Windows.Forms.Panel
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents lblStudentDetails As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategoryFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddEntry As Button
    Friend WithEvents pnlMainContainer As System.Windows.Forms.Panel
    Friend WithEvents pnlSummaryCard As System.Windows.Forms.Panel
    Friend WithEvents lblSummaryTitle As System.Windows.Forms.Label
    Friend WithEvents flpProgressCards As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlChartCard As System.Windows.Forms.Panel
    Friend WithEvents lblChartTitle As System.Windows.Forms.Label
    Friend WithEvents pnlPortfolioCard As System.Windows.Forms.Panel
    Friend WithEvents lblPortfolioTitle As System.Windows.Forms.Label
    Friend WithEvents dgvPortfolio As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents btnViewCompetencyChart As Button
    Friend WithEvents btnViewAcademicChart As Button
End Class