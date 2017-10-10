<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebClientLb2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br/>
        <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="579px"></asp:TextBox><br/>
        <asp:TextBox ID="TextBox3" runat="server" Height="22px" Width="577px"></asp:TextBox><br/>
    </div>
    </form>
</body>
</html>
