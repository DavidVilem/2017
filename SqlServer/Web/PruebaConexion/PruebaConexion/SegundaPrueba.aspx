<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SegundaPrueba.aspx.cs" Inherits="PruebaConexion.SegundaPrueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                <table width=" 60%" border="1">
                    <tr>
                        <th>Nombre</th><th>Apellido</th><th>Edad</th><th>Profesion</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval ("Nombre") %></td>
                    <td><%# Eval ("Apellido") %></td>
                    <td><%# Eval ("Edad") %></td>
                    <td><%# Eval ("Profesion") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
