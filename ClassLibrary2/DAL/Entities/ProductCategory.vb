Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class ProductCategory
    <Key(),
   Column(Order:=1)>
    Property productCategoryId As Guid
    Property productCategoryName As String

End Class
