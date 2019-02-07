Public Class ProductRepository
    Shared Function getProducts() As List(Of vwProduct)
        Using context As New storeContext
            Return (From p In context.Product
                    Select New vwProduct With
                        {
                            .productId = p.productId,
                            .productName = p.productName,
                            .productStatus = p.productStatus,
                            .productPrice = p.productPrice,
                            .productDescription = p.productDescription,
                            .productCategoryId = p.productCategoryId,
                            .productImage = p.productImage
                        }).ToList()
        End Using
    End Function
    Shared Function getProductsByCategoryId(ByVal CategoryId As Guid) As List(Of vwProduct)
        Using context As New storeContext
            Return (From p In context.Product
                    Where p.productCategoryId = CategoryId
                    Select New vwProduct With {.productId = p.productId,
                            .productImage = p.productImage,
                            .productName = p.productName,
                            .productPrice = p.productPrice,
                            .productQuantity = p.productQuantity,
                            .productDescription = p.productDescription,
                            .productStatus = p.productStatus
                    }).ToList
        End Using
    End Function
    Shared Function getProductsById(ByVal productId As Guid) As List(Of vwProduct)
        Using context As New storeContext
            Return (From p In context.Product
                    Where p.productId = productId
                    Select New vwProduct With {
                         .productId = productId,
                         .productCategoryName = p.productName,
                         .productDescription = p.productDescription,
                         .productCategoryId = p.productCategoryId,
                         .productPrice = p.productPrice,
                         .productImage = p.productImage,
                         .productName = p.productName,
                         .productQuantity = p.productQuantity,
                         .productStatus = p.productStatus
                    }).ToList
        End Using
    End Function
    Sub insertProduct(ByVal productId As Guid, ByVal productName As String, ByVal productPrice As Double, ByVal productStatus As String)
        Using context As New storeContext
            Dim prodObj = New Product With {.productId = productId, .productName = productName, .productPrice = productPrice, .productStatus = productStatus}
            context.Product.Add(prodObj)
            context.SaveChanges()
        End Using
    End Sub

    Public Shared Sub updateProduct(ByVal productId As Guid, ByVal productName As String, ByVal productPrice As Double, ByVal productStatus As String)
        Using context As New storeContext          '
            Dim prodObj = context.Product.SingleOrDefault(Function(p As Product) p.productId = productId)
            If (Not (prodObj) Is Nothing) Then
                prodObj.productName = productName
                prodObj.productPrice = productPrice
                prodObj.productStatus = productStatus
                context.SaveChanges()
            End If
        End Using
    End Sub
    Sub deleteProduct(ByVal productId As Guid)
        Using context As New storeContext
            Dim prodObj = context.Product.SingleOrDefault(Function(p As Product) p.productId = productId)
            If (Not (prodObj) Is Nothing) Then
                context.Product.Remove(prodObj)
                context.SaveChanges()
            End If
        End Using
    End Sub

End Class
