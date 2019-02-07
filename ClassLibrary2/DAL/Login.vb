
Public Class Login
    Public Shared Function login(ByVal email As String, ByVal password As String) As User
        Using context As New storeContext
            Return context.User.FirstOrDefault(Function(u As User) u.userEmail = email And u.userPassword = password)
        End Using
    End Function
End Class
