<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta charset="utf-8"/>
    <title>Conexion C# con Sql Server</title>
    <link href="/public/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">    
</head>
<body>
    <div class="container">
        <div class="border border-primary">
            <div class="card-header">Conexion Sql Server</div>
            <div class="card-body">
                <p>
                    <a href="Add.aspx" class="btn btn-success">Agregar</a>
                </p>
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Nombre</th>
                            <th>Correo</th>
                            <th>Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                        <%
                            while (getRegistro().Read())
                            {
                                %>
                                <tr>
                                    <td><%=getRegistro()["id"]%></td>
                                    <td><%=getRegistro()["Nombre"]%></td>
                                    <td><%=getRegistro()["Correo"]%></td>
                                    <td>
                                        <a href=""><span class="glyphicon glyphicon-pencil" aria-hidden="true"></span></a>
                                        <a href=""><span class="glyphicon glyphicon-trash" aria-hidden="true"></span></a>
                                    </td>
                                </tr>

                                <%
                            }
                        %>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <script type="text/html" src="~/public/js/jquery.js"></script>
</body>
</html>
