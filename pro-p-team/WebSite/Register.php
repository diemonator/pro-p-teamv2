<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Sign-Up Form</title>
        <link href="https://fonts.googleapis.com/css?family=Mogra" rel="stylesheet">

        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
        <link rel="stylesheet" href="CSS/optimizedVisual.css">

    </head>

    <body>
        <header>
            <a href="LogIn.php"><img class="login" src="Images\lmao.png" alt="Images\lmao.png"></a>

            <a href="Register.php"><img class="reg" src="Images\vcvc.png" alt="Images\vcvc.png"></a>

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
            <li><a href="Contact.php">Contact</a></li>
        </nav>

        <nav class="mobile">
            <li><a href="index.html">Home</a></li>
            <li><a href="Gallery.html">Gallery</a></li>
            <li><a href="Events.html"> Events</a></li>
            <li><a href="About us.html">About us</a></li>
            <li><a href="Contact.html">Contact</a></li>
        </nav>

        <div class="forms">

            <div id="signup">
                <h1>Sign Up To Register For An Event</h1>

                <form action="Register.php" method="Post">

                    <div class="top-row">
                        <div class="field-wrap">
                            <input name="Name" style="font-family: 'Mogra', cursive;: " value="names" type="text" placeholder="First and Last Name" required autocomplete="off"/>
                        </div>

                        <div class="field-wrap">
                            <input name="Address" style="font-family: 'Mogra', cursive;: " value="address" type="text" placeholder="Address" required autocomplete="off"/>
                        </div>
                    </div>

                    <div class="field-wrap">
                        <input name="Email" style="font-family: 'Mogra', cursive;: " type="text" value="email" placeholder="E-Mail Address" required autocomplete="off"/>
                    </div>

                    <div class="field-wrap">
                        <input name="Password" style="font-family: 'Mogra', cursive;: " type="text" value="password" placeholder="Set a Password" required autocomplete="off"/>
                    </div>

                    <button name="register_btn" type="submit" class="button button-block">Get Started</button>
                </form>

            </div>

        </div>

        <footer>
            <p>Site By Bear With Me Copyright (c) 2016 Copyright Holder All Rights Reserved.</p>
        </footer>

        <?php
        if (isset($_POST['register_btn'])) {
            session_start();
            $host = 'studmysql01.fhict.local';
            $user = 'dbi359591';
            $pass = 'tejkomie';
            $db = 'dbi359591';
            $mysqli = new mysqli($host, $user, $pass, $db) or die($mysqli->error);
            $regi_username = $_POST['Name'];
            $regi_password = $_POST['Password'];
            $regi_address = $_POST['Address'];
            $regi_email = $_POST['Email'];
            $NUMBER = 2;
            $check = $mysqli->query("select Email from webvisitor where Email= $regi_email;");
            if ($check->num_rows == 0) {

                $sql = "INSERT INTO visitor(RFID,Name,Address, HasEntered,IsWebUser) VALUES ('utiyityui','$regi_username' ,'$regi_address', 0,1);";

                $checkID = $mysqli->query("select idVisitor from visitor ORDER BY idVisitor DESC LIMIT 1;");

                $row = $checkID->fetch_assoc();
                $what = $row["idVisitor"];
                $sqlWeb = "INSERT INTO webvisitor(Visitor_idVisitor,Email,Password,EventAccount) VALUES ($what,'$regi_email','$regi_password',-50);";


                $success = $mysqli->query($sql);
                if ($success) {
                    $success1 = $mysqli->query($sqlWeb);
                    if ($success1) {

                    }
                } else {

                }

                //  $_SESSION['message'] = "You are registered in";
                // $_SESSION['username'] = $username;
                //header("Location: Events.html");
                die();
            } else if ($checkrows > 0) {
                $_SESSION['message'] = "Visitor exists";
            } else {
                $_SESSION['message'] = "You are not registered";
            }
        }
        ?>

    </body>
</html>
