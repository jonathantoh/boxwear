<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="suitableSize.aspx.cs" Inherits="suitableSize" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <style>
      
   p{
       text-align:center;
       color: rebeccapurple;
   }
    
   
   
     
      </style>
    <div class="container">
  <h2>Suitable Sizing</h2>
  <div class="panel panel-default">
       <section id="breadcrumb">
      <div class="container">
        <%--Recommended Size--%>
          <ol class="breadcrumb" style="margin-top:20px;padding:80px;font-size:20px;">
          <P class="main-color-bg">Your recommended Size <asp:Label ID="size_lbl" runat="server" Text="size_lbl"></asp:Label></P>
              </ol>
         <%--BottomSize--%>
         
         <ol class="breadcrumb2" style="margin-top:20px;padding:80px;font-size:20px;">
          <P class="main-color-bg">Your recommended Waist Size  <asp:Label ID="bottom_lbl" runat="server" Text="bottom_lbl"></asp:Label></P>
        </ol>
         
          <%--ShoeSize--%>
           <ol class="breadcrumb3" style="margin-top:20px;padding:80px;font-size:20px;">
          <P class="main-color-bg">Your recommended Shoe Size <asp:Label ID="foot_lbl" runat="server" Text="foot_lbl"></asp:Label></P>
        </ol>

      </div>
    </section>
    <div class="panel-body">
      <%--  <asp:Label ID="size_lbl" runat="server" Text="size_lbl"></asp:Label>--%>
    </div>
  </div>
</div>
</asp:Content>

