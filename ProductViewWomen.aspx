<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="ProductViewWomen.aspx.cs" Inherits="ProductViewWomen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            text-decoration: underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <span class="auto-style2"><strong>Women Product</strong></span></p>
<asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Product_ID" HeaderText="Product ID" />
        <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
        <asp:BoundField DataField="Product_Price" HeaderText="Unit Price" />
        <asp:CommandField ShowSelectButton="True" />
    </Columns>
    </asp:GridView>
</asp:Content>
