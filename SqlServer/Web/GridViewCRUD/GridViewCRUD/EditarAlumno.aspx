<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarAlumno.aspx.cs" Inherits="GridViewCRUD.EditarAlumno" %>

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
                    <td>Alumno Id</td>
                    <td>
                        <asp:TextBox ID="TxtBoxId" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Detalles" OnClick="Button1_Click" />
                    </td>
                </tr>
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
            <asp:Button ID="Button2" runat="server" Text="Actualizar" OnClick="Button2_Click" />
            <br />
            <asp:Label ID="lblMensajes" runat="server" EnableViewState="False"></asp:Label>
            <br />
            <br />
            <a href="FromGridCRUD.aspx">Menu</a>
        </div>
    </form>
</body>
</html>
