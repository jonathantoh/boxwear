<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="Fitasistant.aspx.cs" Inherits="Fitasistant" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1">
<style>    
body {font-family: Arial, Helvetica, sans-serif;}

* {box-sizing: border-box}
/* Full-width input fields */
input[type=text], input[type=password] {
    width: 100%;
    padding: 15px;
    margin: 5px 0 22px 0;
    display: inline-block;
    border: none;
    background: #f1f1f1;
}

/* Add a background color when the inputs get focus */
input[type=text]:focus, input[type=password]:focus {
    background-color: #ddd;
    outline: none;
}*/*/*/*/*/*/

/* Set a style for all buttons */
button {
    background-color: #4CAF50;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
    opacity: 0.9;
}

button:hover {
    opacity:1;
}

/* Extra styles for the cancel button */
.cancelbtn {
    padding: 14px 20px;
    background-color: #f44336;
    cursor:pointer;
    opacity:0.9;
    margin: 8px 0;
    border: none;
    width:100%;
    padding: 14px 20px;


}

/* Float cancel and signup buttons and add an equal width */
.cancelbtn, .signupbtn {
  float: left;
  width: 50%;
}

/* Add padding to container elements */
.container {
    padding: 16px;
}

/* The Modal (background) */
/*.modal {
    display: none; /* Hidden by default */
    position: fixed; /* Stay in place */
    z-index: 1; /* Sit on top */
    left: 0;
    top: 0;
    width: 100%; /* Full width */
    height: 100%; /* Full height */
    overflow: auto; /* Enable scroll if needed */
    background-color: #474e5d;
    padding-top: 50px;
}/***/

/* Modal Content/Box */
/*.modal-content {
    background-color: #fefefe;
    margin: 5% auto 15% auto; /* 5% from the top, 15% from the bottom and centered */
    border: 1px solid #888;
    width: 80%; /* Could be more or less, depending on screen size */
}

    /**/
/* Style the horizontal ruler */
hr {
    border: 1px solid #f1f1f1;
    margin-bottom: 25px;
}
 
/* The Close Button (x) */
/*.close {
    position: absolute;
    right: 35px;
    top: 15px;
    font-size: 40px;
    font-weight: bold;
    color: #f1f1f1;
}

.close:hover,
.close:focus {
    color: #f44336;
    cursor: pointer;
}
    */
/* Clear floats */
/**
.clearfix::after {
    content: "";
    clear: both;
    display: table;
}
    **/

/* Change styles for cancel button and signup button on extra small screens */
@media screen and (max-width: 300px) {
    .cancelbtn, .signupbtn {
       width: 100%;
    }
}

</style>





</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">





  <form>
    <div class="container">
      <h1>Fit Assitant</h1>
      <p>Please fill in your measurements</p>
      <hr>
      

      <label for="Height"><b>Height</b></label>
      <asp:TextBox ID="tb_height" runat="server" placeholder="Enter Height" ></asp:TextBox>
      
      

      <label for="Weight"><b>Weight</b></label>
      <asp:TextBox ID="tb_weight" runat="server" placeholder="Enter Weight" ></asp:TextBox>

      

      <label for="topsize"><b>TopSize</b></label>
      <asp:TextBox ID="tb_topsize" runat="server" placeholder="Enter TopSize" ></asp:TextBox>  
        
        
       <label for="bottomsize"><b>BottomSize</b></label>
      <asp:TextBox ID="tb_bottomSize" runat="server" placeholder="Enter BottomSize" ></asp:TextBox>       


      <label for="ShoeLength"><b>ShoeLength</b></label>
      <asp:TextBox ID="tb_footlength" runat="server" placeholder="Enter FootLength" ></asp:TextBox>



        <label for="TummySize"><b>TummySize</b></label>
        <asp:RadioButtonList ID="rbl_tummy" runat="server">
            <asp:ListItem>Small</asp:ListItem>
            <asp:ListItem>Medium</asp:ListItem>
            <asp:ListItem>Large</asp:ListItem>
        </asp:RadioButtonList>

        </br>
        </br>
        <label for="ShoulderLength"><b>ShoulderLength</b></label>
        <asp:RadioButtonList ID="rbl_shoulder" runat="server">
            <asp:ListItem >Small</asp:ListItem>
            <asp:ListItem>Medium</asp:ListItem>
            <asp:ListItem>Large</asp:ListItem>
        </asp:RadioButtonList>
        </br>
        </br>



    <asp:Button ID="btn_submit" class="btn btn-primary" runat="server" OnClick="btn_Submit_Click" Text="submit" />
        <%--<button type="button" id="btn_submit" class="btn btn-primary" runat="server" onclick="btn_Submit_Click" data-toggle="modal" data-target="#exampleModal">
  Launch demo modal
</button>--%>

       
    </div>
  </form>




<%--<script>
    // Get the modal
    var modal = document.getElementById('id01');

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
</script>--%>
   
    <br />
    <br />
    <%--<br />--%>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="suitableSize" runat="server"></asp:Label>
    <br/>
    <br/>
    <asp:Label ID="Tsize" runat="server" Text=""></asp:Label>
    <br/>
    <br/>
    <asp:Label ID="Bsize" runat="server" Text=""></asp:Label>
    <br/>
    <br/>
    <asp:Label ID="Flength" runat="server" Text=""></asp:Label>




</asp:Content>


