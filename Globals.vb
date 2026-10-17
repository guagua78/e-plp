Module Globals
    ' Active Session Variables for Logged-In Student
    Public CurrentUserID As Integer = 0
    Public CurrentStudentNumber As String = ""
    Public CurrentUserFullName As String = ""
    Public CurrentUserEmail As String = ""
    Public CurrentUserCollege As String = ""
    Public CurrentUserProgram As String = ""
    Public CurrentUserYearLevel As String = ""
    Public CurrentUserRole As String = "Student"

    ' Routine to clear session state on Logout
    Public Sub ClearSession()
        CurrentUserID = 0
        CurrentStudentNumber = ""
        CurrentUserFullName = ""
        CurrentUserEmail = ""
        CurrentUserCollege = ""
        CurrentUserProgram = ""
        CurrentUserYearLevel = ""
        CurrentUserRole = ""
    End Sub
End Module