<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarAlumno.aspx.cs" Inherits="GridViewCRUD.AgregarAlumno" %>

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
                    <td>Nombre</td>
                    <td>
                        <asp:TextBox ID="TxtBoxNombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Apellido</td>
                    <td>
                        <asp:TextBox ID="TxtBoxApellido" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Edad</td>
                    <td>
                        <asp:TextBox ID="TxtBoxEdad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Carrera</td>
                    <td>
                        <asp:TextBox ID="txtBoxCarrera" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Crear" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="lblMensajes" runat="server" EnableViewState="False"></asp:Label>
            <br />
            <a href="FromGridCRUD.aspx">Menu</a>

        </div>
    </form>
</body>
</html>
