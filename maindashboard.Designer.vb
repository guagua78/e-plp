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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
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
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.cmbCategoryFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.pnlMainContainer = New System.Windows.Forms.Panel()
        Me.lblPortfolioTitle = New System.Windows.Forms.Label()
        Me.lblSummaryTitle = New System.Windows.Forms.Label()
        Me.dgvPortfolio = New System.Windows.Forms.DataGridView()
        Me.dgvProgressSummary = New System.Windows.Forms.DataGridView()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlCompetenciesSubMenu.SuspendLayout()
        Me.pnlSidebarHeader.SuspendLayout()
        Me.pnlTopHeader.SuspendLayout()
        Me.pnlMainContainer.SuspendLayout()
        CType(Me.dgvPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProgressSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.AutoScroll = True
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
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
        Me.btnLogout.Text = "   Logout"
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
        Me.btnNavEditProfile.Text = "   Edit Student Profile"
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
        Me.btnSubPersonalDev.Text = "     └ Personal Dev."
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
        Me.btnSubCommunity.Text = "     ├ Community Engagement"
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
        Me.btnSubProfDev.Text = "     ├ Professional Dev."
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
        Me.btnSubTechnical.Text = "     ├ Technical Skills"
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
        Me.btnSubTeamwork.Text = "     ├ Teamwork"
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
        Me.btnSubCommunication.Text = "     ├ Communication"
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
        Me.btnSubLeadership.Text = "     ├ Leadership"
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
        Me.btnToggleCompetencies.Text = "   Skill Competencies  ▼"
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
        Me.btnNavDashboard.Text = "   Dashboard"
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
        Me.pnlTopHeader.Controls.Add(Me.btnAddEntry)
        Me.pnlTopHeader.Controls.Add(Me.cmbCategoryFilter)
        Me.pnlTopHeader.Controls.Add(Me.txtSearch)
        Me.pnlTopHeader.Controls.Add(Me.lblGreeting)
        Me.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopHeader.Location = New System.Drawing.Point(240, 0)
        Me.pnlTopHeader.Name = "pnlTopHeader"
        Me.pnlTopHeader.Size = New System.Drawing.Size(960, 65)
        Me.pnlTopHeader.TabIndex = 1
        '
        'btnAddEntry
        '
        Me.btnAddEntry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEntry.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAddEntry.ForeColor = System.Drawing.Color.White
        Me.btnAddEntry.Location = New System.Drawing.Point(795, 15)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(145, 35)
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
        Me.cmbCategoryFilter.Location = New System.Drawing.Point(575, 18)
        Me.cmbCategoryFilter.Name = "cmbCategoryFilter"
        Me.cmbCategoryFilter.Size = New System.Drawing.Size(205, 29)
        Me.cmbCategoryFilter.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearch.Location = New System.Drawing.Point(345, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(215, 29)
        Me.txtSearch.TabIndex = 1
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblGreeting.Location = New System.Drawing.Point(20, 20)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(210, 25)
        Me.lblGreeting.TabIndex = 0
        Me.lblGreeting.Text = "Hello, Student Profile!"
        '
        'pnlMainContainer
        '
        Me.pnlMainContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pnlMainContainer.Controls.Add(Me.lblPortfolioTitle)
        Me.pnlMainContainer.Controls.Add(Me.lblSummaryTitle)
        Me.pnlMainContainer.Controls.Add(Me.dgvPortfolio)
        Me.pnlMainContainer.Controls.Add(Me.dgvProgressSummary)
        Me.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContainer.Location = New System.Drawing.Point(240, 65)
        Me.pnlMainContainer.Name = "pnlMainContainer"
        Me.pnlMainContainer.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMainContainer.Size = New System.Drawing.Size(960, 655)
        Me.pnlMainContainer.TabIndex = 2
        '
        'lblPortfolioTitle
        '
        Me.lblPortfolioTitle.AutoSize = True
        Me.lblPortfolioTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblPortfolioTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblPortfolioTitle.Location = New System.Drawing.Point(20, 215)
        Me.lblPortfolioTitle.Name = "lblPortfolioTitle"
        Me.lblPortfolioTitle.Size = New System.Drawing.Size(252, 25)
        Me.lblPortfolioTitle.TabIndex = 3
        Me.lblPortfolioTitle.Text = "Submitted Artifacts Records"
        '
        'lblSummaryTitle
        '
        Me.lblSummaryTitle.AutoSize = True
        Me.lblSummaryTitle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblSummaryTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblSummaryTitle.Name = "lblSummaryTitle"
        Me.lblSummaryTitle.Size = New System.Drawing.Size(322, 25)
        Me.lblSummaryTitle.TabIndex = 2
        Me.lblSummaryTitle.Text = "Skill Competency Progress Summary"
        '
        'dgvPortfolio
        '
        Me.dgvPortfolio.AllowUserToAddRows = False
        Me.dgvPortfolio.AllowUserToDeleteRows = False
        Me.dgvPortfolio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPortfolio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPortfolio.BackgroundColor = System.Drawing.Color.White
        Me.dgvPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPortfolio.Location = New System.Drawing.Point(23, 245)
        Me.dgvPortfolio.Name = "dgvPortfolio"
        Me.dgvPortfolio.ReadOnly = True
        Me.dgvPortfolio.RowHeadersWidth = 51
        Me.dgvPortfolio.RowTemplate.Height = 28
        Me.dgvPortfolio.Size = New System.Drawing.Size(915, 385)
        Me.dgvPortfolio.TabIndex = 1
        '
        'dgvProgressSummary
        '
        Me.dgvProgressSummary.AllowUserToAddRows = False
        Me.dgvProgressSummary.AllowUserToDeleteRows = False
        Me.dgvProgressSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProgressSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProgressSummary.BackgroundColor = System.Drawing.Color.White
        Me.dgvProgressSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgressSummary.Location = New System.Drawing.Point(23, 45)
        Me.dgvProgressSummary.Name = "dgvProgressSummary"
        Me.dgvProgressSummary.ReadOnly = True
        Me.dgvProgressSummary.RowHeadersWidth = 51
        Me.dgvProgressSummary.RowTemplate.Height = 28
        Me.dgvProgressSummary.Size = New System.Drawing.Size(915, 155)
        Me.dgvProgressSummary.TabIndex = 0
        '
        'maindashboard
        '
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
        Me.pnlMainContainer.PerformLayout()
        CType(Me.dgvPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProgressSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlSidebarHeader As System.Windows.Forms.Panel
    Friend WithEvents lblAppBrand As System.Windows.Forms.Label
    Friend WithEvents lblSubBrand As System.Windows.Forms.Label
    Friend WithEvents btnNavDashboard As System.Windows.Forms.Button
    Friend WithEvents btnToggleCompetencies As System.Windows.Forms.Button
    Friend WithEvents pnlCompetenciesSubMenu As System.Windows.Forms.Panel
    Friend WithEvents btnSubLeadership As System.Windows.Forms.Button
    Friend WithEvents btnSubCommunication As System.Windows.Forms.Button
    Friend WithEvents btnSubTeamwork As System.Windows.Forms.Button
    Friend WithEvents btnSubTechnical As System.Windows.Forms.Button
    Friend WithEvents btnSubProfDev As System.Windows.Forms.Button
    Friend WithEvents btnSubCommunity As System.Windows.Forms.Button
    Friend WithEvents btnSubPersonalDev As System.Windows.Forms.Button
    Friend WithEvents btnNavEditProfile As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlTopHeader As System.Windows.Forms.Panel
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategoryFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddEntry As System.Windows.Forms.Button
    Friend WithEvents pnlMainContainer As System.Windows.Forms.Panel
    Friend WithEvents dgvProgressSummary As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPortfolio As System.Windows.Forms.DataGridView
    Friend WithEvents lblSummaryTitle As System.Windows.Forms.Label
    Friend WithEvents lblPortfolioTitle As System.Windows.Forms.Label
End Class