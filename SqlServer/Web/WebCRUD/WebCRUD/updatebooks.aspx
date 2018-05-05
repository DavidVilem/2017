<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updatebooks.aspx.cs" Inherits="WebCRUD.updatebooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
        Update Book</h2>
        <table>
             <tr>
                <td>Book ID</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="btnGetDetails" runat="server" Text="Get Details" OnClick="btnGetDetails_Click" />
                </td>
            </tr>
       
            <tr>
                <td>
                    Book Title</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Authors</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Price</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td>
                    Publisher</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
            
            
        </table>
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update Book" Enabled="false" OnClick="btnUpdate_Click" /><br />
        <br />
        <asp:Label ID="Label2" runat="server" EnableViewState="False"></asp:Label><br />
        <p />
            <a href="Menu.aspx">Menu.aspx</a>
        </div>
    </form>
</body>
</html>
