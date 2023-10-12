<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PetShop.Views.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="Styling/Header.css" rel="stylesheet" type="text/css" />
    <link href="Styling/Body.css" rel="stylesheet" type="text/css"/>
    <link href="Styling/Home.css" rel="stylesheet" type="text/css"/>
    <style type="text/css">
        .v39_859 {
            height: 18px;
        }
    </style>
</head>
<body>
    <div class="fContainer">
        <nav class="wrapper">
            <div class ="brand">
                <div class="firstname">Pet</div>
                <div class="lastname">Diary</div>
            </div>
            <ul class="navigation">
                <li><a href="Home.aspx">Home</a></li>                                                        
                    <li><a href="UpdateProfile.aspx">Update Profile</a></li>    
                    <li><a href="aboutus.aspx">About Us</a></li>                                     
                    <li><a href="Login.aspx">Login</a></li>
                    <li><a href="Register.aspx">Register</a></li>  
                    
                        <li><a href="Logout.aspx">Logout</a></li>
            </ul>
        </nav>
    </div>
    <div class="content">
        <h1>Choose your type of Pet!</h1>
        <div class="itemsContainer">
            <li><a href="#"><img src="../Assets/lizard.png" alt="Lizard"></a></li>
            <li><a href="#"><img src="../Assets/dog.png" alt="Dog"></a></li>
            <li><a href="#"><img src="../Assets/bird.png" alt="Bird"></a></li>
            <li><a href="#"><img src="../Assets/cat.png" alt="Cat"></a></li>
            <li><a href="#"><img src="../Assets/mouse.png" alt="Mouse"></a></li>
            <li><a href="#"><img src="../Assets/fish.png" alt="Fish"></a></li>
        </div>

    </div>

    <div class="hContainer">
        <footer>
            <nav class="wrapper">
                <div class ="brand">
                    <div class="footername">Bringing Happiness for You</div>
                </div>
                <ul class="navigation">
                    <li><a href="">Follow Us on:</a></li>
                    <li><a href="">Instagram</a></li>
                    <li><a href="">Twitter</a></li>
                    <li><a href="">Facebook</a></li>
                    <!-- authenticated -->
                    <!-- <li><img src="" alt></li> -->
                </ul>
            </nav>
        </footer>
    </div>
</body>
</html>
