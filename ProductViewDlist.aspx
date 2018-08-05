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
        .auto-style8 {
            height: 34px;
            width: 187px;
        }
        .auto-style9 {
            width: 187px
        }
        .auto-style10 {
            width: 280px;
            height: 26px;
        }
        .auto-style11 {
            width: 187px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
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
                <td class="auto-style9">
                    <asp:TextBox ID="tb_InputID" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btn_retrieveAll" runat="server" OnClick="btn_retrieveAll_Click" Text="View all products" />
    <asp:Button ID="btn_AddProduct" runat="server" Text="Add New Product " OnClick="btn_AddProduct_Click" />
   
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Stock level</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Low</asp:ListItem>
                        <asp:ListItem>High</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sort" />
                </td>
                <td class="auto-style12">
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style8">
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="height: 29px" Text="Search" />
                </td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
    </div>
   <br />

    <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged" DataKeyNames="Product_ID" OnRowDeleting="gvProduct_RowDeleting" OnRowCancelingEdit="gvProduct_RowCancelingEdit" OnRowEditing="gvProduct_RowEditing" OnRowUpdating="gvProduct_RowUpdating" Width="1011px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Product_ID" HeaderText="Product ID" />
            <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
            <asp:BoundField DataField="Product_Desc" HeaderText="Product Description" />
            <asp:BoundField DataField="Product_Category" HeaderText="Product Category" />
            <asp:BoundField DataField="Product_Quantity" HeaderText="Product Quantity" />
            <asp:BoundField DataField="Product_Price" HeaderText="Unit Price" />
            <asp:BoundField DataField="Product_Status" HeaderText="Product Status" />
            <asp:BoundField DataField="Product_Size" HeaderText="Product Size" />
            <asp:ImageField DataImageUrlField="Product_Image" ReadOnly="true" ControlStyle-Width="300" ControlStyle-Height = "200" HeaderText="Image">

<ControlStyle Height="200px" Width="300px"></ControlStyle>

            </asp:ImageField>
            <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
</asp:GridView>
    <br />
       
</asp:Content>


