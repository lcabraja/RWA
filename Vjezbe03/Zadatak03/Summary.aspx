<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="Zadatak03.Summary" %>

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
            <h1 ID="welcome" runat="server" />
            <h2 id="dox" runat="server" />
            <asp:BulletedList ID="pongrac" BulletStyle="Disc" runat="server" />
        </div>
    </form>
</body>
</html>
