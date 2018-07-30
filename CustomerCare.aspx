<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="CustomerCare.aspx.cs" Inherits="CustomerCare" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/style.css" rel="stylesheet"/>
    <script src="http://cdn.ckeditor.com/4.6.1/standard/ckeditor.js"></script>
    
    
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script>






</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <center><h1>CUSTOMER CARE</h1></center>
    
    <br />
    <br />
    
    <div class="container">
         <div class="row">
    <div class="col-md-4">
      <div class="thumbnail">
        
     
          <a href="OrderIssues.aspx" target="_blank" class="hoverable">
              <span class="normal">
                
                  Order Issues
              </span>
              <span class="hover">  
                  
                 Contact Customer Support
                  
              </span>

          </a>
     

          
      </div>
    </div>
    <div class="col-md-4">
      <div class="thumbnail">
        <a href="myRewards.aspx" target="_blank">
         <img src="" alt="Fjords" style="width:100%"/>

          
        </a>
      </div>
    </div>
    <div class="col-md-4">
      <div class="thumbnail">
        <a href="" target="_blank">
          <img src="" alt="Fjords" style="width:100%"/>
          
        </a>
      </div>
    </div>
  </div>
              

            
            </div>
     
</asp:Content>

