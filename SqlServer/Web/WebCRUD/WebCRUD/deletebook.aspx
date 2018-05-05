<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deletebook.aspx.cs" Inherits="WebCRUD.deletebook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Delete Book</h2>
            Enter Book Id : 
            <asp:TextBox ID="txtAlumnoid" runat="server"></asp:TextBox>
            <p />
            <asp:Button ID="btnDelete" runat="server" Text="Delete Book" OnClick="btnDelete_Click"/>
            <p />
            <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>
            <p />
            <a href="Menu.aspx">Menu.aspx</a>
        </div>
    </form>
</body>
</html>
