<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Zadatak03.Order" %>

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
        .tall {
            width: 100%;
            height: 5rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 id="welcome" runat="server" />
            <asp:Label Text="Article" runat="server" />
            <br />
            <asp:TextBox ID="tbArticle" runat="server" />
            <br />
            <asp:Button ID="btAddToCart" Text="Add to cart" runat="server" OnClick="btAddToCart_Click" />
            <br />
            <asp:Label Text="Cart" runat="server" />
            <br />
            <asp:TextBox ID="tbCart" CssClass="tall" TextMode="MultiLine" ReadOnly="true" runat="server" />
            <br />
            <asp:Button ID="btGoToSummary" Text="Finish" runat="server" OnClick="btGoToSummary_Click" />
            <br />
            <asp:Label ID="lbTooltip" ForeColor="Red" runat="server" />
        </div>
    </form>
</body>
</html>
