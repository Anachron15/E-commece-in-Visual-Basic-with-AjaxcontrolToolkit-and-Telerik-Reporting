
Imports System.ComponentModel

<DataObject>
<Serializable>
Public Class vwOrders
    Property User As String
    Property ProductName As String
    Property ProductPrice As String
    Property ProductStatus As String
    Property ProductQuantity As Double
    Property ProductOrderDate As DateTime
    Property OrderTotalPrice As Double

    Shared Function getProductsForReport() As List(Of vwOrders)
        Return orderLogicLayer.getOrders()
    End Function

End Class
