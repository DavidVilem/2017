<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebCRUD.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Books CRUD Application</title>
    <style>
     a  { font-weight:700; color:red;font-size:12pt}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Books CRUD Application</h2>
                This application shows how to perform Create, Retrieve, Update and Delete operations on BOOKS table through ADO.NET. 
                <p />
                ASP.NET pages access the BOOKS table through SQL using ADO.NET.
                <p />

                <a href="addbook.aspx">Add New Book</a>
                <p />
                <a href="updatebooks.aspx">updatebooks.aspx</a>
                <p />
                <a href="deletebook.aspx">Delete Book</a>
                <p />
                <a href="listbooks.aspx">List Books</a>
        </div>
    </form>
</body>
</html>
