<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="WomenProducts.aspx.cs" Inherits="WomenProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    WOMEN PRODUCTS
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" rowspan="3">
                <asp:Image ID="img_Products" runat="server" Height="125px" ImageUrl="~/Images/unknown.png" Width="237px" />
            </td>
            <td class="auto-style4">
                <asp:Label ID="lbl_ProdName" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lbl_ProdDesc" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <select>
                    <option value="small">Small</option>
                    <option value="medium">Medium</option>
                    <option value="large">Large</option>
                </select>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lbl_Price" runat="server"></asp:Label>
                <br />
                <asp:Button ID="Btn_Add" runat="server" Text="Add to Cart" OnClick="Btn_Add_Click" />
                <br />
            </td>
        </tr>
    </table>
    Product ID =
    <asp:Label ID="lbl_ProdID" runat="server"></asp:Label>
    <br />
    <br />
    
</asp:Content>
