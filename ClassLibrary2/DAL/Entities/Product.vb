Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity

Public Class Product
    <Key(),
     Column(Order:=1)>
    Public Property productId As Guid
    Public Property productImage As String
    Public Property productName As String
    Public Property productPrice As Double
    Public Property productQuantity As Double
    Public Property productStatus As String
    Public Property productCategoryId As Guid
    Public Property productDescription As String


End Class
