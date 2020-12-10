<!DOCTYPE html>
<html >
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>LogIn Form</title>
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

        <div id="login">
          <h1>Welcome Back!</h1>

          <form class="classy" action="LogIn.php" method="post">

            <div class="field-wrap">
                    <input name="email" style="font-family: 'Mogra', cursive;: " type="email" placeholder="E-Mail Address" required="" autocomplete="off"/>
                    </div>

                    <div class="field-wrap">
                    <input name="password" style="font-family: 'Mogra', cursive;: " type="password" placeholder="Your Password" required="" autocomplete="off"/>
                    </div>

          <p class="forgot"><a href="">Forgot Password?</a></p>

          <button name="login_btn" type="submit" class="button button-block">Log In</button>

          </form>

        </div>


</div>
    <?php
    if (isset($_POST['login_btn']))
{
    session_start();
    $db = mysqli_connect("studmysql01.fhict.local", "dbi359591", "tejkomie", "dbi359591");
    $email = mysqli_real_escape_string($db, $_POST['email']);
    $password = mysqli_real_escape_string($db, $_POST['password']);
    $increment = 7700;
    $increment++;
    $body = "this is your code for entering the event! $increment";
    $subject = "Registration";
    $sqllogin = "Select * From webvisitor Where Email = '$email' and Password = '$password'";
    $result = mysqli_query($db, $sqllogin);
    if(mysqli_num_rows($result)== 1)
    {
       // mail($email, $subject , $body);
        $_SESSION['message'] = "You are logged in";
        $_SESSION['username']= $email;
        header("Location: http://i359591.iris.fhict.nl/LogOut.php");
        exit();
    }
    else {
        $_SESSION['message'] = "Wrong Username or Password";

    }
}
?>


  <footer>
        <p>Site By Bear With Me Copyright (c) 2016 Copyright Holder All Rights Reserved.</p>
      </footer>

</body>
</html>
