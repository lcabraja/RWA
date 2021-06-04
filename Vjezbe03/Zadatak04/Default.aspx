<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zadatak04.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zadatak04</title>
    <style>
        .container {
            width: 400px;
            margin: auto;
            margin-top: 10rem;
        }

        .wide {
            width: 150px;
            height: 250px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <table>
                <tr>
                    <td>
                        <asp:Label Text="On offer" runat="server" />
                    </td>
                    <td></td>
                    <td>
                        <asp:Label Text="Selected" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ListBox CssClass="wide" ID="onOffer" runat="server" SelectionMode="Single" OnSelectedIndexChanged="onOffer_SelectedIndexChanged" />
                    </td>
                    <td>
                        <asp:Button ID="btLeft" Text="<" runat="server" OnClick="btLeft_Click" />
                        <br />
                        <asp:Button ID="btRight" Text=">" runat="server" OnClick="btRight_Click" />
                    </td>
                    <td>
                        <asp:ListBox CssClass="wide" ID="selected" runat="server" SelectionMode="Single" OnSelectedIndexChanged="selected_SelectedIndexChanged"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
