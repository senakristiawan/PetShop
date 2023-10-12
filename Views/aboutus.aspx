<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aboutus.aspx.cs" Inherits="PetShop.Views.aboutus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>aboutus</title>
    <link href="Styling/Header.css" rel="stylesheet" type="text/css" />
    <link href="Styling/Body.css" rel="stylesheet" type="text/css"/>
    <link href="Styling/aboutus.css" rel="stylesheet" type="text/css"/>
    <style type="text/css">
        .v39_859 {
            height: 18px;
        }
    </style>
    </head>
<body>
    <div class="fContainer">
        <nav class="wrapper">
            <div class="brand">
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
        <h1>Pet’s Diary provides and accomodate a variety of your pet's needs with guaranteed good quality and is friendly to the pets you love. Pet’s Diary also helps to connect you with professional doctor, which will guide and ready to answer any of your
            worries.
        </h1>
        <div class="itemsContainer">
            <li>
                <a href="#"><img src="../Assets/image 11.png" alt="Lizard"></a>
            </li>
            <li>
                <a href="#"><img src="../Assets/pds.png" alt="Lizard"></a>
            </li>
        </div>

    </div>

    <div class="hContainer">
        <footer>
            <nav class="wrapper">
                <div class="brand">
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
