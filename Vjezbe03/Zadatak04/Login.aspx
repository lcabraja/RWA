<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Zadatak04.Login" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zadatak03</title>
    <style>
        .container {
            width: 400px;
            margin: auto;
            margin-top: 10rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label Text="Username" runat="server" />
            <br />
            <asp:TextBox ID="tbName" runat="server" />
            <hr />
            <asp:Label Text="Password" runat="server" />
            <br />
            <asp:TextBox ID="tbPassword" TextMode="Password" runat="server" />
            <br />
            <asp:Button ID="btSubmit" Text="Enter" runat="server" OnClick="btSubmit_Click" />
            <br />
            <asp:Label ID="lbToolTip" Enabled="false" ForeColor="Red" runat="server" />
            <br />
        </div>
    </form>
</body>
</html>
