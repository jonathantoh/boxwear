<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="MenProducts.aspx.cs" Inherits="MenProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 245px;
        }
        .auto-style3 {
            height: 56px;
        }
    .auto-style4 {
        height: 50px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    MEN PRODUCTS
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" rowspan="3">
                <asp:Image ID="img_Products" runat="server" Height="116px" ImageUrl="~/images/boxwear-resize.png" Width="212px" />
            </td>
            <td class="auto-style4">
                <asp:Label ID="lbl_ProdName" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lbl_ProdDesc" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
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

