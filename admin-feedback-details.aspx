<%@ Page Title="" Language="C#" MasterPageFile="~/site-admin.master" AutoEventWireup="true" CodeFile="admin-feedback-details.aspx.cs" Inherits="admin_feedback_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       
    <br />
    <br />
    <section id="main">
      <div class="container">
        <div class="row">
          
          <div class="col-md-12">
            <!-- Website Overview -->


              <div class="panel panel-default">
                <div class="panel-heading main-color-bg">
                  <h3 class="panel-title">Feedback Details</h3>
                </div>
                <div class="panel-body">
                <div class="col-md-6">
                <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">Feedback Information</th>
                                </tr>
                              </thead>
                              <tbody>
                                <tr>
                                  <th scope="row">Feedback ID</th>
                                  <td><asp:Label ID="lbl_Id" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                  <th scope="row">Order Number</th>
                                  <td><asp:Label ID="lbl_OrderNo" runat="server" Text=""></asp:Label></td>

                                </tr>
                                
                                  <tr>
                                  <th scope="row"></th>
                                  <td></td>

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
                                  <th scope="row">First Name</th>
                                  <td><asp:Label ID="lbl_FName" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Last Name</th>
                                  <td><asp:Label ID="lbl_LName" runat="server" Text=""></asp:Label></td>

                                </tr>
                                <tr>
                                  <th scope="row">Email</th>
                                  <td><asp:Label ID="lbl_Email" runat="server" Text=""></asp:Label></td>

                               
                                
                                </tr>
                              </tbody>
                            </table>
                        </div>

        <%-- order details --%>
                            

                   
            </section>
     <section id="main">
      <div class="container">
        <div class="row">
          
          <div class="col-md-12">
            <!-- Website Overview -->


              <div class="panel panel-default">
                <div class="panel-heading main-color-bg">
                  <h3 class="panel-title">Feedback Message</h3>
                </div>
                <div class="panel-body">
                <div class="col-md-6">
                <asp:Label ID="lbl_Message" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="col-md-6">
                       </div>
                    </div>
                  </div>
              </div>
                        </div>
                    </div>
                
                  </section>

    
</asp:Content>

