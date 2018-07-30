<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="receipt-review.aspx.cs" Inherits="receipt_review" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <section id="main">
      <div class="container">
        <div class="row">
          
          <div class="col-md-12">
            <!-- Website Overview -->


              <div class="panel panel-default">
                <div class="panel-heading main-color-bg">
                  <h3 class="panel-title">Order Information</h3>
                </div>
                <div class="panel-body">
                <div class="col-md-6">
                <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">Order Details</th>
                                </tr>
                              </thead>
                              <tbody>
                                <tr>
                                  <th scope="row">ID</th>
                                  <td><asp:Label ID="orderid_lbl" runat="server" Text=""></asp:Label></td>
                                </tr>
                                <tr>
                                  <th scope="row">Date</th>
                                  <td><asp:Label ID="date_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Status</th>
                                  <td><asp:Label ID="status_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>

                                  <tr>
                                  <th scope="row">Tracking ID</th>
                                  <td><asp:Label ID="tracking_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                              </tbody>
                            </table>
                    </div>
                    <div class="col-md-6">
                        <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">Customer Details</th>
                                </tr>
                              </thead>
                              <tbody>
                                <tr>
                                  <th scope="row">Email</th>
                                  <td><asp:Label ID="email_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Postal</th>
                                  <td><asp:Label ID="postal_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Address</th>
                                  <td><asp:Label ID="address_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                  <tr>
                                  <th scope="row">City</th>
                                  <td><asp:Label ID="city_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                                  <tr>
                                  <th scope="row">Delivery option</th>
                                  <td><asp:Label ID="type_lbl" runat="server" Text=""></asp:Label></td>

                                </tr>
                              </tbody>
                            </table>
                        </div>

        <%-- order details --%>
                            


<div class="col-md-6">
        <div class="container">
    <div class="row">
        <div class="well col-xs-10 col-sm-10 col-md-6 col-xs-offset-1 col-sm-offset-1 col-md-offset-3">
            <div class="row">
                <div class="col-xs-6 col-sm-6 col-md-6">
                    <address>
                        <strong>
                            <asp:Label ID="emailtxt" runat="server" Text="Label"></asp:Label></strong>
                        <br/>
                        <asp:Label ID="addresstxt" runat="server" Text="Label"></asp:Label>
                        <br/>
                        <asp:Label ID="postaltxt" runat="server" Text="Label"></asp:Label>
                        <br/>
                        <abbr title="Phone"><asp:Label ID="hptxt" runat="server" Text=""></asp:Label></abbr>
                    </address>
                </div>
                <div class="col-xs-6 col-sm-6 col-md-6 text-right">
                    <p>
                        <em><asp:Label ID="orderDatetxt" runat="server" Text="Label"></asp:Label></em>
                    </p>
                    <p>
                        <em>Order #: <asp:Label ID="ordernotxt" runat="server" Text="Label"></asp:Label></em>
                    </p>
                    <p>
                    <asp:Label ID="cardtype" runat="server" Text=""/>     
                    <asp:Label ID="cardNo" runat="server" Text=""/>
                    </p>
                </div>
            </div>
            <div class="row">
                <div class="text-center">
                    <h1>Receipt</h1>
                </div>
                
                <table class="table table-hover">
                    <thead>
                        <tr>

                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                            <asp:GridView ID="gvUser" runat="server" style="width:100%;border-collapse:collapse;margin:0px auto 0px auto" AutoGenerateColumns="False" GridLines="None"  cellpadding="10" cellspacing="5">
                                <Columns>
                                    <asp:BoundField DataField="OutfitID"  HeaderText="Outfit ID" />
                                        <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                                        <asp:BoundField DataField="Qty" HeaderText="Quantity" />
                                        <asp:BoundField DataField="Price" HeaderText="Price" />
                                        <asp:BoundField DataField="TotalPrice" HeaderText="Total Price" />
                                    </Columns>
                            </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td class="text-right"><h4><strong>Total: <asp:Label ID="lbl_TotalPrice" runat="server" Text="lbl_TotalPrice"></asp:Label></strong></h4></td>
                        </tr>
                    </tbody>
                </table>

            </div>
        </div>
    </div>
         </div>
                        </div>
                    </div>
                  </div>
              </div>
            </div>
              </div>
            </section>
</asp:Content>

