Public Delegate Function filterDelegate(ByVal filter As String) As List(Of vwOrders)

Public Class orderLogicLayer : Inherits OrderRepository

    Public Shared Function getOrders() As List(Of vwOrders)
        Using db As New storeContext
            Return (From order In db.Order
                    Select New vwOrders With
                        {.User = If((From u In db.User Where u.userId = order.userId Select u.userFirstName & " " & u.userLastName).FirstOrDefault, ""),
                           .ProductPrice = (From p In db.Product Where p.productId = order.ProductId Select p.productPrice).FirstOrDefault,
                           .ProductName = (From p In db.Product Where p.productId = order.ProductId Select p.productName).FirstOrDefault,
                           .ProductStatus = (From p In db.Product Where p.productId = order.ProductId Select p.productStatus).FirstOrDefault,
                            .ProductQuantity = (From p In db.Product Where p.productId = order.ProductId Select p.productQuantity).FirstOrDefault
                           }).ToList
        End Using
    End Function

    Public Shared Function checkIfProductIsOrdered(ByVal id As Guid) As List(Of vwProduct)
        Using context As New storeContext
            Return (From o In context.Order
                    From p In context.Product
                    Where o.ProductId = id
                    Select New vwProduct With
                       {
                       .productId = p.productId,
                       .productCategoryId = p.productCategoryId,
                       .productDescription = p.productDescription,
                       .productName = p.productName,
                       .productPrice = p.productPrice,
                       .productCategoryName = (From category In context.ProductCategory Where p.productCategoryId = category.productCategoryId Select category.productCategoryName).FirstOrDefault,
                        .productImage = p.productImage,
                       .productQuantity = p.productQuantity,
                       .productStatus = p.productStatus
                        }).ToList

        End Using
    End Function






End Class
