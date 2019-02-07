Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class ProductAttribute
    <Key(),
  Column(Order:=1)>
    Property productAttributeId As Guid
    Property productAttributeName As String
    Property productAttributeValue As String
End Class
