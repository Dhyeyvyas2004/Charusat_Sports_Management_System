<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="SportDemo.login" %>
    
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    

<head  runat="server">
        <meta charset="UTF-8"/>
        <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <title>Charusat University</title>
        <link rel="stylesheet" href="style.css"/>
        <link href="sport.css" rel="stylesheet" />
       <link rel="shortcut icon" href="images/sprites/download1.png" />
     </head>


  <body>        
            <form id="signinform" runat="server">
                <div class="box">
                <h1>Sign In</h1>
                <div class="inputbox">
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="username" ></asp:TextBox>
                    <%--<label for="username">username</label>--%>
                </div>
             
                <div class="inputbox">
                    <%--<label for="username">password</label>--%>
                <%-- <<asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="User Name Required" ForeColor="Red" ValidationGroup="Login"></asp:RequiredFieldValidator>--%>
                <asp:TextBox ID="psw" runat="server" CssClass="form-control" TextMode="Password" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" title="Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters " placeholder="password" ></asp:TextBox>
                </div>
                   
                 <asp:Button id="btnLogin" text="Sign in" runat ="server" OnClick="btnLogin_Click"  />
                    
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button id="btnRegistraion" text="Register here" runat="server" OnClick="btnRegistraion_Click1" />
                   
        
                    </div>
           
            </form>

    </body>    

    </html>