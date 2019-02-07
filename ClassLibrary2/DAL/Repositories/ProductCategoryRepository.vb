

Public Class ProductCategoryRepository

    Public Shared Function getProductCategories() As List(Of vwProductCategory)
        Using context As New storeContext
            Return (From c In context.ProductCategory
                    Select New vwProductCategory With {
                        .productCategoryId = c.productCategoryId,
                        .productCategoryName = c.productCategoryName
                        }).ToList()
        End Using
    End Function
End Class
