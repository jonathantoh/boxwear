<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="OrderIssues.aspx.cs" Inherits="OrderIssues" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/style.css" rel="stylesheet"/>
    <script src="http://cdn.ckeditor.com/4.6.1/standard/ckeditor.js"></script>
    
    
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script>
     <style type="text/css">
         .auto-style1 {
             width: 320px;
         }
         .auto-style3 {
             width: 320px;
             height: 10px;
         }
         .auto-style4 {
             height: 10px;
         }
         .auto-style5 {
             width: 320px;
             height: 22px;
         }
         .auto-style6 {
             height: 22px;
         }
     </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <br />
    <br />
    <div class="container">
    <h1>E-MAIL CUSTOMER SUPPORT</h1>
    <table class="nav-justified">
        <tr>
            <td class="auto-style1">First Name</td>
            <td>
                <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_FName" runat="server" ControlToValidate="txtFName" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Last Name</td>
            <td>
                <asp:TextBox ID="txtLName" runat="server" Height="24px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_LName" runat="server" ControlToValidate="txtLName" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Email</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Email" runat="server" ControlToValidate="txtEmail" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="*Invalid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Order No.</td>
            <td>
                <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_OrderNo" runat="server" ControlToValidate="txtOrderNo" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Message</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtMessage" runat="server" Height="102px" Width="302px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Message" runat="server" ControlToValidate="txtMessage" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" class="btn btn-primary btn-lg" runat="server" OnClick="btnSubmit_Click" Text="Button" style="height: 26px" />
            </td>
        </tr>
    </table>
        </div>

</asp:Content>

