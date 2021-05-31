<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Default" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zadatak04</title>
</head>
<body>
    <fieldset>
        <legend>User Data
        </legend>
        <form id="form1" runat="server">
            <div>
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
                            <asp:RequiredFieldValidator
                                ID="RequiredFieldValidator2"
                                runat="server"
                                ControlToValidate="tbName"
                                ForeColor="Red"
                                ErrorMessage="Name was not entered.">*
                            </asp:RequiredFieldValidator>
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
                            <asp:RequiredFieldValidator
                                ID="RequiredFieldValidator1"
                                runat="server"
                                ControlToValidate="tbSurname"
                                ForeColor="Red"
                                ErrorMessage="Surname was not entered.">*
                            </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label
                                ID="label3"
                                runat="server"
                                Text="Age" />
                        </td>
                        <td>
                            <asp:TextBox
                                ID="tbAge"
                                runat="server" />
                            <asp:RequiredFieldValidator
                                ID="rqName"
                                runat="server"
                                ControlToValidate="tbAge"
                                ForeColor="Red"
                                ErrorMessage="Age was not entered.">*
                            </asp:RequiredFieldValidator>
                            <asp:RangeValidator
                                ID="rqAge"
                                runat="server"
                                ControlToValidate="tbAge"
                                ForeColor="Red"
                                ErrorMessage="Age outside of valid range. (0-150)"
                                MinimumValue="0"
                                MaximumValue="150"
                                Type="Integer">*
                            </asp:RangeValidator>
                            <asp:CompareValidator
                                ID="compare"
                                runat="server"
                                ControlToValidate="tbAge"
                                ForeColor="Red"
                                ErrorMessage="A number was not entered"
                                Operator="DataTypeCheck"
                                Type="Integer">*
                            </asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label
                                ID="label4"
                                runat="server"
                                Text="Email" />
                        </td>
                        <td>
                            <asp:TextBox
                                ID="tbEmail"
                                runat="server" />
                            <asp:RequiredFieldValidator
                                ID="RequiredFieldValidator3"
                                runat="server"
                                ControlToValidate="tbEmail"
                                ForeColor="Red"
                                ErrorMessage="Email was not entered.">*
                            </asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator
                                ID="regex"
                                runat="server"
                                ControlToValidate="tbEmail"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                EnableClientScript="true"
                                Display="Static"
                                ForeColor="Red"
                                ErrorMessage="Wrong Email format">*
                            </asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label
                                ID="label5"
                                runat="server"
                                Text="Username (must be even number)" />
                        </td>
                        <td>
                            <script language="javascript"> 
                                function ClientValidate(source, arguments) {
                                    if (arguments.Value % 2 == 0) {
                                        arguments.IsValid = true;
                                    } else {
                                        arguments.IsValid = false;
                                    }
                                }
                            </script>
                            <asp:TextBox
                                ID="tbUsername"
                                runat="server" />
                            <asp:RequiredFieldValidator
                                ID="RequiredFieldValidator4"
                                ControlToValidate="tbUsername"
                                runat="server"
                                ForeColor="Red"
                                ErrorMessage="Username was not entered.">*
                            </asp:RequiredFieldValidator>
                            <asp:CompareValidator
                                ID="CompareValidator1"
                                runat="server"
                                ControlToValidate="tbUsername"
                                ForeColor="Red"
                                ErrorMessage="Username must be an even integer"
                                Operator="DataTypeCheck"
                                Type="Integer">*
                            </asp:CompareValidator>
                            <asp:CustomValidator
                                ID="customUsernameValidator"
                                ControlToValidate="tbUsername"
                                ForeColor="Red"
                                Display="Dynamic"
                                ErrorMessage="Username invalid, must be an even integer."
                                OnServerValidate="customUsernameValidator_ServerValidate"
                                ClientValidationFunction="ClientValidate"
                                runat="server">*
                            </asp:CustomValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label
                                ID="label6"
                                runat="server"
                                Text="Password" />
                        </td>
                        <td>
                            <asp:TextBox
                                ID="tbPassword"
                                TextMode="Password"
                                runat="server" />
                            <asp:RequiredFieldValidator
                                ID="RequiredFieldValidator6"
                                runat="server"
                                ControlToValidate="tbPassword"
                                ForeColor="Red"
                                ErrorMessage="Password was not entered.">*
                            </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label
                                ID="label7"
                                runat="server"
                                Text="Repeat password" />
                        </td>
                        <td>
                            <asp:TextBox
                                ID="tbPasswordRepeat"
                                TextMode="Password"
                                runat="server" />
                            <asp:RequiredFieldValidator
                                ID="RequiredFieldValidator5"
                                runat="server"
                                Display="Dynamic"
                                ControlToValidate="tbPasswordRepeat"
                                ForeColor="Red"
                                ErrorMessage="Password was not repeated.">*
                            </asp:RequiredFieldValidator>
                            <asp:CompareValidator
                                ID="comparePasswordValidator"
                                ControlToValidate="tbPasswordRepeat"
                                ControlToCompare="tbPassword"
                                runat="server"
                                ForeColor="Red"
                                ErrorMessage="Passwords do not match">*
                            </asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button
                                ID="btSend"
                                runat="server"
                                OnClick="btSend_Click"
                                Text="Send" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:ValidationSummary
                                ID="summary"
                                runat="server"
                                ForeColor="Red" />
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </fieldset>
</body>
</html>
