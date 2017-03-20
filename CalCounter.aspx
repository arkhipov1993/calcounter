<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalCounter.aspx.cs" Inherits="CalCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calorie Counter</title>
    <link rel="stylesheet" type="text/css" href="stylesheet2.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Label1" runat="server"></asp:Label> 
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go Back" Width="91px" />
        <br/>
     <p>Calories per day:</p>
     <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="116px"></asp:TextBox>
     <p>Calories consumed:</p>
     <asp:TextBox ID="TextBox2" runat="server" Enabled="False" Width="116px"></asp:TextBox> 
        <br />
        <br />
        
     <asp:Button ID="Button1" runat="server" Text="Add products you ate " Width="230px" OnClick="Button1_Click" />
    &nbsp;<br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Logout" />
    </div>
       
        
       
    </form>
</body>
</html>
