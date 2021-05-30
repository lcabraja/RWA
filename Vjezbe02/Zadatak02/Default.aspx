<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zadatak02.Default" %>

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
                            Text="Country"
                            />
                    </td>
                    <td>
                        <asp:DropDownList
                            ID="dlCountry"
                            runat="server"
                            AutoPostBack="true"
                            OnSelectedIndexChanged="dlCountry_SelectedIndexChanged"
                            />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label
                            ID="label2"
                            runat="server"
                            Text="City"
                            />
                    </td>
                    <td>
                        <asp:DropDownList
                            ID="dlCities"
                            runat="server"
                            AutoPostBack="true"
                            />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
