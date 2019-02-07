Public Class ProductCategoryLogicLayer : Inherits ProductCategoryRepository

    Public Shared Function getCategories() As List(Of vwProductCategory)
        Return ProductCategoryRepository.getProductCategories()
    End Function
End Class
