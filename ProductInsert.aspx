<%@ Page Title="" Language="C#" MasterPageFile="~/site-admin.master" AutoEventWireup="true" CodeFile="ProductInsert.aspx.cs" Inherits="ProductInsert" %>

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
    .auto-style7 {
        width: 630px;
    }
    .auto-style8 {
        height: 29px;
        width: 630px;
    }
    .auto-style9 {
        width: 285px;
        height: 24px;
    }
    .auto-style10 {
        height: 24px;
        width: 630px;
    }
    .auto-style11 {
        height: 24px;
    }
    .auto-style12 {
        width: 285px;
        height: 27px;
    }
    .auto-style13 {
        width: 630px;
        height: 27px;
    }
    .auto-style14 {
        height: 27px;
    }
        .auto-style15 {
            width: 285px;
            height: 17px;
        }
        .auto-style16 {
            height: 17px;
            width: 630px;
        }
        .auto-style17 {
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">Product ID</td>
            <td class="auto-style7">
                <asp:TextBox ID="tb_ProductID" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_ProductID" runat="server" ControlToValidate="tb_ProductID" ErrorMessage="Please enter Product ID" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Product Name</td>
            <td class="auto-style8">
                <asp:TextBox ID="tb_ProductName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="rfv_ProductName" runat="server" ControlToValidate="tb_ProductName" ErrorMessage="Please enter a name for the product." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Product Category</td>
            <td class="auto-style7">
                <asp:DropDownList ID="ddl_ProdCat" runat="server">
                    
                    <asp:ListItem Text="Casual" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Street Wear" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Formal" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Smart Casual" Value="4"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Product Size</td>
            <td class="auto-style7">
                <asp:DropDownList ID="ddl_Size" runat="server">
                    <asp:ListItem Text ="X-Small" Value="1"></asp:ListItem>
                    <asp:ListItem Text ="Small" Value="2"></asp:ListItem>
                    <asp:ListItem Text ="Medium" Value="3"></asp:ListItem>
                    <asp:ListItem Text ="Large" Value="4"></asp:ListItem>
                    <asp:ListItem Text ="X-Large"  Value="5"></asp:ListItem>
                </asp:DropDownList> 
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Product Desc</td>
            <td class="auto-style7">
                <asp:TextBox ID="tb_ProductDesc" runat="server" Height="242px" TextMode="MultiLine" Width="646px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_ProductDesc" runat="server" ControlToValidate="tb_ProductDesc" ErrorMessage="Please enter a description for the product." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Unit Price </td>
            <td class="auto-style10">
                <asp:TextBox ID="tb_UnitPrice" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:RequiredFieldValidator ID="rfc_UnitPrice" runat="server" ErrorMessage="Please enter a Unit Price for the product." ControlToValidate="tb_UnitPrice"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="cv_UnitPrice" runat="server" ControlToValidate="tb_UnitPrice" ErrorMessage="Only Numeric value is allowed." ForeColor="Red" Operator="DataTypeCheck" Type="Double"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Stock Quantity</td>
            <td class="auto-style7">
                <asp:TextBox ID="tb_StockQuantity" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_StockQuantity" runat="server" ControlToValidate="tb_StockQuantity" ErrorMessage="Please enter a value for the Stock Quantity."></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="cv_StockQuantity" runat="server" ControlToValidate="tb_StockQuantity" ErrorMessage="Only Numeric Integer is allowed." ForeColor="Red" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Stock Status</td>
            <td class="auto-style7">
                <asp:DropDownList ID="ddl_ProdStatus" runat="server">
                    <asp:ListItem Text="Available" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Unavailable" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Product Image</td>
            <td class="auto-style7">
                <asp:FileUpload ID="FileUpload" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_ProductImage" runat="server" ControlToValidate="FileUpload" ErrorMessage="Please select a Product Image." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style13">
                <asp:Label ID="lbl_Result" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style14">
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="btn_Insert" runat="server" CssClass="auto-style4" OnClick="btn_Insert_Click" Text="Insert" />
                <asp:Button ID="btn_ProductView" runat="server" Text="View Product List" OnClick="btn_ProductView_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

