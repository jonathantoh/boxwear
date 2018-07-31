﻿<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="SelectedProduct.aspx.cs" Inherits="SelectedProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">


    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }

        .auto-style4 {
            height: 27px;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
        <table class="auto-style2">
            <tr>
                <td>
                    <asp:Image ID="img_Products" runat="server" Height="166px" Width="235px" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <h4>Product Description:
                <asp:Label ID="lbl_ProdDesc" runat="server"></asp:Label>
                    </h4>
                </td>
            </tr>
        </table>
    
    <div class="col-md-8" style="float:left;">
        <div class="container" style="width: 50%;">
            <h2>Box Contents</h2>
            <div id="myCarousel" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class="carousel-inner">
                    <div class="item active">
                        <img src="Images/Apple-iPad-mini.jpg" alt="Los Angeles" style="width: 100%; height: 300px;" />
                    </div>

                    <div class="item">
                        <img src="Images/boxwear-resize.png" alt="Chicago" style="width: 100%; height: 300px;" />
                    </div>

                    <div class="item">
                        <img src="Images/outfits.jpg" alt="New york" style="width: 100%; height: 300px;" />
                    </div>
                </div>

                <!-- Left and right controls -->
                <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="right carousel-control" href="#myCarousel" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
        </div>
    </div>

    <div class="col-md-4" style="float: right;">
        <h1>
        <asp:Label ID="lbl_ProdName" runat="server"></asp:Label>               
            (<asp:Label ID="lbl_ProdID" runat="server" Text="Label"></asp:Label>)
        </h1>
        <h2>$<asp:Label ID="lbl_Price" runat="server"></asp:Label>
        </h2>
        <br />
        <h4>Shirt size:</h4>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="39px" Width="89px">
                        <asp:ListItem>X-Small</asp:ListItem>
                        <asp:ListItem>Small</asp:ListItem>
                        <asp:ListItem>Medium</asp:ListItem>
                        <asp:ListItem>Large</asp:ListItem>
                        <asp:ListItem>X-Large</asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />
        <br />            
        <br />

        <asp:LinkButton ID="Btn_FitAssist" runat="server">Check out the Fit Assistant!</asp:LinkButton>

        <br />
        <asp:Button ID="Btn_Add" CssClass="btn btn-default btn-lg" runat="server" OnClick="Btn_Add_Click"  Height="47px" Width="155px" Text="Add To Cart"></asp:Button> 
        
          
    </div>
</asp:Content>
