<%@ Control AutoEventWireup="false" CodeBehind="ProductControl.ascx.vb" Inherits="Store.ProductControl" Language="vb" %>

<p>
    <asp:ImageButton ID="imgShop" runat="server" Height="27px" ImageUrl="~/Image/shop.png" Style="margin-top: 0px" Width="80px" />
    <asp:ImageButton ID="imgCart" runat="server" Height="27px" ImageUrl="~/Image/cart.png" Width="88px" />
    <asp:TextBox ID="txtSearch" runat="server" Height="37px" Width="440px" BorderColor="Aqua"></asp:TextBox>
&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Image/search.png" Height="26px" Width="77px" />
</p>


<asp:Panel ID="pnlProducts" runat="server">
    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" BorderStyle="None">
        <Columns>
            <asp:TemplateField HeaderText="Id" Visible="false">   
                <ItemTemplate>
                    <asp:Label ID="lblProductId" runat="server" Text='<%# Bind("productId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Image"  >    
                <ItemTemplate>        
                    <asp:Image ID="imgProductImage" runat="server" ImageUrl='<%#String.Concat("~/Image", "/", Eval("productImage"))%>' Width="200" Height="200"></asp:Image>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name" >
                <ItemTemplate>
                    <asp:Label ID="lblProductName" runat="server" Text='<%# Bind("productName") %>' Width="100"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Price" >
                <ItemTemplate>
                    <asp:Label ID="lblProductPrice" runat="server" Text='<%# Bind("productPrice") %>' Width="100"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Status" >
                <ItemTemplate>
                    <asp:Label ID="lblProductStatus" runat="server" Text='<%# Bind("productStatus") %>' Width="100"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Description" >
               
                <ItemTemplate>
                    <asp:Label ID="lblProductDescription" runat="server" Text='<%# Bind("productDescription") %>' Width="100"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="btnAddToCart" runat="server" ImageUrl="~/Image/shopCart.png" CommandArgument='<%# Eval("productId") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle BackColor="#009900" ForeColor="White" />
    </asp:GridView>
</asp:Panel>


