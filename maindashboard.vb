Imports System.IO
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class maindashboard

    ' Dynamic chart & grid view mode state variables
    Private chartLabels As New List(Of String)()
    Private chartSubLabels As New List(Of String)() ' Stores course name or raw month strings
    Private chartValues As New List(Of Integer)()
    Private activeFilterCategoryName As String = "All Skill Competencies"
    Private currentChartViewMode As Integer = 1 ' 1 = Competency / Activity View, 2 = Academic Subject View

    ' Interactive chart bar click tracking
    Private barBounds As New List(Of RectangleF)()

    Private Sub maindashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Bind Dynamic Header Labels for the Logged-In Student
        lblGreeting.Text = "Hello, " & CurrentUserFullName & "!"

        ' Dynamic Subtitle with Student ID and Program
        If lblStudentDetails IsNot Nothing Then
            lblStudentDetails.Text = $"{CurrentUserProgram} • {CurrentUserYearLevel}{vbCrLf}{CurrentStudentNumber}"
        End If

        pnlCompetenciesSubMenu.BringToFront()
        btnAddEntry.BringToFront()

        PopulateCategoryFilter()
        RefreshDashboard()
    End Sub

    ' -------------------------------------------------------------
    ' SEARCH PLACEHOLDER HANDLERS
    ' -------------------------------------------------------------
    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search artifact title..." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search artifact title..."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        Dim addForm As New frmAddEntry()
        If addForm.ShowDialog() = DialogResult.OK Then
            RefreshDashboard()
        End If
    End Sub

    ' -------------------------------------------------------------
    ' SIDEBAR NAVIGATION & CATEGORY TOGGLE
    ' -------------------------------------------------------------
    Private Sub btnToggleCompetencies_Click(sender As Object, e As EventArgs) Handles btnToggleCompetencies.Click
        pnlCompetenciesSubMenu.Visible = Not pnlCompetenciesSubMenu.Visible
    End Sub

    Private Sub PopulateCategoryFilter()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim catCmd As New MySqlCommand("SELECT category_id, category_name FROM categories ORDER BY category_name ASC", conn)
                    Dim catAdapter As New MySqlDataAdapter(catCmd)
                    Dim catTable As New DataTable()
                    catAdapter.Fill(catTable)

                    Dim dr As DataRow = catTable.NewRow()
                    dr("category_id") = 0
                    dr("category_name") = "All Skill Competencies"
                    catTable.Rows.InsertAt(dr, 0)

                    cmbCategoryFilter.DataSource = catTable
                    cmbCategoryFilter.DisplayMember = "category_name"
                    cmbCategoryFilter.ValueMember = "category_id"
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        If cmbCategoryFilter.Items.Count > 0 Then cmbCategoryFilter.SelectedIndex = 0
        txtSearch.Clear()
        currentChartViewMode = 1
        btnViewCompetencyChart.BackColor = Color.FromArgb(24, 88, 54)
        btnViewCompetencyChart.ForeColor = Color.White
        btnViewAcademicChart.BackColor = Color.Gainsboro
        btnViewAcademicChart.ForeColor = Color.DarkSlateGray
        RefreshDashboard()
    End Sub

    Private Sub FilterByCompetencyName(categoryName As String)
        txtSearch.Clear()

        ' Switch back to Competency Mode when a skill category is selected
        currentChartViewMode = 1
        btnViewCompetencyChart.BackColor = Color.FromArgb(24, 88, 54)
        btnViewCompetencyChart.ForeColor = Color.White
        btnViewAcademicChart.BackColor = Color.Gainsboro
        btnViewAcademicChart.ForeColor = Color.DarkSlateGray

        If cmbCategoryFilter.DataSource IsNot Nothing Then
            For i As Integer = 0 To cmbCategoryFilter.Items.Count - 1
                Dim row As DataRowView = TryCast(cmbCategoryFilter.Items(i), DataRowView)
                If row IsNot Nothing AndAlso row("category_name").ToString().Equals(categoryName, StringComparison.OrdinalIgnoreCase) Then
                    cmbCategoryFilter.SelectedIndex = i
                    Return
                End If
            Next
        End If
    End Sub

    Private Sub btnSubLeadership_Click(sender As Object, e As EventArgs) Handles btnSubLeadership.Click
        FilterByCompetencyName("Leadership")
    End Sub

    Private Sub btnSubCommunication_Click(sender As Object, e As EventArgs) Handles btnSubCommunication.Click
        FilterByCompetencyName("Communication")
    End Sub

    Private Sub btnSubTeamwork_Click(sender As Object, e As EventArgs) Handles btnSubTeamwork.Click
        FilterByCompetencyName("Teamwork")
    End Sub

    Private Sub btnSubTechnical_Click(sender As Object, e As EventArgs) Handles btnSubTechnical.Click
        FilterByCompetencyName("Technical Skills")
    End Sub

    Private Sub btnSubProfDev_Click(sender As Object, e As EventArgs) Handles btnSubProfDev.Click
        FilterByCompetencyName("Professional Development")
    End Sub

    Private Sub btnSubCommunity_Click(sender As Object, e As EventArgs) Handles btnSubCommunity.Click
        FilterByCompetencyName("Community Engagement")
    End Sub

    Private Sub btnSubPersonalDev_Click(sender As Object, e As EventArgs) Handles btnSubPersonalDev.Click
        FilterByCompetencyName("Personal Development")
    End Sub

    ' -------------------------------------------------------------
    ' TOGGLE SWITCHER HANDLERS (COMPETENCIES VS ACADEMIC COURSES)
    ' -------------------------------------------------------------
    Private Sub btnViewCompetencyChart_Click(sender As Object, e As EventArgs) Handles btnViewCompetencyChart.Click
        currentChartViewMode = 1
        btnViewCompetencyChart.BackColor = Color.FromArgb(24, 88, 54)
        btnViewCompetencyChart.ForeColor = Color.White
        btnViewAcademicChart.BackColor = Color.Gainsboro
        btnViewAcademicChart.ForeColor = Color.DarkSlateGray

        lblPortfolioTitle.Text = "Submitted Artifacts Records (Competencies View)"
        LoadProgressChart(CurrentStudentNumber)
        FilterPortfolioEntries()
    End Sub

    Private Sub btnViewAcademicChart_Click(sender As Object, e As EventArgs) Handles btnViewAcademicChart.Click
        currentChartViewMode = 2
        btnViewAcademicChart.BackColor = Color.FromArgb(24, 88, 54)
        btnViewAcademicChart.ForeColor = Color.White
        btnViewCompetencyChart.BackColor = Color.Gainsboro
        btnViewCompetencyChart.ForeColor = Color.DarkSlateGray

        lblPortfolioTitle.Text = "Submitted Artifacts Records (Academic Courses View)"
        LoadProgressChart(CurrentStudentNumber)
        FilterPortfolioEntries()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterPortfolioEntries()
    End Sub

    Private Sub cmbCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoryFilter.SelectedIndexChanged
        If cmbCategoryFilter.SelectedItem IsNot Nothing Then
            Dim row As DataRowView = TryCast(cmbCategoryFilter.SelectedItem, DataRowView)
            If row IsNot Nothing Then
                activeFilterCategoryName = row("category_name").ToString()
            End If
        End If

        FilterPortfolioEntries()
        LoadProgressChart(CurrentStudentNumber)
    End Sub

    Private Sub dgvPortfolio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPortfolio.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedId As Integer = Convert.ToInt32(dgvPortfolio.Rows(e.RowIndex).Cells("ID").Value)
            Dim viewForm As New frmViewEntry()
            viewForm.SelectedEntryID = selectedId

            If viewForm.ShowDialog() = DialogResult.OK Then
                RefreshDashboard()
            End If
        End If
    End Sub

    Private Sub btnNavEditProfile_Click(sender As Object, e As EventArgs) Handles btnNavEditProfile.Click
        Dim editForm As New frmEditProfile()
        If editForm.ShowDialog() = DialogResult.OK Then
            lblGreeting.Text = "Hello, " & CurrentUserFullName & "!"
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Globals.ClearSession()
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    ' -------------------------------------------------------------
    ' DASHBOARD REFRESH LOGIC
    ' -------------------------------------------------------------
    Public Sub RefreshDashboard()
        LoadCompetencyProgress()
        LoadProgressChart(CurrentStudentNumber)
        FilterPortfolioEntries()
    End Sub

    ' -------------------------------------------------------------
    ' DYNAMIC PROGRESS CARDS BUILDER (NO PERCENTAGES)
    ' -------------------------------------------------------------
    Private Sub LoadCompetencyProgress()
        Try
            flpProgressCards.SuspendLayout()
            flpProgressCards.Controls.Clear()

            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT c.category_name, COUNT(pe.entry_id) AS total_logged " &
                                          "FROM categories c " &
                                          "LEFT JOIN portfolio_entries pe ON c.category_id = pe.category_id AND pe.student_number = @stud " &
                                          "GROUP BY c.category_id, c.category_name " &
                                          "ORDER BY c.category_id ASC"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)
                        Using rdr As MySqlDataReader = cmd.ExecuteReader()
                            While rdr.Read()
                                Dim catName As String = rdr("category_name").ToString()
                                Dim entryCount As Integer = Convert.ToInt32(rdr("total_logged"))
                                Dim isSelected As Boolean = catName.Equals(activeFilterCategoryName, StringComparison.OrdinalIgnoreCase)

                                ' Card Panel Container
                                Dim card As New Panel With {
                                    .Size = New Size(140, 110),
                                    .Margin = New Padding(0, 0, 10, 0),
                                    .BackColor = Color.White,
                                    .Cursor = Cursors.Hand
                                }

                                ' Custom GDI+ Border Drawing & Selection Highlight
                                AddHandler card.Paint, Sub(s, pe)
                                                           pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                                                           If isSelected Then
                                                               Using penActive As New Pen(Color.FromArgb(24, 128, 70), 2.0F)
                                                                   pe.Graphics.DrawRectangle(penActive, 1, 1, card.Width - 3, card.Height - 3)
                                                               End Using
                                                           Else
                                                               Using penBorder As New Pen(Color.FromArgb(228, 233, 230), 1.0F)
                                                                   pe.Graphics.DrawRectangle(penBorder, 0, 0, card.Width - 1, card.Height - 1)
                                                               End Using
                                                           End If
                                                       End Sub

                                ' Category Name Label
                                Dim lblTitle As New Label With {
                                    .Text = If(catName.Length > 11, catName.Substring(0, 9) & "...", catName),
                                    .Font = New System.Drawing.Font("Segoe UI", 8.5F, FontStyle.Bold),
                                    .ForeColor = Color.FromArgb(45, 55, 50),
                                    .Location = New Point(12, 12),
                                    .AutoSize = True
                                }

                                ' Status Indicator Dot
                                Dim picDot As New PictureBox With {
                                    .Size = New Size(8, 8),
                                    .Location = New Point(118, 16),
                                    .BackColor = Color.Transparent
                                }
                                AddHandler picDot.Paint, Sub(s, pe)
                                                             pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                                                             Dim dotColor As Color = If(entryCount > 0, Color.FromArgb(36, 180, 100), Color.FromArgb(210, 215, 212))
                                                             Using brush As New SolidBrush(dotColor)
                                                                 pe.Graphics.FillEllipse(brush, 0, 0, 7, 7)
                                                             End Using
                                                         End Sub

                                ' Number Count Label (e.g., "9 ACTIVE" or "1" or "0")
                                Dim lblCount As New Label With {
                                    .Text = If(entryCount > 0 AndAlso isSelected, $"{entryCount} ACTIVE", entryCount.ToString()),
                                    .Font = New System.Drawing.Font("Segoe UI", If(entryCount > 0 AndAlso isSelected, 12.0F, 16.0F), FontStyle.Bold),
                                    .ForeColor = If(entryCount > 0, Color.FromArgb(24, 100, 58), Color.FromArgb(120, 130, 125)),
                                    .Location = New Point(10, 36),
                                    .AutoSize = True
                                }

                                ' "Record Logged" / "Records Logged" Label
                                Dim lblSubText As New Label With {
                                    .Text = If(entryCount = 1, "Record Logged", "Records Logged"),
                                    .Font = New System.Drawing.Font("Segoe UI", 7.5F, FontStyle.Bold),
                                    .ForeColor = If(isSelected, Color.FromArgb(24, 100, 58), Color.Gray),
                                    .Location = New Point(12, 64),
                                    .AutoSize = True
                                }

                                ' Bottom Visual Progress Strip
                                Dim pnlBottomBar As New Panel With {
                                    .Location = New Point(12, 88),
                                    .Size = New Size(116, 4),
                                    .BackColor = Color.FromArgb(235, 240, 237)
                                }
                                AddHandler pnlBottomBar.Paint, Sub(s, pe)
                                                                   pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                                                                   Dim fillRatio As Single = Math.Min(1.0F, CSng(entryCount) / 10.0F)
                                                                   Dim fillWidth As Integer = CInt(fillRatio * pnlBottomBar.Width)
                                                                   If fillWidth > 0 Then
                                                                       Using b As New SolidBrush(Color.FromArgb(24, 128, 70))
                                                                           pe.Graphics.FillRectangle(b, 0, 0, fillWidth, pnlBottomBar.Height)
                                                                       End Using
                                                                   End If
                                                               End Sub

                                ' Category Selection Handlers
                                AddHandler card.Click, Sub(s, e) FilterByCompetencyName(catName)
                                For Each ctrl As Control In New Control() {lblTitle, lblCount, lblSubText, picDot, pnlBottomBar}
                                    AddHandler ctrl.Click, Sub(s, e) FilterByCompetencyName(catName)
                                Next

                                card.Controls.Add(lblTitle)
                                card.Controls.Add(picDot)
                                card.Controls.Add(lblCount)
                                card.Controls.Add(lblSubText)
                                card.Controls.Add(pnlBottomBar)

                                flpProgressCards.Controls.Add(card)
                            End While
                        End Using
                    End Using
                End If
            End Using

            flpProgressCards.ResumeLayout()
        Catch ex As Exception
            flpProgressCards.ResumeLayout()
        End Try
    End Sub

    ' -------------------------------------------------------------
    ' DYNAMIC BAR CHART DATA QUERYING & CUSTOM GDI+ RENDERING
    ' -------------------------------------------------------------
    Private Sub LoadProgressChart(studentNum As String)
        chartLabels.Clear()
        chartSubLabels.Clear()
        chartValues.Clear()

        Dim query As String = ""

        If currentChartViewMode = 2 Then
            ' 📚 ACADEMIC SUBJECTS VIEW
            lblChartTitle.Text = "Academic Subject Accomplishments & Progress"

            query = "SELECT c.course_code AS label_name, " &
                    "c.course_name AS sub_label, " &
                    "COUNT(pe.entry_id) AS total_entries " &
                    "FROM courses c " &
                    "INNER JOIN portfolio_entries pe ON pe.course_code = c.course_code " &
                    "WHERE pe.student_number = @stud " &
                    "GROUP BY c.course_code, c.course_name " &
                    "ORDER BY total_entries DESC"
        Else
            ' 📊 COMPETENCIES / ACTIVITY TYPE VIEW
            Dim selectedCatId As Integer = If(cmbCategoryFilter.SelectedValue IsNot Nothing AndAlso TypeOf cmbCategoryFilter.SelectedValue Is Integer, Convert.ToInt32(cmbCategoryFilter.SelectedValue), 0)

            If selectedCatId = 0 Then
                ' Overall view: X-axis primary label is Month/Year
                lblChartTitle.Text = "Overall Competency Progression Over Time"

                query = "SELECT DATE_FORMAT(date_completed, '%b %Y') AS label_name, " &
                        "DATE_FORMAT(date_completed, '%Y-%m') AS raw_month, " &
                        "COUNT(*) AS total_entries " &
                        "FROM portfolio_entries " &
                        "WHERE student_number = @stud " &
                        "GROUP BY DATE_FORMAT(date_completed, '%Y-%m'), DATE_FORMAT(date_completed, '%b %Y') " &
                        "ORDER BY DATE_FORMAT(date_completed, '%Y-%m') ASC"
            Else
                ' Specific Category: X-axis primary label is Activity Type
                lblChartTitle.Text = $"{activeFilterCategoryName} — Activity Breakdown & Progress"

                query = "SELECT at.type_name AS label_name, " &
                        "'' AS sub_label, " &
                        "COUNT(pe.entry_id) AS total_entries " &
                        "FROM activity_types at " &
                        "LEFT JOIN portfolio_entries pe ON at.activity_type_id = pe.activity_type_id AND pe.student_number = @stud AND pe.category_id = @catId " &
                        "GROUP BY at.activity_type_id, at.type_name " &
                        "ORDER BY total_entries DESC"
            End If
        End If

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", studentNum)

                        If currentChartViewMode = 1 AndAlso cmbCategoryFilter.SelectedIndex > 0 Then
                            cmd.Parameters.AddWithValue("@catId", cmbCategoryFilter.SelectedValue)
                        End If

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                chartLabels.Add(reader("label_name").ToString())
                                chartValues.Add(Convert.ToInt32(reader("total_entries")))

                                Dim selectedCatId As Integer = If(cmbCategoryFilter.SelectedValue IsNot Nothing AndAlso TypeOf cmbCategoryFilter.SelectedValue Is Integer, Convert.ToInt32(cmbCategoryFilter.SelectedValue), 0)

                                If currentChartViewMode = 1 AndAlso selectedCatId = 0 Then
                                    chartSubLabels.Add(reader("raw_month").ToString())
                                ElseIf currentChartViewMode = 2 Then
                                    chartSubLabels.Add(reader("sub_label").ToString())
                                Else
                                    chartSubLabels.Add("")
                                End If
                            End While
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
        End Try

        pnlChartCard.Invalidate()
    End Sub

    Private Sub pnlChartCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlChartCard.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        barBounds.Clear()

        Dim marginX As Integer = 50
        Dim marginTop As Integer = 42
        Dim marginBottom As Integer = 42
        Dim drawWidth As Single = pnlChartCard.Width - (marginX * 2)
        Dim drawHeight As Single = pnlChartCard.Height - marginTop - marginBottom

        If chartValues.Count = 0 OrElse chartValues.Sum() = 0 Then
            Using fontHint As New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Italic)
                Dim emptyMsg As String = If(currentChartViewMode = 2,
                                           "No artifacts mapped to academic courses yet. Log new entries with course codes to populate this chart.",
                                           $"No logged entries recorded under '{activeFilterCategoryName}'. Add new artifacts to generate statistics.")
                g.DrawString(emptyMsg, fontHint, Brushes.Gray, marginX, marginTop + 15)
            End Using
            Return
        End If

        ' Draw background horizontal gridlines
        Dim maxVal As Single = Math.Max(4, chartValues.Max())
        Using gridPen As New Pen(Color.FromArgb(235, 238, 236), 1.0F)
            gridPen.DashStyle = Drawing2D.DashStyle.Dot
            For stepY As Integer = 1 To 3
                Dim lineY As Single = (pnlChartCard.Height - marginBottom) - (stepY * (drawHeight / 3))
                g.DrawLine(gridPen, marginX, lineY, pnlChartCard.Width - marginX, lineY)
            Next
        End Using

        Dim itemWidth As Single = drawWidth / chartValues.Count
        Dim barWidth As Single = Math.Min(itemWidth * 0.55F, 65.0F)

        For i As Integer = 0 To chartValues.Count - 1
            Dim countVal As Integer = chartValues(i)
            Dim barHeight As Single = (countVal / maxVal) * drawHeight

            Dim barX As Single = marginX + (i * itemWidth) + ((itemWidth - barWidth) / 2.0F)
            Dim barY As Single = (pnlChartCard.Height - marginBottom) - barHeight

            Dim barRect As New RectangleF(barX, barY, barWidth, Math.Max(barHeight, 20.0F))
            barBounds.Add(barRect)

            ' Render Gradient Bar
            If barHeight > 0 Then
                Dim renderRect As New RectangleF(barX, barY, barWidth, barHeight)
                Using barBrush As New Drawing2D.LinearGradientBrush(renderRect, Color.FromArgb(24, 88, 54), Color.FromArgb(45, 125, 80), Drawing2D.LinearGradientMode.Vertical)
                    g.FillRectangle(barBrush, renderRect)
                End Using

                Using borderPen As New Pen(Color.FromArgb(10, 40, 25), 1.5F)
                    g.DrawRectangle(borderPen, barX, barY, barWidth, barHeight)
                End Using

                Using fontBadge As New System.Drawing.Font("Segoe UI", 8.5!, FontStyle.Bold)
                    Dim valStr As String = countVal.ToString()
                    Dim badgeSize As SizeF = g.MeasureString(valStr, fontBadge)
                    g.DrawString(valStr, fontBadge, Brushes.DarkSlateGray, barX + ((barWidth - badgeSize.Width) / 2.0F), barY - 18)
                End Using
            End If

            ' Primary Label
            Using fontX As New System.Drawing.Font("Segoe UI", 8.0!, FontStyle.Bold)
                Dim labelStr As String = chartLabels(i)
                Dim lblSize As SizeF = g.MeasureString(labelStr, fontX)
                g.DrawString(labelStr, fontX, Brushes.DimGray, barX + ((barWidth - lblSize.Width) / 2.0F), pnlChartCard.Height - marginBottom + 4)
            End Using

            ' Secondary Course Name Sub-Label
            If currentChartViewMode = 2 AndAlso i < chartSubLabels.Count AndAlso Not String.IsNullOrEmpty(chartSubLabels(i)) Then
                Using fontSubX As New System.Drawing.Font("Segoe UI", 7.5!, FontStyle.Regular)
                    Dim subLabelStr As String = chartSubLabels(i)
                    If subLabelStr.Length > 15 Then subLabelStr = subLabelStr.Substring(0, 12) & "..."
                    Dim subLblSize As SizeF = g.MeasureString(subLabelStr, fontSubX)
                    g.DrawString(subLabelStr, fontSubX, Brushes.Gray, barX + ((barWidth - subLblSize.Width) / 2.0F), pnlChartCard.Height - marginBottom + 18)
                End Using
            End If
        Next

        ' X-Axis Baseline
        Using axisPen As New Pen(Color.FromArgb(180, 190, 185), 1.5F)
            g.DrawLine(axisPen, marginX, pnlChartCard.Height - marginBottom, pnlChartCard.Width - marginX, pnlChartCard.Height - marginBottom)
        End Using
    End Sub

    ' -------------------------------------------------------------
    ' INTERACTIVE CHART BAR CLICK HANDLER
    ' -------------------------------------------------------------
    Private Sub pnlChartCard_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlChartCard.MouseClick
        For i As Integer = 0 To barBounds.Count - 1
            If barBounds(i).Contains(e.Location) Then
                Dim clickedLabel As String = chartLabels(i)

                If currentChartViewMode = 2 Then
                    lblPortfolioTitle.Text = $"Submitted Artifacts Records — Course: {clickedLabel}"
                    FilterPortfolioEntries(courseCodeFilter:=clickedLabel)
                Else
                    Dim selectedCatId As Integer = If(cmbCategoryFilter.SelectedValue IsNot Nothing AndAlso TypeOf cmbCategoryFilter.SelectedValue Is Integer, Convert.ToInt32(cmbCategoryFilter.SelectedValue), 0)

                    If selectedCatId = 0 Then
                        Dim rawMonth As String = chartSubLabels(i)
                        lblPortfolioTitle.Text = $"Submitted Artifacts Records — Month: {clickedLabel}"
                        FilterPortfolioEntries(monthFilter:=rawMonth)
                    Else
                        lblPortfolioTitle.Text = $"Submitted Artifacts Records — Activity: {clickedLabel}"
                        FilterPortfolioEntries(activityTypeFilter:=clickedLabel)
                    End If
                End If
                Exit For
            End If
        Next
    End Sub

    ' -------------------------------------------------------------
    ' FILTER PORTFOLIO ENTRIES GRID
    ' -------------------------------------------------------------
    Public Sub FilterPortfolioEntries(Optional monthFilter As String = "", Optional courseCodeFilter As String = "", Optional activityTypeFilter As String = "")
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT pe.entry_id AS 'ID', pe.title AS 'Title', " &
                                          "c.category_name AS 'Skill Competency', " &
                                          "IFNULL(pe.course_code, 'N/A') AS 'Course Code', " &
                                          "at.type_name AS 'Activity Type', " &
                                          "pe.date_completed AS 'Date Completed' " &
                                          "FROM portfolio_entries pe " &
                                          "INNER JOIN categories c ON pe.category_id = c.category_id " &
                                          "INNER JOIN activity_types at ON pe.activity_type_id = at.activity_type_id " &
                                          "WHERE pe.student_number = @stud "

                    If Not String.IsNullOrEmpty(monthFilter) Then
                        query &= "AND DATE_FORMAT(pe.date_completed, '%Y-%m') = @monthFilter "
                    End If

                    If Not String.IsNullOrEmpty(courseCodeFilter) Then
                        query &= "AND pe.course_code = @courseFilter "
                    End If

                    If Not String.IsNullOrEmpty(activityTypeFilter) Then
                        query &= "AND at.type_name = @activityFilter "
                    End If

                    If currentChartViewMode = 2 AndAlso String.IsNullOrEmpty(courseCodeFilter) Then
                        query &= "AND pe.course_code IS NOT NULL AND pe.course_code <> '' AND pe.course_code <> 'N/A' "
                    ElseIf cmbCategoryFilter.SelectedIndex > 0 AndAlso String.IsNullOrEmpty(activityTypeFilter) Then
                        query &= "AND pe.category_id = @catId "
                    End If

                    If Not String.IsNullOrWhiteSpace(txtSearch.Text) AndAlso txtSearch.Text <> "Search artifact title..." Then
                        query &= "AND (pe.title LIKE @search OR pe.description LIKE @search OR pe.course_code LIKE @search) "
                    End If

                    query &= "ORDER BY pe.date_completed DESC"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)

                        If Not String.IsNullOrEmpty(monthFilter) Then cmd.Parameters.AddWithValue("@monthFilter", monthFilter)
                        If Not String.IsNullOrEmpty(courseCodeFilter) Then cmd.Parameters.AddWithValue("@courseFilter", courseCodeFilter)
                        If Not String.IsNullOrEmpty(activityTypeFilter) Then cmd.Parameters.AddWithValue("@activityFilter", activityTypeFilter)

                        If cmbCategoryFilter.SelectedIndex > 0 Then
                            cmd.Parameters.AddWithValue("@catId", cmbCategoryFilter.SelectedValue)
                        End If

                        If Not String.IsNullOrWhiteSpace(txtSearch.Text) AndAlso txtSearch.Text <> "Search artifact title..." Then
                            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")
                        End If

                        Dim adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvPortfolio.DataSource = table
                    End Using
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub

    ' -------------------------------------------------------------
    ' PDF REPORT GENERATION HANDLER WITH PERSONAL STATEMENT & DESCRIPTIONS
    ' -------------------------------------------------------------
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.FileName = $"Portfolio_Summary_{CurrentStudentNumber}.pdf"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                GenerateStudentPortfolioPDF(CurrentStudentNumber, saveFileDialog.FileName)
                MessageBox.Show("Portfolio Summary Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Process.Start(New ProcessStartInfo(saveFileDialog.FileName) With {.UseShellExecute = True})
            Catch ex As Exception
                MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub GenerateStudentPortfolioPDF(studentNumber As String, filePath As String)
        Dim doc As New iTextSharp.text.Document(PageSize.A4, 36, 36, 36, 36)
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))

        doc.Open()

        Dim primaryColor As New BaseColor(27, 59, 43)
        Dim textColor As New BaseColor(40, 40, 40)
        Dim headerFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, primaryColor)
        Dim subHeaderFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, primaryColor)
        Dim bodyFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA, 9.5F, textColor)
        Dim introFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10, textColor)
        Dim boldFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9.5F, textColor)

        Dim title As New Paragraph("E-PORTFOLIO ACCOMPLISHMENT REPORT", headerFont)
        title.Alignment = Element.ALIGN_CENTER
        doc.Add(title)

        Dim subtitle As New Paragraph("Pamantasan ng Lungsod ng Pasig — Student Academic Summary", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9, BaseColor.GRAY))
        subtitle.Alignment = Element.ALIGN_CENTER
        subtitle.SpacingAfter = 15
        doc.Add(subtitle)

        Dim line As New iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, primaryColor, Element.ALIGN_CENTER, -1)
        doc.Add(line)
        doc.Add(New Paragraph(" "))

        Using conn As MySqlConnection = database.GetConnection()
            If conn IsNot Nothing Then
                Dim queryStudent As String = "SELECT student_number, CONCAT(first_name, ' ', last_name) AS full_name, email, " &
                                             "IFNULL(college, 'College of Computer Studies (CCS)') AS college, " &
                                             "IFNULL(degree_program, 'BSIT') AS degree_program, year_level " &
                                             "FROM students WHERE student_number = @stud"
                Using cmd As New MySqlCommand(queryStudent, conn)
                    cmd.Parameters.AddWithValue("@stud", studentNumber)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim studentName As String = reader("full_name").ToString()
                            Dim studentNo As String = reader("student_number").ToString()
                            Dim college As String = reader("college").ToString()
                            Dim degreeProgram As String = reader("degree_program").ToString()
                            Dim yearLevel As String = reader("year_level").ToString()
                            Dim email As String = reader("email").ToString()

                            Dim profileTable As New PdfPTable(2)
                            profileTable.WidthPercentage = 100
                            profileTable.SetWidths(New Single() {1.5F, 3.5F})

                            AddTableRow(profileTable, "Student Name:", studentName, boldFont, bodyFont)
                            AddTableRow(profileTable, "Student No.:", studentNo, boldFont, bodyFont)
                            AddTableRow(profileTable, "College:", college, boldFont, bodyFont)
                            AddTableRow(profileTable, "Program:", degreeProgram, boldFont, bodyFont)
                            AddTableRow(profileTable, "Year Level:", yearLevel, boldFont, bodyFont)
                            AddTableRow(profileTable, "Email Address:", email, boldFont, bodyFont)

                            doc.Add(profileTable)
                            doc.Add(New Paragraph(" "))

                            ' Intro Statement Box
                            Dim introBox As New PdfPTable(1)
                            introBox.WidthPercentage = 100

                            Dim introText As String = $"I am {studentName}, a {yearLevel} {degreeProgram} student under the {college} at Pamantasan ng Lungsod ng Pasig. " &
                                                       $"This document presents my curated portfolio of academic accomplishments, technical projects, certifications, " &
                                                       $"and competency developments recorded in the E-PLP Student E-Portfolio System."

                            Dim introCell As New PdfPCell(New Phrase(introText, introFont))
                            introCell.BackgroundColor = New BaseColor(240, 248, 243)
                            introCell.BorderColor = primaryColor
                            introCell.Padding = 10.0F
                            introBox.AddCell(introCell)

                            doc.Add(introBox)
                        End If
                    End Using
                End Using

                doc.Add(New Paragraph(" "))
                doc.Add(New Paragraph("PORTFOLIO ACCOMPLISHMENTS & ARTIFACT DESCRIPTIONS", subHeaderFont))
                doc.Add(New Paragraph(" "))

                Dim queryItems As String = "SELECT pe.title, pe.description, c.category_name, IFNULL(pe.course_code, 'N/A') AS course_code, at.type_name, pe.date_completed " &
                                           "FROM portfolio_entries pe " &
                                           "INNER JOIN categories c ON pe.category_id = c.category_id " &
                                           "INNER JOIN activity_types at ON pe.activity_type_id = at.activity_type_id " &
                                           "WHERE pe.student_number = @stud ORDER BY pe.date_completed DESC"
                Using cmdItems As New MySqlCommand(queryItems, conn)
                    cmdItems.Parameters.AddWithValue("@stud", studentNumber)
                    Using readerItems As MySqlDataReader = cmdItems.ExecuteReader()

                        Dim itemsTable As New PdfPTable(5)
                        itemsTable.WidthPercentage = 100
                        itemsTable.SetWidths(New Single() {2.2F, 3.5F, 1.8F, 1.3F, 1.2F})

                        AddTableHeaderCell(itemsTable, "Artifact Title", primaryColor)
                        AddTableHeaderCell(itemsTable, "Description / Details", primaryColor)
                        AddTableHeaderCell(itemsTable, "Skill Competency", primaryColor)
                        AddTableHeaderCell(itemsTable, "Activity Type", primaryColor)
                        AddTableHeaderCell(itemsTable, "Date", primaryColor)

                        Dim hasItems As Boolean = False
                        While readerItems.Read()
                            hasItems = True

                            itemsTable.AddCell(New PdfPCell(New Phrase(readerItems("title").ToString(), boldFont)))

                            Dim descStr As String = readerItems("description").ToString()
                            If String.IsNullOrWhiteSpace(descStr) Then descStr = "No detailed description provided."
                            itemsTable.AddCell(New PdfPCell(New Phrase(descStr, bodyFont)))

                            itemsTable.AddCell(New PdfPCell(New Phrase(readerItems("category_name").ToString(), bodyFont)))
                            itemsTable.AddCell(New PdfPCell(New Phrase(readerItems("type_name").ToString(), bodyFont)))

                            Dim dateVal As String = ""
                            If Not IsDBNull(readerItems("date_completed")) Then
                                dateVal = Convert.ToDateTime(readerItems("date_completed")).ToString("yyyy-MM-dd")
                            End If
                            itemsTable.AddCell(New PdfPCell(New Phrase(dateVal, bodyFont)))
                        End While

                        If Not hasItems Then
                            Dim emptyCell As New PdfPCell(New Phrase("No accomplishments logged yet.", bodyFont))
                            emptyCell.Colspan = 5
                            emptyCell.HorizontalAlignment = Element.ALIGN_CENTER
                            emptyCell.Padding = 10.0F
                            itemsTable.AddCell(emptyCell)
                        End If

                        doc.Add(itemsTable)
                    End Using
                End Using
            End If
        End Using

        doc.Add(New Paragraph(" "))
        Dim footer As New Paragraph($"Report Generated on: {DateTime.Now:MMMM dd, yyyy hh:mm tt} | E-PLP E-Portfolio System", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 8, BaseColor.GRAY))
        footer.Alignment = Element.ALIGN_RIGHT
        doc.Add(footer)

        doc.Close()
    End Sub

    Private Sub AddTableRow(table As PdfPTable, label As String, value As String, labelFont As iTextSharp.text.Font, valueFont As iTextSharp.text.Font)
        Dim cellLabel As New PdfPCell(New Phrase(label, labelFont))
        cellLabel.Border = iTextSharp.text.Rectangle.NO_BORDER
        cellLabel.PaddingBottom = 4.0F
        Dim cellValue As New PdfPCell(New Phrase(value, valueFont))
        cellValue.Border = iTextSharp.text.Rectangle.NO_BORDER
        cellValue.PaddingBottom = 4.0F
        table.AddCell(cellLabel)
        table.AddCell(cellValue)
    End Sub

    Private Sub AddTableHeaderCell(table As PdfPTable, headerText As String, bgColor As BaseColor)
        Dim cellFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9.5F, BaseColor.WHITE)
        Dim cell As New PdfPCell(New Phrase(headerText, cellFont))
        cell.BackgroundColor = bgColor
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.Padding = 6.0F
        table.AddCell(cell)
    End Sub

End Class