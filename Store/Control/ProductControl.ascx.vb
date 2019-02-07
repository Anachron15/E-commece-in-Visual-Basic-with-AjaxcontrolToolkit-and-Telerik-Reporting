Imports ClassLibrary2
Public Class ProductControl
    Inherits System.Web.UI.UserControl

    Event displayProducts(ByVal Id As Guid)
    Dim del As New delegateGetProductById(AddressOf fillProductByCategoryId)
    Dim listOfId As New List(Of Guid)


    Event showProductsByIdList(ByVal IdList As List(Of Guid)) 'displays the products based on lstOfProductDetails


    Sub LoadCart(ByVal lstOfId As List(Of Guid))
        Dim lst As New List(Of vwProduct)
        For Each productId In lstOfId
            lst = ProductLogicLayer.getProductsById(productId)
        Next
        ViewState("productDetail") = lst
        gvProducts.DataSource = ViewState("productDetail")
        gvProducts.DataBind()
    End Sub
    Sub LoadGridData(key As Guid)
        gvProducts.DataSource = del(key)
        gvProducts.DataBind()
    End Sub
    Public Function fillProductByCategoryId(ByVal id As Guid) As List(Of vwProduct)
        Return ProductLogicLayer.getProductsByCategoryId(id)
    End Function
    Protected Sub imgShop_Click(sender As Object, e As ImageClickEventArgs) Handles imgShop.Click
        Dim productList = ProductLogicLayer.getProductDetails()
        If productList.Count > 0 Then
            RaiseEvent displayProducts(productList(0).productCategoryId)
        End If
        gvProducts.DataSource = productList
        gvProducts.DataBind()
    End Sub
    Private Sub gvProducts_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvProducts.RowCommand
        If TypeOf (e.CommandSource) Is ImageButton Then
            Dim btn As ImageButton = e.CommandSource
            Select Case btn.ID
                Case "btnAddToCart"

                    listOfId.Add(Guid.Parse(e.CommandArgument.ToString))
                    Session("productIdList") = listOfId
            End Select
        End If
    End Sub

    Private Sub imgCart_Click(sender As Object, e As ImageClickEventArgs) Handles imgCart.Click

        RaiseEvent showProductsByIdList(Session("productIdList"))

    End Sub
End Class