<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="WomenProduct2.aspx.cs" Inherits="WomenProduct2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style2 {
        font-size: large;
    }
    .auto-style3 {
        font-size: large;
        text-decoration: underline;
    }
        .auto-style4 {
            font-size: large;
        }
        .auto-style8 {
            height: 36px;
        }
        .auto-style14 {
            width: 350px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <strong>    <span class="auto-style3">Women Product<br />
    </span>
    
    </strong>
    <table class="auto-style4">
            <tr>
                <td class="auto-style14">Product Name:</td>
                <td>
                    <asp:TextBox ID="tb_Name" runat="server" CssClass="auto-style5"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style8">
                </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="height: 29px" Text="Search" />
                </td>
            </tr>
        </table>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand">
        <ItemTemplate>
            <table class="auto-style2">
                <tr>
                    <td rowspan="3">
                     
                        <asp:ImageButton ID="img_Products" runat="server" ImageUrl='<%# Eval("Product_Image") %>' onClick ="img_Products_Click" Height="215px" Width="246px"/>

                    </td>
                    <td>
         
                        <asp:Label ID="lbl_ProdName" runat="server" Text='<%# Eval("Product_Name") %>'></asp:Label>
                        <br />

                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="lbl_Price" runat="server" Text='<%# Eval("Product_Price") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>                        
                        <br />                       
                    </td>
                </tr>
            </table>
            <asp:Label ID="lbl_ProdID" runat="server" Text='<%# Eval("Product_ID") %>'></asp:Label>
            <br />
            Product Desc =
            <asp:Label ID="lbl_ProdDesc" runat="server" Text='<%# Eval("Product_Desc") %>'></asp:Label>
           
        </ItemTemplate>   
    </asp:DataList>

</asp:Content>


