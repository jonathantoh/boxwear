<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:GridView ID="gv_CartView" runat="server" AutoGenerateColumns="False" DataKeyNames="ItemID" OnRowCommand="gv_CartView_RowCommand">
        <Columns>
            <asp:ImageField DataImageUrlField="Product_Image" ControlStyle-Width="400" ControlStyle-Height="300">
<ControlStyle Height="300px" Width="400px"></ControlStyle>
            </asp:ImageField>
            <asp:BoundField DataField="ItemID" HeaderText="Product ID" />
            <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="tb_Quantity" runat="server" style="width:98%;" Text='<%# Eval("Quantity") %>'></asp:TextBox>
                    <br />
                  <!-- <asp:LinkButton ID="btn_Remove" runat="server" CommandName="Remove" Text='<%# Eval("ItemID") %>'></asp:LinkButton> -->
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Product_SizeCust" HeaderText="Size" />
            <asp:BoundField DataField="Product_Price" DataFormatString="{0:C}" HeaderText="Unit Price" />
            <asp:BoundField DataField="TotalPrice" DataFormatString="{0:C}" HeaderText="Price" />
        </Columns>
    </asp:GridView>
    Total Price

    = $
    <asp:Label ID="lbl_TotalPrice" runat="server"></asp:Label>
    
    <br />
    <asp:Label ID="lbl_Size" runat="server"></asp:Label>
<br />
   
    <asp:Label ID="lbl_Error" runat="server"></asp:Label>

<br />
<asp:Button ID="btn_Update" runat="server" OnClick="btn_Update_Click" Text="Update Cart" />
<asp:Button ID="btn_Clear" runat="server" OnClick="btn_Clear_Click" Text="Clear Cart" />

</asp:Content>
