<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PetShop.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Styling/Header.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav id="navbar">
                <ul>
                    <li><a href="Home.aspx">Home</a></li>                                                        
                    <li><a href="UpdateProfile.aspx">Update Profile</a></li>    
                    <li><a href="AboutUs.aspx">About Us</a></li>                          
                    <li><a href="Login.aspx">Login</a></li>
                    <li><a href="Register.aspx">Register</a></li> 
                    <li><a href="Logout.aspx">Logout</a></li>
                
                </ul>
            </nav>
        </div>  
        <div>
             <h3>Login</h3>
            <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="passwordTxt" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="loginBtn" runat="server"  Text="Login" OnClick="loginBtn_Click" />

            <br />

            <asp:CheckBox ID="rememberChk" runat="server" OnCheckedChanged="rememberChk_CheckedChanged" />
            <asp:Label ID="rememberLbl" runat="server" Text="Remeber Me"></asp:Label>

            <br />

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Register.aspx">Don't have an account ? Register now</asp:HyperLink>

            <br />

            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
