<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayDateTime.aspx.cs" Inherits="Project1.DisplayDateTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Content/bootstrap.css" rel="stylesheet" />
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <p style="margin-left: 80px">
            <asp:Label ID="DateTimeDisplay" runat="server" Text="Label" BorderStyle="Double" Height="25px"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            &nbsp;</p>
        <p style="margin-left: 80px">
            <asp:Button ID="Button1" runat="server" Text="Click to Current Date & Time" CssClass="btn btn-success" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
