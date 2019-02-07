Imports ClassLibrary2
Public Class mycontrol
    Inherits System.Web.UI.UserControl

    Event ShowProductDetails(catid As Guid)

    Sub LoadProductCategory()
        Dim lst = ProductCategoryLogicLayer.getProductCategories()
        If lst.Count > 0 Then
            RaiseEvent ShowProductDetails(lst(0).productCategoryId)
        End If
        gvProductCategory.DataSource = lst
        gvProductCategory.DataBind()
    End Sub

    Protected Sub gvProductCategory_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        If TypeOf (e.CommandSource) Is LinkButton Then
            Dim btn As LinkButton = e.CommandSource
            Select Case btn.ID
                Case "lbSelectCategory"
                    RaiseEvent ShowProductDetails(Guid.Parse(e.CommandArgument))
            End Select
        End If
    End Sub
End Class