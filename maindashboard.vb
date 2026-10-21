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

        ' Populate Category Dropdown and Refresh Data
        PopulateCategoryFilter()
        RefreshDashboard()
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
            viewForm.ShowDialog()
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
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT c.category_name AS 'Skill Competency', " &
                                          "COUNT(pe.entry_id) AS 'Records Logged' " &
                                          "FROM categories c " &
                                          "LEFT JOIN portfolio_entries pe ON c.category_id = pe.category_id AND pe.student_number = @stud " &
                                          "GROUP BY c.category_id, c.category_name"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)
                        Dim adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvProgressSummary.DataSource = table
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