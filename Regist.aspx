<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="SportDemo.Regist" %>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head  runat="server">
        <title>Registration form</title>
        <meta charset="UTF-8"/>
        <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <link rel="stylesheet" href="style.css"/>
        <link href="sport.css" rel="stylesheet" />
     </head>

        <body>
            
     <form id="signinform" runat="server">
                    <div class="box">
                <h1>Register here</h1>

                <%--<div class="inputbox">
                    <input type="text" id="txtUserName" name="username" autocomplete="on" required="required"/>
                    <label for="username">username</label>
                </div>--%>
                        <div class="inputbox">
                      <%--<label for="exampleInputEmail3">Email address</label>--%>
                         <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="username" ></asp:TextBox>
                      </div>
             
                <%--<div class="inputbox">
                    <input type="password" id="psw" autocomplete="off" name="psw" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" title="Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters" required="required" />
                    <label for="username">password</label>
                
                </div>--%>
                         <div class="inputbox">
                      <%--<label for="exampleInputPassword4">Password</1label>--%>
                        <asp:TextBox ID="psw" runat="server" CssClass="form-control" TextMode="Password" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" title="Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters " placeholder="password" ></asp:TextBox>
                        
                    </div>
<%--                        <div class="inputbox">
                    <input type="email" id="txtEmail" name="username" autocomplete="on" required="required"/>
                    <label for="username">email id</label>
                </div>--%>
                        <div class="inputbox">
                    <%--  <label for="txtEmail">Email address</label>--%>
                         <asp:TextBox ID="exampleInputEmail3" runat="server" CssClass="form-control" placeholder="email" ></asp:TextBox>
                      </div>

                        <div class="inputbox">
                   <%-- <input type="number" id="txtphone" name="username" autocomplete="on" required="required"/>
                    <label for="username">phone number</label>
                            <div class="form-group">--%>
                         <asp:TextBox ID="txtphone" runat="server" CssClass="form-control" placeholder="phone number" ></asp:TextBox>
                      </div>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
                            
                </div>

                        
               
               </div>
              </form>

         </form>
      
</body>
        </html>
