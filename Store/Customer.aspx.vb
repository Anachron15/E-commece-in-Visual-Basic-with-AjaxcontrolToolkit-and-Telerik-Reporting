Imports ClassLibrary2
Imports AjaxControlToolkit
Public Class Customer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            sidebarControl.LoadProductCategory()
        End If
    End Sub
    Private Sub imgBtnLogout_Click(sender As Object, e As ImageClickEventArgs) Handles imgBtnLogout.Click
        Response.Redirect("~/Default.aspx")
    End Sub
    Private Sub sidebarControl_ShowProductDetails(catid As Guid) Handles sidebarControl.ShowProductDetails
        ProductControl.LoadGridData(catid)
    End Sub
    Private Sub ProductControl_showProductsByIdList(IdList As List(Of Guid)) Handles ProductControl.showProductsByIdList
        ProductControl.LoadCart(IdList)
    End Sub
End Class