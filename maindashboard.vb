Imports MySql.Data.MySqlClient

Public Class maindashboard

    Private Sub frmStudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Load active student identity from Globals.vb
        lblHeaderStudentInfo.Text = $"{CurrentUserFullName} ({CurrentStudentNumber})"
        lblNameVal.Text = CurrentUserFullName
        lblStudentNumVal.Text = $"Student No: {CurrentStudentNumber}"
        lblEmailVal.Text = $"Webmail: {CurrentUserEmail}"
        lblCollegeVal.Text = $"College: {CurrentUserCollege}"
        lblProgramVal.Text = $"Program: {CurrentUserProgram} ({CurrentUserYearLevel})"

        ' 2. Load dashboard statistics, summary progress, and artifacts
        RefreshDashboardData()
    End Sub

    Public Sub RefreshDashboardData()
        UpdateCounters()
        LoadCompetencyProgress()
        LoadPortfolioEntries()
    End Sub

    ' Update Summary Counter Cards
    Private Sub UpdateCounters()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT " &
                                          "COUNT(*) AS TotalEntries, " &
                                          "COUNT(DISTINCT category_id) AS CoveredCategories " &
                                          "FROM portfolio_entries WHERE student_number = @stud"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                lblTotalVal.Text = reader("TotalEntries").ToString()
                                lblCategoriesVal.Text = $"{reader("CoveredCategories")} / 7"
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading counters: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load 7 Competency Categories Progress Table
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
            MessageBox.Show("Error loading competency progress: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load Portfolio Entries Grid
    Private Sub LoadPortfolioEntries()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT pe.entry_id AS 'ID', pe.title AS 'Title', " &
                                          "c.category_name AS 'Category', at.type_name AS 'Activity Type', " &
                                          "pe.date_completed AS 'Date Completed' " &
                                          "FROM portfolio_entries pe " &
                                          "INNER JOIN categories c ON pe.category_id = c.category_id " &
                                          "INNER JOIN activity_types at ON pe.activity_type_id = at.activity_type_id " &
                                          "WHERE pe.student_number = @stud " &
                                          "ORDER BY pe.created_at DESC"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", CurrentStudentNumber)
                        Dim adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvPortfolio.DataSource = table
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading portfolio entries: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Open Add Entry Dialog
    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        Dim addEntryForm As New frmAddEntry()
        If addEntryForm.ShowDialog() = DialogResult.OK Then
            RefreshDashboardData()
        End If
    End Sub

    ' Logout Action
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Globals.ClearSession()
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

End Class