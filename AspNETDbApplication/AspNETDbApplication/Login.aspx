<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AspNETDbApplication.Login"   %>
<trace enabled="true"></trace>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/LoginCss.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            background-color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <label><b>Username</b></label>
            <input type="text" placeholder="Enter Username" name="uname" runat="server" id="txtUserName" required>
  
            <label><b>Password</b></label>
            <input type="password" placeholder="Enter Password" name="psw" runat="server" id="txtPassword" required>
  
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click"  Text="Login" CssClass="auto-style1" Height="34px" Width="118px"/>
            <input type="checkbox" checked="checked"> Remember me
        </div>
  
        <div class="container" style="background-color:#f1f1f1">
            <button type="button" class="cancelbtn">Cancel</button>
            <span class="psw">Forgot <a href="#">password?</a></span>
        </div>
        <div class="container" style="background-color:azure">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
