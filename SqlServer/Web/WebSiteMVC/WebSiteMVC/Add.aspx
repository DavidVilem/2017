<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8"/>
    <title>Conexion C# con Sql Server</title>
    <link href="/public/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">    
</head>
<body>
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Agregar registros</div>
            <div class="panel-body">
                <nav aria-label="breadcrumb">
                  <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="Default.aspx">Inicio</a></li>
                    <li class="active" >Agregar Registro</li>
                  </ol>
                    <!--Formulario-->
                    <form runat="server" method="post" id="form">  
                        <p>
                            <asp:ValidationSummary runat="server" HeaderText="" DisplayMode="BulletList" CssClass="alert alert-danger"/>
                        </p>
                        <p>
                            <asp:Label runat="server">Nombre: </asp:Label>
                            <asp:TextBox ID="nombre" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="nombre" ErrorMessage="Campo Requerido" Display="None"></asp:RequiredFieldValidator>
                        </p>
                        <p>
                            <asp:Label runat="server">Email: </asp:Label>
                            <asp:TextBox ID="correo" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="correo" ErrorMessage=" correo Campo Requerido" Display="None"></asp:RequiredFieldValidator>

                            <asp:RegularExpressionValidator ControlToValidate="correo" ErrorMessage="Email ingresado no valido" Display="None" ValidationExpression="^[\w-]+@[\w-]+\.(com|net|org|edu|mil)$" runat="server"></asp:RegularExpressionValidator>
                        </p>
                        <hr />
                        <asp:Button ID="enviar_form" runat="server" Text="Enviar" CssClass="btn btn-default" OnClick="ProcesarFormulario" />
                    </form>
                    <!--FIN Formulario-->

                </nav>
            </div>
        </div>
    </div>
    <script type="text/html" src="~/public/js/jquery.js"></script>
</body>
</html>
