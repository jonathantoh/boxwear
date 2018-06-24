<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="account.aspx.cs" Inherits="account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <style type="text/css">

    .main-color-bg{
      font-family: 'Fjalla One', Helvetica, sans-serif;
      background-color: transparent !important;
      border-color: black !important;
      color: black !important;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="breadcrumb">
      <div class="container">
        <ol class="breadcrumb" style="margin-top:20px;padding:80px;font-size:20px;">
          <li class="main-color-bg"><asp:Label ID="txtuser" runat="server" Text="Hello, User"></asp:Label> </li>
            <li class="main-color-bg"><asp:Label ID="status" runat="server" Text="Your status Level"></asp:Label> </li>
          <p>Welcome to your account</p>
        </ol>
          
      </div>
    </section>

    <section id="main">
      <div class="container">
        <div class="row">
          <div class="col-md-3">
            <div class="list-group">
              <a href="account.aspx" class="list-group-item active main-color-bg">
                <span class="glyphicon glyphicon-cog" aria-hidden="true"></span> Dashboard
              </a>
              <a href="account.aspx" class="list-group-item"><span class="glyphicon glyphicon-user" aria-hidden="true"></span> My Profile <span class="badge">12</span></a>
              <a href="rewards.aspx" class="list-group-item"><span class="glyphicon glyphicon-gift" aria-hidden="true"></span> My Rewards <span class="badge">33</span></a>
              <asp:linkbutton class="list-group-item" runat="server" onclick="btnlogout_Click"><span class="glyphicon">&#xe163;</span> Logout <span class="badge"></span></asp:linkbutton>
            </div>

            <div class="well">
              <h4>Reward Points</h4>
              <div class="progress">
                  <div class="progress-bar" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 60%;">
                      60%
              </div>
            </div>
            <h4>Bandwidth Used </h4>
            <div class="progress">
                <div class="progress-bar" role="progressbar" aria-valuenow="40" aria-valuemin="0" aria-valuemax="100" style="width: 40%;">
                    40%
            </div>
          </div>
            </div>
          </div>
          <div class="col-md-9">
            <!-- Website Overview -->
            <div class="panel panel-default">
              <div class="list-group-item active panel-heading main-color-bg">
                <h3 class="panel-title">Account Information</h3>
              </div>
              <div class="panel-body">
                <div class="col-md-6">
                  <div class="well dash-box">
                    <h4><strong>MY PERSONAL INFORMATION</strong></h4>
                      <div><h5>First Name:
                          <asp:Label ID="fnametxt" runat="server" Text="fnametxt"></asp:Label>
                          </h5></div>
                      <h5>Last Name:
                          <asp:Label ID="lnametxt" runat="server" Text="lnametxt"></asp:Label>
                      </h5>
                      <h5>Email:
                          <asp:Label ID="emailtxt" runat="server" Text="emailtxt"></asp:Label>
                      </h5>
                      <h5>Contact:
                          <asp:Label ID="contacttxt" runat="server" Text="contacttxt"></asp:Label>
                      </h5>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="well dash-box">
                    <h4><strong>MY ADDRESSES</strong></h4>
                    <h5>The places you do your best couch-shopping</h5>
                    <h5><asp:Label ID="addresstxt" runat="server" Text="addresstxt"></asp:Label></h5>
                    <h5><asp:Label ID="postaltxt" runat="server" Text="postaltxt"></asp:Label></h5>
                    <h5><asp:Label ID="citytxt" runat="server" Text="citytxt"></asp:Label></h5>
                    <h5><asp:Label ID="countrytxt" runat="server" Text="countrytxt"></asp:Label></h5>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="well dash-box">
                    <h3><span class="glyphicon glyphicon-pencil" aria-hidden="true"></span> Recent Orders</h3>
                    <h4>Posts</h4>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="well dash-box">
                    <h3><span class="glyphicon glyphicon-gift" aria-hidden="true"></span> My Rewards</h3>
                    <h4>Status Level 1</h4>
                  </div>
                </div>
              </div>
              </div>
              </div>
              </div>
          </div>
              </section>
</asp:Content>

