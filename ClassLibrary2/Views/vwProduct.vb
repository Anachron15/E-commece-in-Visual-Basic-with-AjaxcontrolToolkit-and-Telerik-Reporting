
Imports System.ComponentModel

<DataObject>
<Serializable>
Public Class vwProduct
    Public Property productId As Guid

    Public Property productCategoryId As Guid
    Public Property productImage As String
    Public Property productName As String
    Public Property productPrice As Double
    Public Property productQuantity As Double
    Public Property productStatus As String
    Public Property productCategoryName As String
    Public Property productDescription As String
End Class
