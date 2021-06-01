<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Zadatak03.Login" UnobtrusiveValidationMode="None" %>

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
            <asp:Label Text="Full Name" runat="server" />
            <br />
            <asp:TextBox ID="tbName" runat="server" />
            <asp:RequiredFieldValidator ErrorMessage="Full Name - Required" ControlToValidate="tbName" runat="server">*</asp:RequiredFieldValidator>
            <hr />
            <asp:Label Text="Address" runat="server" />
            <br />
            <asp:TextBox ID="tbAddress" runat="server" />
            <asp:RequiredFieldValidator ErrorMessage="Address - Required" ControlToValidate="tbAddress" runat="server">*</asp:RequiredFieldValidator>
            <hr />
            <asp:Label Text="E-Mail" runat="server" />
            <br />
            <asp:TextBox ID="tbEmail" runat="server" />
            <asp:RequiredFieldValidator ErrorMessage="E-Mail address - Required" ControlToValidate="tbEmail" runat="server">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ErrorMessage="E-Mail address - Format incorrect" ControlToValidate="tbEmail" runat="server">*</asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="btSubmit" Text="Enter" runat="server" OnClick="btSubmit_Click"/>
            <br />
            <asp:ValidationSummary ID="summary" runat="server" />
        </div>
    </form>
</body>
</html>
