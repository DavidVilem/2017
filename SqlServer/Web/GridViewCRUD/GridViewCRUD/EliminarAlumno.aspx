<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarAlumno.aspx.cs" Inherits="GridViewCRUD.EliminarAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Alumno ID</td>
                    <td>
                        <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Eliminar" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="LabelMensajes" runat="server" EnableViewState="False"></asp:Label>
            <br />
            <a href="FromGridCRUD.aspx">Menu.aspx</a>
        </div>
    </form>
</body>
</html>
