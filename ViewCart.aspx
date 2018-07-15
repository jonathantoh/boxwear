<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="breadcrumb">
      <div class="container">
        <ol class="breadcrumb" style="margin-top:20px;padding:80px;font-size:20px;">
          <li class="main-color-bg">Your Cart <span class="glyphicon glyphicon-shopping-cart" > </span></li>
            <li class="main-color-bg"> </li>
          <p>A cart where your loved products live</p>
        </ol>
          
      </div>
    </section>

    <div class="container">
    <asp:GridView ID="gv_CartView" runat="server" AutoGenerateColumns="False" DataKeyNames="ItemID" OnRowCommand="gv_CartView_RowCommand">
        <Columns>
            <asp:BoundField DataField="ItemID" HeaderText="Product ID" />
            <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="tb_Quantity" runat="server" Text='<%# Eval("Quantity") %>'></asp:TextBox>
                    <br />
                  <!-- <asp:LinkButton ID="btn_Remove" runat="server" CommandName="Remove" Text='<%# Eval("ItemID") %>'></asp:LinkButton> -->
                </ItemTemplate>
            </asp:TemplateField>
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
        <asp:Button ID="btn_Update" class="btn btn-info btn-lg" runat="server" OnClick="btn_Update_Click" Text="Update Cart" />
        <asp:Button ID="btn_Clear" class="btn btn-info btn-lg" runat="server" OnClick="btn_Clear_Click" Text="Clear Cart" />
        <asp:Button ID="btn_payment" class="btn btn-info btn-lg" runat="server"  Text="Proceed to Payment" />
        </div>
</asp:Content>
