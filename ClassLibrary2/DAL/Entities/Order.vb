Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Order
    <Key(),
    Column(Order:=1)>
    Property orderId As Guid
    Property userId As Guid
    Property ProductId As Guid

    Public orderDate As DateTime

End Class
