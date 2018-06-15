<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="style/style.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="loginbox">
    <img src="images/boxwear-resize.png" class="avatar"/>
        
            <p>Email</p>
            <asp:TextBox CssClass="form-control" ID="txtusername" placeholder="Enter Username" runat="server"></asp:TextBox>
            <p>Password</p>
            <asp:TextBox ID="txtpassword" placeholder="Enter Password" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label runat="server" ID="lblerror"></asp:Label>   
        <asp:Button ID="btn_submit" CssClass="btn btn-primary" runat="server" Text="Login" OnClick="btn_submit_Click" />
    <asp:Label ID="forgetPW" runat="server" Text="Forget Password"></asp:Label>
    <br />
        <asp:HyperLink ID="register"  NavigateUrl="~/registration.aspx" runat="server" >Register</asp:HyperLink>
        
        
    </div>
</asp:Content>

