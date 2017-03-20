<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addCal.aspx.cs" Inherits="addCal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products Add</title>
    <link rel="stylesheet" type="text/css" href="stylesheet2.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go Back" />
        <br />
        <br />
        Choose product:
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="151px">
            </asp:DropDownList>
        &nbsp;
        </p>
        <p>
            Amount:<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 16px" Width="68px">gramm</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 0px" Text="Logout" />
        </p>
        </div>
        
    </form>
</body>
</html>
