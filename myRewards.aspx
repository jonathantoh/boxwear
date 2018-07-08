<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="myRewards.aspx.cs" Inherits="myRewards" %>

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

            .main-color-bg{
      font-family: 'Fjalla One', Helvetica, sans-serif;
      background-color: transparent !important;
      border-color: black !important;
      color: black !important;
    }
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
            padding-left: 10px;
            padding-right: 10px;
            /* Center slide text vertically */
        }

      .card {
      height: 100%;
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
                   <strong>Come back everyday to earn FREE daily rewards!<br /><br /></strong>
                   <asp:Button ID="dailyReward" Class="btn btn-primary" UseSubmitBehavior="false" runat="server" Text="Daily Reward 1 POINT" OnClick="dailyReward_Click" />
               </div>
              </div>

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


            <div class="row">
        <div class="col-sm-6">
          <div class="card">
            <img class="card-img-top" src="images/giftcard-25.jpg" />
            <div class="card-body">
              <h4 class="card-title">$25 Gift Card (250 points)</h4>
              <p class="card-text"></p>
            </div>
            <div class="card-footer">
                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">Claim Now</button>
            </div>
          </div>
        </div>
        <div class="col-sm-6">
          <div class="card">
            <img class="card-img-top" src="images/giftcard.jpg" />
            <div class="card-body">
              <h4 class="card-title">$50 Gift Card (500 points)</h4>
              <p class="card-text"></p>
            </div>
            <div class="card-footer">
              <asp:Button class="btn btn-primary" ID="btn_buy50" runat="server" Text="Claim now" OnClick="btn_buy50_Click" />
            </div>
          </div>
        </div>

                <div style="font-style: italic">If you want to buy someone a gift but you're having trouble figuring out what to get for them, a gift card can be a great solution.</div>

        <div class="col-sm-4">
          <div class="card">
            <img class="card-img-top" src="http://placehold.it/300x200" alt="">
            <div class="card-body">
              <h4 class="card-title">Card title</h4>
              <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sapiente esse necessitatibus neque.</p>
            </div>
            <div class="card-footer">
              <a href="#" class="btn btn-primary">Find Out More!</a>
            </div>
          </div>
        </div>

      </div>

              




              </div>
              </div>
          </div>

          
              </section>
        </div>



    
            <!-- Modal -->
          <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog modal-sm">
              <div class="modal-content">
                <div class="modal-header">
                  <button type="button" class="close" data-dismiss="modal">&times;</button>
                  <h4 class="modal-title">Confirmation (Gift Card $25)</h4>
                </div>
                <div class="modal-body">
                  <p>Are you sure you want to claim?</p>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btn_buy25" class="btn btn-default" OnClick="btn_buy25_Click" runat="server" Text="Yes" />
                  <button type="button" class="btn btn-default" data-dismiss="modal">No</button>
                </div>
              </div>
            </div>
          </div>


</asp:Content>

