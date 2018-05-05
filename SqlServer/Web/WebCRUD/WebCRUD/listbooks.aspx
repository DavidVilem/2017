<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listbooks.aspx.cs" Inherits="WebCRUD.listbooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>List Of Books</h2>
        <asp:GridView ID="GridView1" runat="server" Width="100%">
            <HeaderStyle BackColor="Red" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        <br />
            <a href="Menu.aspx">Menu.aspx</a>
        </div>
    </form>
</body>
</html>
