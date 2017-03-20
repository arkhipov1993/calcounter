<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loggedInPage.aspx.cs" Inherits="loggedInPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account page</title>
    <link rel="stylesheet" type="text/css" href="stylesheet2.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server"></asp:Label> </br>
        <asp:Button ID="Button2" runat="server" Height="64px" Text="Calories calculator" Width="190px" OnClick="Button2_Click" /> </br>
        </br>
         <asp:Button ID="Button3" runat="server" Height="64px" Text="Edit Account" Width="190px" OnClick="Button3_Click" />
    
        <br />
        <br />
    
        <br />
    
    </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" />
        </p>
        
    </form>
</body>
</html>
