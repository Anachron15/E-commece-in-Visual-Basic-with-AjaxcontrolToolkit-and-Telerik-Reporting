Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity

Public Class User
    <Key(), Column(Order:=1)>
    Public Property userId As Guid
    Public Property userFirstName As String
    Public Property userLastName As String
    Public Property userBirthDay As DateTime
    Public Property userRole As String
    Public Property userStatus As String
    Public Property userGender As String
    Public Property userEmail As String
    Public Property userPassword As String

End Class
