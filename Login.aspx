<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login page</title>
    <link rel="stylesheet" type="text/css" href="stylesheet2.css">
</head>
<body>
    <form id="loginform" runat="server">
    <div id="loginform">
    <p>*Login</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <p>*Password</p>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox> <br />
    <asp:Button ID="Button1" runat="server" Text="Sign in" OnClick="Button1_Click" /> <a href ="SignUp.aspx"> Create a new account</a>
    </div>
        <asp:Label ID="Label1" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
    </form>
    <form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_blank">
<input type="hidden" name="cmd" value="_s-xclick" />
<input type="hidden" name="hosted_button_id" value="VK7ECFXY4M9W8" />
<input type="image" src="https://www.paypal.com/en_US/i/btn/btn_donateCC_LG.gif" border="0" name="submit" title="PayPal - The safer, easier way to pay online!" alt="Donate" style="width: 177px; margin-top: 21px" />
<img alt="" border="0" src="https://www.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1" />
</form>


</body>
</html>
