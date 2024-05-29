<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Project1.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <strong>Enter 1st Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter 2nd Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Result:</strong><br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="153px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="35px" Width="162px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="37px" Width="152px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Button ID="Sum" runat="server" Text="Sum" class="btn btn-success" Height="49px" Width="87px" OnClick="Sum_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Sub" runat="server" Text="Sub" class="btn btn-danger" Height="46px" OnClick="Sub_Click" Width="72px"/>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Button ID="Multiply" runat="server" Text="Multiply" class="btn btn-info" Height="49px" OnClick="Multiply_Click" Width="99px"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Divide" runat="server" Text="Divide" class="btn btn-primary" Height="49px" Width="98px" OnClick="Divide_Click"/>
        <br />
    </form>
</body>
</html>
