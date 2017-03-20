<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditAccount.aspx.cs" Inherits="EditAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Account</title>
    <link rel="stylesheet" type="text/css" href="stylesheet2.css">
</head>
<body>
    <form id="SignUpForm" runat="server">
    <div id="SignUp">
    <h1>Account Editor</h1>
     <p>*Your age: <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox> </p>
     <p>*Your weight(kg): <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox> </p>
     <p>*Your height(sm): <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox> </p>
        *Your purpose<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 40px" Width="178px">
            <asp:ListItem Value="gain">Gain weight</asp:ListItem>
            <asp:ListItem Value="loss">Weight loss</asp:ListItem>
            <asp:ListItem Value="keep">Keep the weight</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Account was successfully updated!" Visible="False"></asp:Label>
        <br />
     <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /> <input id="Reset1" type="reset" value="Reset" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go Back" />

    </div>
    </form>
</body>
</html>
