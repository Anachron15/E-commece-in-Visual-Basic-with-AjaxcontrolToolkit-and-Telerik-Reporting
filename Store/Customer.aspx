<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Customer.aspx.vb" Inherits="Store.Customer"  %>

<%@ Register Src="~/Control/sidebarControl.ascx" TagPrefix="uc1" TagName="sidebarControl" %>
<%@ Register Src="~/Control/ProductControl.ascx" TagPrefix="uc1" TagName="ProductControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 bg-success text-primary">
                    <asp:Label ID="lblKey" runat="server" CssClass="float-left"></asp:Label>
                   <%-- <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/shopping-cart.png" />  --%>      
                    <asp:Label ID="lblLogout" runat="server" Text="Logout" ForeColor="White" CssClass="float-right"></asp:Label>
                    <asp:ImageButton ID="imgBtnLogout" runat="server" ImageUrl="~/Image/logout.png"  CssClass="float-right img-fluid"/> 
                </div>
            </div>
        </div>

        <div class="container">
            <div class="row">
                <div class="col-lg-2 text-info">
                    <uc1:sidebarControl runat="server" ID="sidebarControl" />
                </div>
                <div class="col-lg-10 p-2">
                    <uc1:ProductControl runat="server" ID="ProductControl" />
                </div>
            </div>
        </div>       
    </form>
</body>
</html>
