<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="account.aspx.cs" Inherits="account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <meta name="viewport" content="width=device-width, initial-scale=1, minimum-scale=1, maximum-scale=1"/>

    <!-- Link Swiper's CSS -->
    <link rel="stylesheet" href="../CSS/swiper.min.css"/>
      <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <!-- Bootstrap core CSS -->
    
    <link href="CSS/style.css" rel="stylesheet"/>
    <script src="http://cdn.ckeditor.com/4.6.1/standard/ckeditor.js"></script>

    <!--important-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style type="text/css">
        .dash-box{
           text-align:left;
        }
     .swiper-container {
      width: 100%;
      height: 100%;
      
    }
    .swiper-slide {
      text-align: left;
      font-size: 11px;
      background: #fff;
      padding-left:10px;
      padding-right:10px;   
      /* Center slide text vertically */
    }

     .form-control{
		height: 41px;
		background: #f2f2f2;
		box-shadow: none !important;
		border: none;
	}
	.form-control:focus{
		background: #e2e2e2;
	}
    .form-control, .btn{        
        border-radius: 3px;
    }
	.signup-form{
		width: 390px;
		margin: 30px auto;
	}
	.signup-form form{
		color: #999;
		border-radius: 3px;
    	margin-bottom: 15px;
        background: #fff;
        box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
        padding: 30px;
    }
	.signup-form h2 {
		color: #333;
		font-weight: bold;
        margin-top: 0;
    }
    .signup-form hr {
        margin: 0 -30px 20px;
    }    
	.signup-form .form-group{
		margin-bottom: 20px;
	}
	.signup-form input[type="checkbox"]{
		margin-top: 3px;
	}
	.signup-form .row div:first-child{
		padding-right: 10px;
	}
	.signup-form .row div:last-child{
		padding-left: 10px;
	}
    .signup-form .btn{        
        font-size: 16px;
        font-weight: bold;
		background: #3598dc;
		border: none;
		min-width: 140px;
    }
	.signup-form .btn:hover, .signup-form .btn:focus{
		background: #2389cd !important;
        outline: none;
	}
    .signup-form a{
		color: grey;
		text-decoration: underline;
	}
	.signup-form a:hover{
		text-decoration: none;
	}
	.signup-form form a{
		color: #3598dc;
		text-decoration: none;
	}	
	.signup-form form a:hover{
		text-decoration: underline;
	}
    .signup-form .hint-text {
		padding-bottom: 15px;
		text-align: center;
    }
    .main-color-bg{
      font-family: 'Fjalla One', Helvetica, sans-serif;
      background-color: transparent !important;
      border-color: black !important;
      color: black !important;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
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
              <a href="myRewards.aspx" class="list-group-item"><span class="glyphicon glyphicon-gift" aria-hidden="true"></span> My Rewards <span class="badge">33</span></a>
              <asp:linkbutton class="list-group-item" runat="server" onclick="btnlogout_Click"><span class="glyphicon">&#xe163;</span> Logout <span class="badge"></span></asp:linkbutton>
            </div>

            <div class="well">
              <h4>Reward Points</h4>
                <h4>
                    <asp:Label ID="lbl_points" runat="server" ></asp:Label>
                </h4>
              <div class="progress">
                  <div class="progress-bar" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width: 1%;">
                      0%
              </div>
            </div>
            
            </div>
          </div>

          <div class="col-md-9" style="text-align:left;">



              <div class="panel panel-default">

              <div class="panel-body">
                <!-- Swiper -->
                  <div class="swiper-container" style="position: relative;height: 100%;">
                    <div class="swiper-wrapper" >
                      <div class="swiper-slide" >
                          <h3 style="background-color:#ffd700;color:white;text-align:center">Level 1</h3> 
                          <br /><p><a>> Enjoy Rewards</a></p>
                          <p><a>> My Points in Detail</a></p>
                          <p>> Only $150 to move up to level 2</p>
                          <p></p>
                          <p style="color:#ffd700;font-size:15px;text-align:center;"><strong>>$1 = 1 point</strong></p>
                          <p><br /></p>

                      </div>

                        <div class="swiper-slide" >
                          <h3 style="background-color:#fa8072;color:white;text-align:center"">Level 2</h3> 
                          <br /><p><a>> Enjoy Rewards</a></p>
                          <p><a>> My Points in Detail</a></p>
                          <p>>All the Rewards from LEVEL 1, plus:</p>
                            <ul>
                                <li>Welcome gift</li>
                                <li>Exclusive customisation options</li>
                                <li>10% discount code on your birthday month</li>
                            </ul>
                          <p></p>
                          <p>>$1 = 1 point</p>
                          <p><br /></p>

                      </div>

                        <div class="swiper-slide" >
                          <h3 style="background-color: #008000;color:white;text-align:center"">Level 3</h3> 
                          <br /><p><a>> Enjoy Rewards</a></p>
                          <p><a>> My Points in Detail</a></p>
                          <p>> Only $150 to move up to level 2</p>
                          <p></p>
                          <p>>$1 = 1 point</p>
                          <p><br /></p>

                      </div>


                        <div class="swiper-slide" >
                          <h3 style="background-color: #003366; color:white;text-align:center"">Level 4</h3> 
                          <br /><p><a>> Enjoy Rewards</a></p>
                          <p><a>> My Points in Detail</a></p>
                          <p>> Only $150 to move up to level 2</p>
                          <p></p>
                          <p>>$1 = 1 point</p>
                          <p><br /></p>

                      </div>
                    </div>
                    <!-- Add Pagination -->
                    <div class="swiper-pagination" style="margin-top:20px;"></div>
                  </div>
                  
              </div>
              </div>

                  <!-- Swiper JS -->
                  <script src="../js/swiper.min.js"></script>

                  <!-- Initialize Swiper -->
                  <script>
                    var swiper = new Swiper('.swiper-container', {
                      slidesPerView: 4,
                      spaceBetween: 30,
                      centeredSlides: true,
                      pagination: {
                        el: '.swiper-pagination',
                        clickable: true,
                      },
                    });
                  </script>


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
                      <h5>
                          <asp:Button runat="server" type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalCenter" Text="Edit"/>
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
                       <h5>
                          <asp:Button runat="server" type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalCenter2" Text="Edit"/>
                      </h5>
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
        </div>

        <!-- Modal 1-->
    <div class="modal fade" data-backdrop="false" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
      <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLongTitle">Update Account Information</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <div class="signup-form">
                <div class="form-group">
			    <div class="row">
				    <div class="col-xs-6"><asp:TextBox ID="Fname" class="form-control" name="first_name" placeholder="First Name" required="required" runat="server"></asp:TextBox></div>
				    <div class="col-xs-6"><asp:TextBox ID="Lname" class="form-control" name="last_name" placeholder="Last Name" required="required" runat="server"></asp:TextBox></div>
			    </div>        	
            </div>
            <div class="form-group">
                <asp:TextBox class="form-control" name="mobile" placeholder="Mobile" required="required" ID="MobileNumber" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">

            </div>
		    <%--<div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="password" placeholder="Password" required="required" ID="Password" TextMode="Password"></asp:TextBox>
            </div>
		    <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="confirm_password" placeholder="Confirm password" required="required" ID="ConfirmPassword" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator id="comparePasswords" 
                  runat="server"
                  ControlToCompare="Password"
                  ControlToValidate="ConfirmPassword"
                  ErrorMessage="Your passwords do not match up!"
                  Display="Dynamic" />
            </div>--%>
            </div>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
              <asp:Button ID="updateBtn" onclick="updateProfileBtn_Click" Class="btn btn-primary" UseSubmitBehavior="false" runat="server" Text="Save changes" />
          </div>
        </div>
      </div>
    </div>





            <!-- Modal 2 -->
    <div class="modal fade" data-backdrop="false" id="exampleModalCenter2" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
      <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLongTitle2">Update Address Information</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            <div class="signup-form">
                
            <div class="form-group">
                <asp:TextBox class="form-control" name="address" placeholder="Address" required="required" ID="address" runat="server"></asp:TextBox>
            </div>
                <div class="form-group">
			    <div class="row">
				    <div class="col-xs-6"><asp:TextBox ID="postal" class="form-control" name="postal" placeholder="Postal Code" required="required" runat="server"></asp:TextBox></div>
				    <div class="col-xs-6"><asp:TextBox ID="city" class="form-control" name="city" placeholder="City" required="required" runat="server"></asp:TextBox></div>
			    </div>        	
                </div>

            <div class="form-group">
                <asp:DropDownList ID="ddl_country" runat="server" class="form-control">
                      <asp:ListItem>Singapore</asp:ListItem>
                  </asp:DropDownList>
                </div>

            </div>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>

              <asp:Button ID="updateAddressBtn" OnClick="updateAddressBtn_Click" Class="btn btn-primary" UseSubmitBehavior="false" data-dismiss="modal" runat="server" Text="Save changes" />
          </div>
        </div>
      </div>
    </div>

    

</asp:Content>

