Imports MySql.Data.MySqlClient

Module database
    ' Connection configuration targeting eportfoliodb
    Private Const ConnectionString As String = "Server=localhost;Database=eportfoliodb;Uid=root;Pwd=;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(ConnectionString)
        Try
            conn.Open()
            Return conn
        Catch ex As MySqlException
            MessageBox.Show("Database Connection Error: " & ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
End Module