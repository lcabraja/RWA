<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Footer.ascx.cs" Inherits="Zadatak01.Footer" %>

<style>
    .footer-container {
        width: 400px;
        margin: auto;
    }
</style>
<div class="footer-container">
    <hr />
    <asp:LinkButton ID="changeDate" runat="server" OnClick="changeDate_Click" />
</div>
