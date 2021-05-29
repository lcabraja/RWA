<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Send.aspx.cs" Inherits="Zadatak01.Send" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Send</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/validate.js"></script>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-sm-6">
                <form action="Receive.aspx" method="get">
                    <table class="table">
                        <tr>
                            <td colspan="2">
                                <h3>Send with GET</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="name">Name:</label>
                            </td>
                            <td>
                                <input type="text" name="name" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="surname">Surname:</label>
                            </td>
                            <td>
                                <input type="text" name="surname" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="city">City:</label>
                            </td>
                            <td>
                                <select class="form-control" name="city">
                                    <option>Zagreb</option>
                                    <option>Split</option>
                                    <option>Rijeka</option>
                                    <option>Osijek</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <input
                                    type="submit"
                                    onclick="return confirm('Send with GET?')"
                                    value="Send data with GET method"
                                    class="btn btn-primary form-control" />
                            </td>
                        </tr>
                    </table>
                </form>
            </div>
            <div class="col-sm-6">
                <form action="Receive.aspx" method="post" id="post">
                    <table class="table">
                        <tr>
                            <td colspan="2">
                                <h3>Send with POST</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="name">Name:</label>
                            </td>
                            <td>
                                <input type="text" name="name" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="surname">Surname:</label>
                            </td>
                            <td>
                                <input type="text" name="surname" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="city">City:</label>
                            </td>
                            <td>
                                <select class="form-control" name="city">
                                    <option>Zagreb</option>
                                    <option>Split</option>
                                    <option>Rijeka</option>
                                    <option>Osijek</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <input
                                    type="submit"
                                    onclick="return doPost()"
                                    value="Send data with POST method"
                                    class="btn btn-primary form-control" />
                            </td>
                        </tr>
                    </table>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
