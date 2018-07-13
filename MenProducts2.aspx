<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="MenProducts2.aspx.cs" Inherits="MenProducts2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" CellPadding="50" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" DataKeyField="Product_ID" OnItemCommand="DataList1_ItemCommand">
        <ItemTemplate>
            <table class="auto-style2">
                <tr>
                    <td rowspan="3">
                        <asp:Image ID="img_Products" runat="server" style ="width:250px; height:220px;" ImageUrl='<%# Eval("Product_Image") %>'/>
                    </td>
                    <td>
                        <asp:Label ID="lbl_ProdName" runat="server" Text='<%# Eval("Product_Name") %>'></asp:Label>
                        <br />
                        <asp:Label ID="lbl_ProdDesc" runat="server" Text='<%# Eval("Product_Desc") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Small</asp:ListItem>
                            <asp:ListItem>Medium</asp:ListItem>
                            <asp:ListItem>Large</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_Price" runat="server" Text='<%# Eval("Product_Price") %>'></asp:Label>
                        <br />
                        <asp:Button ID="Btn_Add" runat="server" Text="Add To Cart" CommandName="call" OnClick="Btn_Add_Click"/>
                    </td>
                </tr>
            </table>
            <br />
            Product ID =
            <asp:Label ID="lbl_ProdID" runat="server" Text='<%# Eval("Product_ID") %>'></asp:Label>
           
        </ItemTemplate>
        
    </asp:DataList>
    </asp:Content>

