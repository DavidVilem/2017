<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FromGridCRUD.aspx.cs" Inherits="GridViewCRUD.FromGridCRUD" %>

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
            <asp:Button ID="Button1" runat="server" Text="Crear Alumno" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Editar Alumno" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Eliminar Alumno" OnClick="Button3_Click" />
            <br />
            
        </div>
    </form>
</body>
</html>
