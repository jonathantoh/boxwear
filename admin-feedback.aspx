<%@ Page Title="" Language="C#" MasterPageFile="~/site-admin.master" AutoEventWireup="true" CodeFile="admin-feedback.aspx.cs" Inherits="admin_feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="col-md-10">
            <h1><span class="glyphicon glyphicon-cog" aria-hidden="true"></span> Feedback <small>Review all your feedbacks</small></h1>
          </div>
   
  <section id="main">
      <div class="container">
        <div class="row">
          
          <div class="col-md-12">
            <!-- Website Overview -->



              <!-- Latest Users -->
              <div class="panel panel-default">
                <div class="panel-heading main-color-bg">
                  <h3 class="panel-title">Latest Orders</h3>
                </div>
                <div class="panel-body">
                    <asp:GridView ID="gvFeedback" runat="server" AutoGenerateColumns="False" DataKeyNames="feedbackId" OnRowDeleting="gvFeedback_RowDeleting" OnSelectedIndexChanged="gvFeedback_SelectedIndexChanged" style="width:100% ;border-collapse:collapse;" CellPadding="4" ForeColor="#333333" GridLines="None" >
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>

                            <asp:BoundField DataField="feedbackId" HeaderText="ID" />
                             <asp:BoundField DataField="feedbackFName" HeaderText="First Name" />
                             <asp:BoundField DataField="feedbackLName" HeaderText="Last Name" />
                             <asp:BoundField DataField="feedbackEmail" HeaderText="Email" />
                             <asp:BoundField DataField="feedbackOrderNo" HeaderText="Order Number" />
                             <asp:BoundField DataField="feedbackMessage" HeaderText="Message" />
                             <asp:CommandField ShowDeleteButton="False" ShowSelectButton="True" SelectText="View Feedback"  />
                           
                            
                           
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:ImageButton ID="DeleteButton" runat="server" ImageUrl="~/site/img/icons/cross.png"
                                                CommandName="Delete" OnClientClick="return confirm('Are you sure you want to delete this event?');"
                                                AlternateText="Delete" />               
                                </ItemTemplate>
                            </asp:TemplateField>  
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" /> 
                </asp:GridView>
                
                </div>
              </div>


              

              
          </div>
        </div>
      </div>
    </section>
    


  
</asp:Content>






