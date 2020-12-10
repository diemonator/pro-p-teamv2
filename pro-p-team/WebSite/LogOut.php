<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Sign-Up Form</title>
        <link href="https://fonts.googleapis.com/css?family=Mogra" rel="stylesheet">
        <script type="text/javascript" src="JavaScript/PayPal.js"></script>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
        <link rel="stylesheet" href="CSS/optimizedVisual.css">

    </head>

    <body>
        <header>
            <a href="index.html" onclick="LogOut()" ><img class="login" src="Images/logout.png" alt="Images\lmao.png"></a>

            <a href="Register.html"><img class="reg" src="Images\vcvc.png" alt="Images\vcvc.png"></a>

            <a href="index.html"><img class="navImage" src="Images\bearWithMeLogo.png" alt=".!."></a>
        </header>

        <nav id="pc">
            <li><a href="index.html">Home</a></li>
            <li><a href="Gallery.html">Gallery</a></li>
            <li><a class="hiden" href="Events.html"> Events</a></li>
            <li class="center">

                <a class="special" href="Events.html">
                    <img class="navCenterImage1" src="Images\dsadasda.png" alt="Images\dsadasda.png">
                    <img class="navCenterImage2" src="Images\dasdas.png"/>
                    <img class="navCenterImage3" src="Images\fdgdgdsg.png" alt="Images\fdgdgdsg.png"></a></li>
            <li><a href="About us.html">About us</a></li>
            <li><a href="Contact.html">Contact</a></li>
        </nav>

        <nav class="mobile">
            <li><a href="index.html">Home</a></li>
            <li><a href="Gallery.html">Gallery</a></li>
            <li><a href="Events.html"> Events</a></li>
            <li><a href="About us.html">About us</a></li>
            <li><a href="Contact.html">Contact</a></li>
        </nav>


        <div class="forms"   method="post" >

            <div class="row">
                <!-- You can make it whatever width you want. I'm making it full width
                on <= small devices and 4/12 page width on >= medium devices -->
                <div class="col-xs-12 col-md-4">


                    <!-- CREDIT CARD FORM STARTS HERE -->
                    <div class="panel panel-default credit-card-box">
                        <div class="panel-heading display-table" >
                            <div class="row display-tr" >
                                <h3 class="panel-title display-td" >Payment Details For Camping Reservation</h3>
                                <div class="display-td" >                            
                                    <img class="img-responsive pull-right" src="http://i76.imgup.net/accepted_c22e0.png">
                                </div>
                            </div>                    
                        </div>
                        <div class="panel-body">
                            <form role="form" id="payment-form" action="Tickets.php" method="post">
                                <div class="row">
                                    <div class="col-xs-12">
                                        <div class="form-group">
                                            <br>

                                            <label for="cardNumber">CARD NUMBER</label>
                                            <div class="input-group">
                                                <input 
                                                    type="tel"
                                                    class="form-control"
                                                    name="cardNumber"
                                                    placeholder="Valid Card Number"
                                                    autocomplete="cc-number"
                                                    required autofocus 
                                                    style="width: 580px;"
                                                    />
                                                <span class="input-group-addon"><i class="fa fa-credit-card"></i></span>
                                            </div>
                                        </div>                            
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-xs-7 col-md-7">
                                        <div class="form-group">
                                            <br>
                                            <label for="cardExpiry"><span class="hidden-xs">EXPIRATION</span><span class="visible-xs-inline">EXP</span> DATE</label>
                                            <input 
                                                type="tel" 
                                                class="form-control" 
                                                name="cardExpiry"
                                                placeholder="MM / YY"
                                                autocomplete="cc-exp"
                                                required 
                                                />
                                        </div>
                                    </div>
                                    <div class="col-xs-5 col-md-5 pull-right">
                                        <div class="form-group">
                                            <br>
                                            <label for="cardCVC">CV CODE</label>
                                            <input 
                                                type="tel" 
                                                class="form-control"
                                                name="cardCVC"
                                                placeholder="CVC"
                                                autocomplete="cc-csc"
                                                required
                                                style="width: 580px;"
                                                />
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-xs-12">
                                        <div class="form-group">
                                            <br>
                                            <label for="couponCode">Number of guests for camping site Note: Every Guest will be charged additionaly with 20 Euros</label>

                                            <select name="amount">
                                                <option>  </option>
                                                <option value="1"> 1 </option>
                                                <option value="2"> 2 </option>
                                                <option value="3"> 3 </option>
                                                <option value="4"> 4 </option>
                                                <option value="5"> 5 </option>
                                                <option value="6"> 6 </option>
                                            </select>
                                        </div>
                                    </div>                        
                                </div>
                                <div>

                                    <input type="number" min="10" max="100" class="form-control" name="depositAmounth" placeholder="Amouth in Euros">
                                </div>
                                <br>

                                <div style="  display: block;
                                     padding-bottom: 15px;">

                                    <br>
                                    <input style="width: 150px;    display: block;
                                           height: 25px;
                                       " type="radio" name="radio1" value="camping">Deposit and make reservation for Camping
                                    <br>
                                    <input style="width: 150px;   display: block;
                                           height: 25px;
                                           " type="radio" name="radio1" value="depositOnly"
                                           checked>Only deposit in event account
                                    <br>
                                    <div class="row" style="display : block; text-align: center;">                                    
                                        <button name="registerbtn" action="Tickets.php" class="button button-block" type="submit" >Start Subscription</a></button>                                    
                                    </div>
                                    <div class="row" style="display:block;">
                                        <div class="col-xs-12">
                                            <p class="payment-errors"></p>
                                        </div>
                                    </div>
                            </form>

                        </div>
                    </div>        


                    <!-- CREDIT CARD FORM ENDS HERE -->
                </div>            
            </div>
        </div>
        <!-- If you're using Stripe for payments -->
        <script type="text/javascript" src="https://js.stripe.com/v2/"></script>
        <script type="text/javascript" src="JavaScript/PayPal.js"></script>
        <script type="text/javascript" src="JavaScript/AnimationMarto.js"></script>  

        <footer >
            <p>Site By Bear With Me Copyright (c) 2016 Copyright Holder All Rights Reserved.</p>
        </footer>

        <?php

        function LogOut() {
            session_start();
            session_destroy();
            unset($_SESSION['username']);
            $_SERVER['message'] = "You are logged out";
            header("Location: http://i359591.iris.fhict.nl/index.html");
            die();
        }
        ?>

    </body>

</html>