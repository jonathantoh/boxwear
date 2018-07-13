<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="ProductInsert.aspx.cs" Inherits="ProductInsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 285px;
        }
        .auto-style4 {
            margin-bottom: 0px;
        }
        .auto-style5 {
            width: 285px;
            height: 29px;
        }
        .auto-style6 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">Product ID</td>
            <td>
                <asp:TextBox ID="tb_ProductID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Product Name</td>
            <td class="auto-style6">
                <asp:TextBox ID="tb_ProductName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Product Category</td>
            <td>
                <asp:TextBox ID="tb_ProductCat" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Product Brand </td>
            <td>
                <asp:TextBox ID="tb_ProductBrand" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Product Desc</td>
            <td>
                <asp:TextBox ID="tb_ProductDesc" runat="server" Height="242px" TextMode="MultiLine" Width="646px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Unit Price </td>
            <td class="auto-style6">
                <asp:TextBox ID="tb_UnitPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Stock Quantity</td>
            <td>
                <asp:TextBox ID="tb_StockQuantity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Stock Status</td>
            <td>
                <asp:TextBox ID="tb_StockStatus" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Product Image</td>
            <td>
                <asp:FileUpload ID="FileUpload" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Label ID="lbl_Result" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="btn_Insert" runat="server" CssClass="auto-style4" OnClick="btn_Insert_Click" Text="Insert" />
                <asp:Button ID="btn_ProductView" runat="server" Text="View Product List" />
            </td>
        </tr>
    </table>
</asp:Content>

