<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EX4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Refresh" />
            <asp:GridView ID="GridView1" runat="server" >
                </asp:GridView>
            <br />
            <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
        </div>
        <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelError" runat="server" Text="" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
