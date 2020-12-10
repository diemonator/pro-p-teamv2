<!DOCTYPE html>

<?php

require_once 'class.phpmailer.php';
if (isset($_POST['registerbtn'])) {
    
    $_SESSION['username'] = session_name();
    session_start();
    $db = mysqli_connect("studmysql01.fhict.local", "dbi359591", "tejkomie", "dbi359591");
    $checkID = $db->query("select idVisitor from visitor ORDER BY idVisitor DESC LIMIT 1;");

    $checkDepositID = $db->query("select idDepositLine from depositline ORDER BY idDepositLine DESC LIMIT 1;");




    $amount = $_POST['depositAmounth'];
    $depositedAmounth = depositAmounth;

    $row = $checkID->fetch_assoc();
    $what = $row["idVisitor"];

    $depositId = $checkDepositID->fetch_assoc();

    
    $deposit = $depositId["idDepositLine"];
    /* Querrita za popravqne */

    $answer = $_POST['radio1'];
   
    if ($answer == 'camping') {
        
    
    $sql = "INSERT INTO depositline(idDepositLine,Amount,PayPal_idPayPal,Visitor_idVisitor) Values($deposit + 1,$amount, 123456789,$what)";
    mysqli_query($db, $sql);
   
    $static = $db->query("select idReservation from reservation ORDER BY idReservation DESC LIMIT 1;");
    $reservationIDrow = $static->fetch_assoc();
    $reservationID = $reservationIDrow["idReservation"];
 
    $sqlReservation = "INSERT INTO Reservation(idReservation,HasEnteredEvent,DepositLine_idDepositLine,DepositLine_PayPal_idPayPal) Values($reservationID + 1,0,$deposit + 1,123456789)";
    mysqli_query($db, $sqlReservation);
}
 else {

   
    $sql = "INSERT INTO depositline(idDepositLine,Amount,PayPal_idPayPal,Visitor_idVisitor) Values($deposit + 1,$amount, 123456789,$what)";
}
    $checkEmail = $db->query("select Email from webvisitor as w JOIN depositline as d ON w.Visitor_idVisitor = d.Visitor_idVisitor AND w.Visitor_idVisitor = 73603 Order by Email DESC LIMIT 1;");
    $subject = 'Registration for camping site is completed this is your entrence number. Show this number on the entrence ';
    $clientRow = $checkEmail->fetch_assoc();
    $clientEmail = $clientRow["Email"];
    
    $mail = new PHPMailer();
    $mail->From = 'http://i359591.iris.fhict.nl';
    $mail->FromName = 'Event Oasis';
    $mail->Subject = 'Registration for camping site is completed this is your entrence number. Show this number on the entrence ';
    $mail->Body = 'if someting with the ticket goes wrong use this code -> '.$deposit;
    $mail->AddAddress($clientEmail);
    $mail->AddAttachment();
    $mail->Send();
  
    //mail($clientEmail, $subject, $message);
}
?>
<html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="CSS/optimizedVisual.css">
        <script src="JavaScript\AnimationMarto.js"></script>
        <link href="https://fonts.googleapis.com/css?family=Mogra" rel="stylesheet">
        <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
        <title>Contact</title>
    </head>

    <body>
        <header>
            <a href="LogIn.php"><img class="login" src="Images\lmao.png" alt="Images\lmao.png"></a>

            <a href="Register.php"><img class="reg" src="Images\vcvc.png" alt="Images\vcvc.png"></a>

            <a href="index.html"><img class="navImage" src="Images\bearWithMeLogo.png" alt=".!."></a>
        </header>

        <nav>
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
            <li><a href="Index.html">Home</a></li>
            <li><a href="Gallery.html">Gallery</a></li>
            <li><a href="Events.html"> Events</a></li>
            <li><a href="About us.html">About us</a></li>
            <li><a href="Contact.php">Contact</a></li>
        </nav>
        <div id="paraBody">


            <p >Congradulations!!! You're almost there, just one more step and the tickets for the trip are yours. Simply click the 'DOWNLOAD' button and
                save your ticket. Make sure to print it afterwards as you will need it when you get to the event.  </p>
        </div>
        <div class="imgHolder">
            <?php echo ' <img style="width: 1200px; height: 440px;  display: block;
                 margin: 2% auto;"
                 src="Images\ticket2.jpg" alt="ticket.pdf">
            <a  href="Images\ticket.pdf" download><img style = "display: block;margin: 2% auto;"  src="Images\download.png" alt="download"/></a>
            ';
            ?>
        </div>

        <footer>
            <p>Site By Bear With Me Copyright (c) 2016 Copyright Holder All Rights Reserved.</p>
        </footer>

    </body>
</html>
