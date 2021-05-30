<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zadatak01.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>RWA - Vjezbe02 - Zadatak01</h1>
            <table>
                <tr>
                    <td>
                        <asp:Label
                            ID="label1"
                            runat="server"
                            Text="Name" />
                    </td>
                    <td>
                        <asp:TextBox
                            ID="tbName"
                            runat="server" />
                    </td>
                    <td>
                        <asp:Panel
                            ID="pnOut"
                            runat="server"
                            Visible="false" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label
                            ID="label2"
                            runat="server"
                            Text="Surname" />
                    </td>
                    <td>
                        <asp:TextBox
                            ID="tbSurname"
                            runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label
                            ID="label3"
                            runat="server"
                            Text="Grad" />
                    </td>
                    <td>
                        <asp:DropDownList
                            ID="dlCity"
                            runat="server"
                            />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label
                            ID="label4"
                            runat="server"
                            Text="Sex" />
                    </td>
                    <td>
                        <asp:RadioButtonList
                            ID="rbSex"
                            runat="server"
                            />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label
                            ID="label5"
                            runat="server"
                            Text="Drivers licence" />
                    </td>
                    <td>
                        <asp:Checkbox
                            ID="chDrivers"
                            runat="server"
                            />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button
                            ID="btOut"
                            runat="server"
                            Text="Output data..."
                            OnClick="btOut_Click"
                            />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
