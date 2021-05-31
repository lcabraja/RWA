<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zadatak01.Default" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zadatak01</title>
    <style>
        .container {
            width: 400px;
            margin-top: 10rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <label>Number of colors</label>
                </td>
                <td>
                    <asp:TextBox
                        ID="tbColors"
                        runat="server"
                        AutoCompleteType="None" />
                    <asp:RangeValidator
                        ID="range"
                        ControlToValidate="tbColors"
                        Type="Integer"
                        MinimumValue="1"
                        MaximumValue="10"
                        ErrorMessage="Number must be between 1 and 10"
                        Text="*"
                        ForeColor="Red"
                        runat="server" />
                    <asp:CompareValidator
                        runat="server"
                        ID="compare"
                        ControlToValidate="tbColors"
                        Type="Integer"
                        Operator="DataTypeCheck"
                        Text="*"
                        ErrorMessage="Must be numerical value"
                        ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button
                        OnClick="submit_Click"
                        ID="submit"
                        runat="server"
                        Text="Create colors" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:ValidationSummary
                        ID="summary"
                        ForeColor="Red"
                        runat="server" />
                </td>
            </tr>
        </table>
        <hr />
        <div id="container" runat="server">
        </div>
        <hr />
        <asp:BulletedList
            ID="othercontainer"
            runat="server" />
    </form>
</body>
</html>
