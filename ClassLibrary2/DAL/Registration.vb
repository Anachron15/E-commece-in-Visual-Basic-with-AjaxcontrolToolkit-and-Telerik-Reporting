
Public Class Registration
    Public Shared Function register(ByVal firstName As String, ByVal lastName As String, ByVal email As String, ByVal password As String, ByVal gender As String, ByVal bday As DateTime) As User
        Using context As New storeContext
            Dim user = context.User.FirstOrDefault(Function(u As User) u.userEmail = email And u.userPassword = password)
            If ((user) Is Nothing) Then
                Dim newUser As New User
                Dim g As Guid
                ' Create and display the value of two GUIDs.
                g = Guid.NewGuid()
                newUser.userId = g
                newUser.userFirstName = firstName
                newUser.userLastName = lastName
                newUser.userPassword = password
                newUser.userBirthDay = bday
                newUser.userEmail = email
                newUser.userRole = "customer"
                newUser.userStatus = "active"
                newUser.userGender = gender

                context.User.Add(newUser)
                context.SaveChanges()

                Return newUser
            Else
                Return user
            End If
        End Using
    End Function
End Class
