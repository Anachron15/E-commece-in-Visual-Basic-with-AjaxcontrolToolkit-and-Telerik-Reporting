Public Class productRepository : Inherits storeContext


    Function getProducts() As List(Of Product)
        Using context As New storeContext
            Return context.Product.ToList
        End Using
    End Function



End Class
