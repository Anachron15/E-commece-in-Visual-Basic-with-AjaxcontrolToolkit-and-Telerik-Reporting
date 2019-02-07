Imports ClassLibrary2

Public Class ProductCategoryClient
    Public Function getProductCategories() As List(Of vwProductCategory)
        Return ProductCategoryLogicLayer.getProductCategories()
    End Function
End Class
