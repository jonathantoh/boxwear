<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="style/style.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="loginbox">
    <img src="images/boxwear-resize.png" class="avatar"/>
        
            <p>Username</p>
            <input type="text" name="" placeholder="Enter Username"/>
            <p>Password</p>
            <input type="password" name="" placeholder="Enter Password"/>
            <input type="submit" name="" value="Login"/>
    <asp:Label ID="forgetPW" runat="server" Text="Forget Password"></asp:Label>
    <br />
    <asp:Label ID="register" runat="server" Text="Register"></asp:Label>
        
        
    </div>
</asp:Content>

