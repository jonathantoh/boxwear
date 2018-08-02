<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="suitableSize.aspx.cs" Inherits="suitableSize" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="container">
  <h2>Suitable Sizing</h2>
  <div class="panel panel-default">
       <section id="breadcrumb">
      <div class="container">
        <%--Recommended Size--%>
          <ol class="breadcrumb" style="margin-top:20px;padding:80px;font-size:20px;">
          <li class="main-color-bg">We recommend this size to you <asp:Label ID="size_lbl" runat="server" Text="size_lbl"></asp:Label></li>
              </ol>
         <%--TightFit--%>
          
         <ol class="breadcrumb" style="margin-top:20px;padding:80px;font-size:20px;">
          <li class="main-color-bg">TightFit Option <asp:Label ID="tight_lbl" runat="server" Text="tight_lbl"></asp:Label></li>
        </ol>
          
          <%--LooseFit--%>
           <ol class="breadcrumb" style="margin-top:20px;padding:80px;font-size:20px;">
          <li class="main-color-bg">LooseFit Option <asp:Label ID="loose_lbl" runat="server" Text="loose_lbl"></asp:Label></li>
        </ol>

      </div>
    </section>
    <div class="panel-body">
        <%--<asp:Label ID="size_lbl" runat="server" Text="size_lbl"></asp:Label>--%>
    </div>
  </div>
</div>
</asp:Content>

