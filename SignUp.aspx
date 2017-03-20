<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Singing up</title>
    <link rel="stylesheet" type="text/css" href="Stylesheet2.css">
    <script src="JavaScript.js"></script>
    <style type="text/css">
        #errorMsgArea {
            margin-top: 15px;
        }
    </style>
</head>
<body>
    <form id="SignUpForm" runat="server" onsubmit="return validationForm();">
    <div id="SignUp">
    <h1>Registration form</h1>
     <p>*First Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> </p>
     <p>*Last Name: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> </p>
     <p>*E-mail address: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> </p>
     <p>*Password:  <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox> </p>
     <p>*Confirm Password: <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox> </p>
     <p>*Your age: <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox> </p>
     <p>*Your weight(kg): <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox> </p>
     <p>*Your height(sm): <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox> </p>
        *Your purpose<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 40px" Width="178px">
            <asp:ListItem Value="gain">Gain weight</asp:ListItem>
            <asp:ListItem Value="loss">Weight loss</asp:ListItem>
            <asp:ListItem Value="keep">Keep the weight</asp:ListItem>
        </asp:DropDownList>
        <br />
     <asp:Button ID="Button1" runat="server" Text="Submit" OnClick ="Button1_Click" /> <input id="Reset1" type="reset" value="Reset" />  <a href ="Login.aspx">Sign in</a>

    </div>
        <div id="errorMsgArea">
                <span id="checkName"></span><br>
                <span id="checkEmail"></span><br>
                <span id="checkPass"></span><br><br>
                <span id="checkPhone"></span><br>
                <span id="checkWebsite"></span>
            </div>
    </form>
</body>
</html>
