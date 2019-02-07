Public Delegate Function delegateGetProductById(ByVal filter As Guid) As List(Of vwProduct)
Public Class ProductLogicLayer : Inherits ProductRepository

    Public Shared Function getProductsByCategId(ByVal ProductCategoryId As Guid) As List(Of vwProduct)
        Return ProductRepository.getProductsByCategoryId(ProductCategoryId)
    End Function
    Public Shared Function getProductDetails() As List(Of vwProduct)
        Return ProductRepository.getProducts()
    End Function
    Public Shared Function getProductDetailsById(ByVal Id As Guid)
        Return ProductRepository.getProductsById(Id)
    End Function

End Class
