<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zadatak03.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label
                            ID="label1"
                            runat="server"
                            Text="Name"
                            />
                    </td>
                    <td>
                        <asp:TextBox
                            ID="tbName"
                            runat="server"
                            />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label
                            ID="label2"
                            runat="server"
                            Text="Surname"
                            />
                    </td>
                    <td>
                        <asp:TextBox
                            ID="tbSurname"
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
                            Text="Output"
                            OnClick="btOut_Click"
                            />
                    </td>
                </tr>
                <tr>
                    <td>

                    </td>
                    <td>
                         <asp:Label
                            ID="lbInfo"
                            runat="server"
                             ForeColor="Red"
                            />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
