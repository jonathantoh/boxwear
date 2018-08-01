<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="ProductViewDlist.aspx.cs" Inherits="ProductViewDlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            text-decoration: underline;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 280px;
        }
        .auto-style5 {
            width: 280px;
            height: 34px;
        }
        .auto-style6 {
            height: 34px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style2">
        <strong>All Products</strong></p>

    <div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style4">ID</td>
                <td>
                    <asp:TextBox ID="tb_InputID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Stock level</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Low</asp:ListItem>
                        <asp:ListItem>High</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sort" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6">
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="height: 29px" Text="Search" />
                </td>
            </tr>
        </table>
        <br />
        <br />
    </div>
   <br />

    <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged" DataKeyNames="Product_ID" OnRowDeleting="gvProduct_RowDeleting" OnRowCancelingEdit="gvProduct_RowCancelingEdit" OnRowEditing="gvProduct_RowEditing" OnRowUpdating="gvProduct_RowUpdating" Width="763px">
        <Columns>
            <asp:BoundField DataField="Product_ID" HeaderText="Product ID" />
            <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
            <asp:BoundField DataField="Product_Quantity" HeaderText="Product Quantity" />
            <asp:BoundField DataField="Product_Price" HeaderText="Unit Price" />
            <asp:ImageField DataImageUrlField="Product_Image" ReadOnly="true" ControlStyle-Width="200" ControlStyle-Height = "100" HeaderText="Image">

            </asp:ImageField>
            <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
</asp:GridView>
    <br />
    <asp:Button ID="btn_AddProduct" runat="server" Text="Add New Product " OnClick="btn_AddProduct_Click" />
   
</asp:Content>


