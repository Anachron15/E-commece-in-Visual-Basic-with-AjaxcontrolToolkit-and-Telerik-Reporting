Public Class OrderRepository

    'Public Shared Function getOrderByProductCategory(ByVal category As String) As Order

    'End Function

    'Public Shared Function getOrders() As List(Of vwOrders)
    '    Using db As New storeContext
    '        Return (From order In db.Order
    '                Select New vwOrders With
    '                    {.User = If((From u In db.User Where u.userId = order.userId Select u.userFirstName & " " & u.userLastName).FirstOrDefault, ""),
    '                       .ProductName = (From p In db.Product Where p.productId = order.ProductId Select p.productName).FirstOrDefault,
    '                       .ProductStatus = (From p In db.Product Where p.productId = order.ProductId Select p.productStatus).FirstOrDefault}).ToList

    '    End Using
    'End Function

    Function getOrderById(ByVal orderId As Guid) As Order
        Using context As New storeContext
            Return context.Order.Where(Function(p As Order) p.orderId = orderId)
        End Using
    End Function
    Public Shared Sub insertOrder(ByVal orderId As Guid, ByVal userId As Guid, ByVal productId As Guid)
        Using context As New storeContext
            Dim orderObj = New Order With {.orderId = orderId, .userId = userId, .ProductId = productId}
            context.Order.Add(orderObj)
            context.SaveChanges()
        End Using
    End Sub

    Sub updateOrder(ByVal order As Order)
        Using context As New storeContext
            Dim orderObj = context.Order.SingleOrDefault(Function(p As Order) p.orderId = order.orderId)
            If (Not (orderObj) Is Nothing) Then
                orderObj.orderId = order.orderId
                orderObj.userId = order.userId
                orderObj.ProductId = order.ProductId
                context.SaveChanges()
            End If
        End Using
    End Sub

    Sub deleteOrder(ByVal orderId As Guid)
        Using context As New storeContext
            Dim orderObj = context.Order.SingleOrDefault(Function(p As Order) p.orderId = orderId)
            'returns a single item.
            If (Not (orderObj) Is Nothing) Then
                context.Order.Remove(orderObj)
                context.SaveChanges()
            End If
        End Using
    End Sub
End Class
