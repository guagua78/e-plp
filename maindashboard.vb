Imports System.IO
Imports MySql.Data.MySqlClient

Public Class maindashboard

    Private Sub maindashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Sidebar Brand and Student Identity Header
        lblGreeting.Text = "Hello, " & CurrentUserFullName & "!"

        ' Ensure sub-menu panel sits properly inside container
        pnlCompetenciesSubMenu.BringToFront()

        btnAddEntry.BringToFront()
        pnlCompetenciesSubMenu.BringToFront()


        ' Set default dropdown filter option
        If cmbCategoryFilter.Items.Count > 0 Then
            cmbCategoryFilter.SelectedIndex = 0 ' Selects "All Skill Competencies"
        End If

        ' Populate Category Dropdown and Refresh Data
        PopulateCategoryFilter()
        RefreshDashboard()
    End Sub
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
    ' SIDEBAR COLLAPSED / EXPANDED TOGGLE LOGIC
    ' -------------------------------------------------------------
    Private Sub btnToggleCompetencies_Click(sender As Object, e As EventArgs) Handles btnToggleCompetencies.Click
        ' Show or hide the sub-menu panel
        pnlCompetenciesSubMenu.Visible = Not pnlCompetenciesSubMenu.Visible
    End Sub

    ' -------------------------------------------------------------
    ' POPULATE CATEGORY FILTER DROPDOWN
    ' -------------------------------------------------------------
    Private Sub PopulateCategoryFilter()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim catCmd As New MySqlCommand("SELECT category_id, category_name FROM categories ORDER BY category_name ASC", conn)
                    Dim catAdapter As New MySqlDataAdapter(catCmd)
                    Dim catTable As New DataTable()
                    catAdapter.Fill(catTable)

                    ' Add "All Categories" default option at position 0
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
            ' Silently catch on initial load
        End Try
    End Sub

    ' -------------------------------------------------------------
    ' SIDEBAR NAVIGATION BUTTON ACTIONS
    ' -------------------------------------------------------------

    ' Main Dashboard Overview Tab
    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        If cmbCategoryFilter.Items.Count > 0 Then cmbCategoryFilter.SelectedIndex = 0
        txtSearch.Clear()
        FilterPortfolioEntries()
    End Sub

    ' Filter Table by Specific Skill Competency Sub-Buttons
    Private Sub FilterByCompetencyName(categoryName As String)
        txtSearch.Clear()

        ' Select matching option in dropdown to trigger real-time filtering
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
    ' SEARCH & DROPDOWN FILTER EVENT HANDLERS
    ' -------------------------------------------------------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterPortfolioEntries()
    End Sub

    Private Sub cmbCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoryFilter.SelectedIndexChanged
        FilterPortfolioEntries()
    End Sub

    ' -------------------------------------------------------------
    ' DOUBLE-CLICK ROW TO VIEW ENTRY DETAILS & PROOF FILE
    ' -------------------------------------------------------------
    Private Sub dgvPortfolio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPortfolio.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedId As Integer = Convert.ToInt32(dgvPortfolio.Rows(e.RowIndex).Cells("ID").Value)
            Dim viewForm As New frmViewEntry()
            viewForm.SelectedEntryID = selectedId

            ' Open modal and refresh dashboard as soon as it closes
            If viewForm.ShowDialog() = DialogResult.OK Then
                RefreshDashboard()
            End If
        End If
    End Sub

    ' Edit Profile Modal
    Private Sub btnNavEditProfile_Click(sender As Object, e As EventArgs) Handles btnNavEditProfile.Click
        Dim editForm As New frmEditProfile()
        If editForm.ShowDialog() = DialogResult.OK Then
            lblGreeting.Text = "Hello, " & CurrentUserFullName & "!"
        End If
    End Sub

    ' Logout Handler
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Globals.ClearSession()
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    ' -------------------------------------------------------------
    ' DASHBOARD DATA QUERYING
    ' -------------------------------------------------------------
    Public Sub RefreshDashboard()
        LoadCompetencyProgress()
        FilterPortfolioEntries()
    End Sub

    Private Sub LoadCompetencyProgress()
        Try
            ' Clear existing card blocks
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
                                Dim countLogged As Integer = Convert.ToInt32(rdr("total_logged"))

                                ' Create Card Block Container
                                Dim pnlCard As New Panel() With {
                                .Size = New Size(170, 75),
                                .Margin = New Padding(6),
                                .BorderStyle = BorderStyle.FixedSingle,
                                .Tag = catName
                            }

                                ' Active/Inactive Styling
                                If countLogged > 0 Then
                                    pnlCard.BackColor = Color.FromArgb(240, 248, 243) ' Light Green Tint
                                Else
                                    pnlCard.BackColor = Color.FromArgb(250, 250, 250) ' Soft Gray
                                End If

                                ' Competency Title Label
                                Dim lblTitle As New Label() With {
                                .Text = catName,
                                .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                                .ForeColor = Color.FromArgb(10, 40, 25),
                                .Location = New Point(10, 10),
                                .Size = New Size(150, 20),
                                .AutoEllipsis = True
                            }

                                ' Logged Count Badge Label
                                Dim lblCount As New Label() With {
                                .Text = If(countLogged = 1, "1 Record Logged", $"{countLogged} Records Logged"),
                                .Font = New Font("Segoe UI", 8.0F, If(countLogged > 0, FontStyle.Bold, FontStyle.Regular)),
                                .ForeColor = If(countLogged > 0, Color.FromArgb(24, 88, 54), Color.Gray),
                                .Location = New Point(10, 38),
                                .Size = New Size(150, 20)
                            }

                                ' Add controls to block panel
                                pnlCard.Controls.Add(lblTitle)
                                pnlCard.Controls.Add(lblCount)

                                ' Optional Click-to-Filter Action when clicking a block
                                AddHandler pnlCard.Click, Sub(s, e) FilterByCompetencyName(catName)
                                AddHandler lblTitle.Click, Sub(s, e) FilterByCompetencyName(catName)
                                AddHandler lblCount.Click, Sub(s, e) FilterByCompetencyName(catName)

                                ' Add panel block to flow layout
                                flpProgressCards.Controls.Add(pnlCard)
                            End While
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub FilterPortfolioEntries()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT pe.entry_id AS 'ID', pe.title AS 'Title', " &
                                          "c.category_name AS 'Skill Competency', at.type_name AS 'Activity Type', " &
                                          "pe.date_completed AS 'Date Completed' " &
                                          "FROM portfolio_entries pe " &
                                          "INNER JOIN categories c ON pe.category_id = c.category_id " &
                                          "INNER JOIN activity_types at ON pe.activity_type_id = at.activity_type_id " &
                                          "WHERE pe.student_number = @stud "

                    If cmbCategoryFilter.SelectedIndex > 0 Then
                        query &= "AND pe.category_id = @catId "
                    End If

                    If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                        query &= "AND (pe.title LIKE @search OR pe.description LIKE @search) "
                    End If

                    query &= "ORDER BY pe.date_completed DESC"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)

                        If cmbCategoryFilter.SelectedIndex > 0 Then
                            cmd.Parameters.AddWithValue("@catId", cmbCategoryFilter.SelectedValue)
                        End If

                        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
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

End Class