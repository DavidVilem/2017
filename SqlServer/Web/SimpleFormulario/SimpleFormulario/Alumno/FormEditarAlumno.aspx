<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormEditarAlumno.aspx.cs" Inherits="SimpleFormulario.Alumno.FormEditarAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
        <div class="row">
        <div class="col-lg-12">

    <table style="width:100%;">
            <tr>
                <td class="auto-style2">Id:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3">Nombre:</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Apellido:</td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Edad</td>
                <td>
                    <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Profesion</td>
                <td>
                    <asp:TextBox ID="TextProfesion" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Eliminar" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Actualizar" />
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
</div>

        </div>

    </div>
        </div>
    </form>
</body>
</html>
