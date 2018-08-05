<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <section id="breadcrumb">
      <div class="container">
        <ol class="breadcrumb" style="margin-top:20px;padding:80px;font-size:20px;">
          <li class="main-color-bg">Shopping Cart <span class="glyphicon glyphicon-shopping-cart"></span></li>
            <li class="main-color-bg">A cart where items live</li>
        </ol>
          
      </div>
    </section>

    <div class="container">
    <div class="panel panel-default">

              <div class="panel-body">
<table class="table table-hover">
                    <thead>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                            <asp:GridView ID="gv_CartView" runat="server" AutoGenerateColumns="False" DataKeyNames="ItemID" OnRowCommand="gv_CartView_RowCommand" style="width:100%;border-collapse:collapse;margin:0px auto 0px auto" GridLines="None"  cellpadding="10" cellspacing="5" OnSelectedIndexChanged="gv_CartView_SelectedIndexChanged">
                                <Columns>
                                    <asp:ImageField DataImageUrlField="Product_Image" ControlStyle-Width="70" ControlStyle-Height="70">
                        <ControlStyle Height="70px" Width="70px"></ControlStyle>
                                    </asp:ImageField>
                                    <asp:BoundField DataField="ItemID" HeaderText="Product ID" />
                                    <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
                                    <asp:TemplateField HeaderText="Quantity">
                                        <ItemTemplate>
                                             <asp:Label ID="lbl_qty" runat="server" Text='<%# Eval("Quantity") %>'></asp:Label>
                                           <%-- <asp:TextBox ID="tb_Quantity" runat="server" style="width:98%;" Text='<%# Eval("Quantity") %>'></asp:TextBox>--%>
                                            <br />
                                            <asp:LinkButton ID="btn_Remove" runat="server" CommandName="Remove" CommandArgument='<%# Eval("ItemID") %>' OnClick="btn_Remove_Click">Remove</asp:LinkButton> 
                                          
                                            <br />
                                           
                                          
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Product_SizeCust" HeaderText="Size" />
                                    <asp:BoundField DataField="Product_Price" DataFormatString="{0:C}" HeaderText="Unit Price" />
                                    <asp:BoundField DataField="TotalPrice" DataFormatString="{0:C}" HeaderText="Price" />
                                </Columns>
                            </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td class="text-right"><h4><strong>Total: $<asp:Label ID="lbl_TotalPrice" runat="server" Text="lbl_TotalPrice"></asp:Label></strong></h4></td>
                        </tr>
                    </tbody>
                </table>


    <br />
    <asp:Label ID="lbl_Size" runat="server"></asp:Label>
<br />
   
    <asp:Label ID="lbl_Error" runat="server"></asp:Label>

<br />
<%--<asp:Button ID="btn_Update" class="btn btn-warning" runat="server" OnClick="btn_Update_Click" Text="Update Cart" />--%>
<asp:Button ID="btn_Clear"  class="btn btn-danger" runat="server" OnClick="btn_Clear_Click" Text="Clear Cart" />
    <a href="checkout.aspx" class="btn btn-primary">Checkout</a>
                  </div>
        </div>
        </div>
</asp:Content>
