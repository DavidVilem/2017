<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormListaAlumnos.aspx.cs" Inherits="SimpleFormulario.Alumno.FormListaAlumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                <table width=" 60%" border="1">
                    <tr>
                        <th>ID</th><th>Nombre</th><th>Apellido</th><th>Edad</th><th>Profesion</th><th>Editar</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval ("Id") %></td>
                    <td><%# Eval ("Nombre") %></td>
                    <td><%# Eval ("Apellido") %></td>
                    <td><%# Eval ("Edad") %></td>
                    <td><%# Eval ("Profesion") %></td>
                    <td><a href="FormEditarAlumno.aspx?IdUser=<%#Eval("Id")%>">Editar</a></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
            </asp:Repeater>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" >LinkButton</asp:LinkButton>
        </div>
    </form>
</body>
</html>
