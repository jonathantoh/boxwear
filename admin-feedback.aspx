<%@ Page Title="" Language="C#" MasterPageFile="~/site-admin.master" AutoEventWireup="true" CodeFile="admin-feedback.aspx.cs" Inherits="admin_feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="col-md-10">
            <h1><span class="glyphicon glyphicon-cog" aria-hidden="true"></span> Feedback <small>Review all your feedbacks</small></h1>
          </div>
  
     <asp:GridView ID="gvFeedback" runat="server" AutoGenerateColumns="False" DataKeyNames="feedbackOrderNo" OnRowDeleting="gvFeedback_RowDeleting" Width="544px" OnSelectedIndexChanged="gvFeedback_SelectedIndexChanged" >
         <Columns>
             <asp:BoundField DataField="feedbackFName" HeaderText="First Name" />
             <asp:BoundField DataField="feedbackLName" HeaderText="Last Name" />
             <asp:BoundField DataField="feedbackEmail" HeaderText="Email" />
             <asp:BoundField DataField="feedbackOrderNo" HeaderText="Order Number" />
             <asp:BoundField DataField="feedbackMessage" HeaderText="Message" />
             <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True"  />
         </Columns>
     </asp:GridView>
  
</asp:Content>

