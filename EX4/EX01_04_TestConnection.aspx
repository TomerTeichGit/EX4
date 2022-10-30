<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX01_04_TestConnection.aspx.cs" Inherits="EX4.EX01_04_TestConnection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--<div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="FIELD REQUIRED"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="ONLY NUMBERS" ValidationExpression="\d*"></asp:RegularExpressionValidator>
        </div>--%>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="70px" Width="305px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Height="70px" OnClick="Button1_Click" Text="connect" Width="230px" />
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add Kind" />
        </p>
        <asp:Label ID="LabelMsg" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
