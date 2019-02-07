<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="sidebarControl.ascx.vb" Inherits="Store.mycontrol" %>

<%--OnSelectedIndexChanged="GridView1_SelectedIndexChanged"--%>
<p>
    &nbsp;</p>
<p>
    <br />
    
</p>
<asp:GridView ID="gvProductCategory" runat="server" AutoGenerateColumns="False"  ShowFooter="false"  OnRowCommand="gvProductCategory_RowCommand" ForeColor="Black" ShowHeader="False" BorderStyle="None">
    <Columns>
        <asp:TemplateField HeaderText="productCategoryId" SortExpression="productCategoryId" Visible="False">
            <EditItemTemplate>
                <asp:TextBox ID="txtProductCategoryId" runat="server" Text='<%# Bind("productCategoryId") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="lblProductCategoryId" runat="server" Text='<%# Bind("productCategoryId") %>'></asp:Label>
            </ItemTemplate>
            <FooterTemplate>
                <footer>
                     <asp:Label ID="lblProductCategoryIdFooter" runat="server" Text='<%# Bind("productCategoryId") %>'></asp:Label>
                </footer>
            </FooterTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Product Category" SortExpression="productCategoryName">
            <EditItemTemplate>
                <asp:TextBox ID="txtProductCategoryName" runat="server" Text='<%# Bind("productCategoryName") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                 <asp:LinkButton ID="lbSelectCategory" runat="server" CommandName="Select" Text='<%# Bind("productCategoryName") %>' CommandArgument='<%# Eval("productCategoryId") %>'></asp:LinkButton>
            </ItemTemplate>
            <ItemStyle BackColor="White" BorderStyle="None" ForeColor="White" />
        </asp:TemplateField>
    </Columns>
    <HeaderStyle BackColor="#009900" ForeColor="White" />
</asp:GridView>

