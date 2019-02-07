Imports System
Imports System.Data.Entity
Imports ClassLibrary2
Imports AjaxControlToolkit
Imports Telerik

Public Class storeMaster
    Inherits System.Web.UI.MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Application("numberOfUsers") += 1
        gvProducts.DataSource = ProductLogicLayer.getProducts()
        gvProducts.DataBind()
    End Sub


    Private Sub btnRegistrationOk_Click(sender As Object, e As EventArgs) Handles btnRegistrationOk.Click

        If txtRegistrationPassword.Text = txtRegistrationConfirmPassword.Text Then
            Dim user = Registration.register(txtRegistrationFirstName.Text, txtRegistrationLastName.Text, txtRegistrationEmail.Text, txtRegistrationPassword.Text, radioGender.SelectedValue, txtDate.Text)
            If ((user) Is Nothing) Then
                lblName.Text = "User already exist."
            Else
                ViewState("userFname") = user.userFirstName
                ViewState("userLname") = user.userLastName
                Session("sessionId") = user.userId
                Application("numberOfUsers") += 1
                lblName.Text = "Registration successful, welcome " + ViewState("userFname") + " " + ViewState("userLname")
                panelRegistration.Visible = False
                btnLogin.Visible = False
                btnLogout.Visible = True
                pnlProduct.Visible = True
                Application("numberOfUsers") += 1
                lblNumberOfUsers.Text = "Number of users:" + Application("numberOfUsers").ToString()

                Dim cookie As HttpCookie = New HttpCookie("userEmail")
                cookie("userEmail") = txtRegistrationEmail.Text
                cookie.Expires = DateTime.Now.AddDays(1)
                Response.Cookies.Add(cookie)

                Response.Redirect("~/Customer.aspx")
            End If
        Else
            lblName.Text = "Passwords did not match, please try again."
        End If

    End Sub
    Protected Sub calBirthDay_SelectionChanged(sender As Object, e As EventArgs)
        txtDate.Text = calBirthDay.SelectedDate.ToString("d")
    End Sub
    Protected Sub lnkReport_Click(sender As Object, e As EventArgs)

        Response.Clear()
        Response.Write(orderReportClient.getOrderedProductForReport())
        Response.ContentType = "Application/PDF"
        Response.AppendHeader("Content-Disposition", "attachment; filename=orderReport.PDF")

        Response.BinaryWrite(orderReportClient.getOrderedProductForReport())
        Response.Flush()
        Response.End()
    End Sub
    Protected Sub lbInsert_Click(sender As Object, e As EventArgs)
        'Try
        '    Dim lblId As Label = gvProducts.FooterRow.FindControl("lblProductIdFooter")
        '    Dim txtName As TextBox = gvProducts.FooterRow.FindControl("txtProductName")
        '    Dim txtPrice As TextBox = gvProducts.FooterRow.FindControl("txtProductPrice")
        '    Dim txtStatus As TextBox = gvProducts.FooterRow.FindControl("txtProductStatus")

        '    ObjectDataSource2.InsertParameters("productId").DefaultValue = Guid.NewGuid().ToString()
        '    ObjectDataSource2.InsertParameters("productName").DefaultValue = txtName.Text
        '    ObjectDataSource2.InsertParameters("productPrice").DefaultValue = txtPrice.Text
        '    ObjectDataSource2.InsertParameters("productStatus").DefaultValue = txtStatus.Text

        '    ObjectDataSource2.Insert()
        'Catch ex As Exception
        '    Response.Write(ex.Message)
        'End Try

    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs)
        panelRegistration.Visible = True
    End Sub

    Protected Sub btnRegister_Click(sender As Object, e As EventArgs)
        panelRegistration.Visible = True
    End Sub

    Protected Sub btnOkay_Click1(sender As Object, e As EventArgs)

        Dim User = Login.login(txtLoginEmail.Text, txtLoginPassword.Text)
        If (Not (User) Is Nothing) Then
            If User.userRole = "admin" Then
                ViewState("userName") = User.userFirstName
                ViewState("lastName") = User.userLastName

                lblName.Text = "Welcome admin:" & ViewState("userName") & " " & ViewState("lastName")
                pnlProduct.Visible = True
                panelRegistration.Visible = False
                btnLogin.Visible = False
                btnLogout.Visible = True
                loginPanel.Visible = False

                Session("userId") = User.userId
                Application("numberOfUsers") += 1
                lblNumberOfUsers.Text = vbNewLine + "Number of users online: " + Application("numberOfUsers").ToString()

            Else

                Dim cookie As HttpCookie = New HttpCookie("userEmail")
                cookie("userEmail") = User.userEmail
                cookie.Expires = DateTime.Now.AddDays(1)
                Response.Cookies.Add(cookie)

                ViewState("userName") = User.userFirstName
                ViewState("lastName") = User.userLastName
                Session("userId") = User.userId
                Application("numberOfUsers") += 1

                lblName.Text = "Welcome: " & ViewState("userName") & " " & ViewState("lastName")
                pnlProduct.Visible = True
                'gvProducts.Columns(0).Visible = False
                'gvProducts.FooterRow.Visible = False
                updateLoginPanel.Visible = False

                btnLogin.Visible = False
                loginPanel.Visible = False
                btnLogout.Visible = True

                Response.Redirect("~/Customer.aspx")


            End If
        Else
            lblName.Text = "User does not exist, please try again."
        End If

    End Sub

    Protected Sub btnLogout_Click(sender As Object, e As EventArgs)
        Session("userId") = ""
        Application("numberOfUsers") = 0
        Response.Redirect("~/Default.aspx")
    End Sub

    Private Sub gvProducts_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvProducts.RowCommand
        If TypeOf (e.CommandSource) Is LinkButton Then
            Dim btn As LinkButton = e.CommandSource
            Select Case btn.ID
                Case "lbEdit"

                    Dim product = orderLogicLayer.checkIfProductIsOrdered(Guid.Parse(e.CommandArgument.ToString()))

                    'Dim txtName As TextBox = gvProducts.FindControl("txtProductName")
                    'txtName.Text = "Test"

                    'Dim modal As New AjaxControlToolkit.ModalPopupExtender
                    'modal.ID = "ModalPopUpExtender2"
                    'modal.TargetControlID = "lbEdit"
                    'modal.PopupControlID = "udpateProductPanel"
                    'modal.PopupDragHandleControlID = "updateHeader"
                    'modal.OkControlID = "btnUpdateOk"
                    'modal.CancelControlID = "btnUpdateCancel"
                    'modal.DropShadow = True
                    'modal.Show()




            End Select
        End If
    End Sub

    'Protected Sub LinkButton1_Click1(sender As Object, e As EventArgs)
    '    Try
    '        Dim lblId As Label = gvProducts.FooterRow.FindControl("lblProductId")
    '        Dim txtName As TextBox = gvProducts.FooterRow.FindControl("txtProductName")
    '        Dim txtPrice As TextBox = gvProducts.FooterRow.FindControl("txtProductPrice")
    '        Dim txtStatus As TextBox = gvProducts.FooterRow.FindControl("txtProductStatus")

    '        ObjectDataSource2.UpdateParameters("productId").DefaultValue = Guid.NewGuid().ToString()
    '        ObjectDataSource2.UpdateParameters("productName").DefaultValue = txtName.Text
    '        ObjectDataSource2.UpdateParameters("productPrice").DefaultValue = txtPrice.Text
    '        ObjectDataSource2.UpdateParameters("productStatus").DefaultValue = txtStatus.Text

    '        ObjectDataSource2.Update()

    '    Catch ex As Exception
    '        Response.Write(ex.Message)
    '    End Try
    'End Sub
End Class