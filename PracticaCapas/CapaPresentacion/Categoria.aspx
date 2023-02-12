<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="CapaPresentacion.Categoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="row justify-content-center  pt-5">
                <p class="text-center">Tabla categoria</p>
                <asp:GridView ID="GridView1" CssClass="table table-striped table-hover " runat="server"></asp:GridView>

            </div>
            <div class="row justify-content-center  pt-5">
                 <p class="text-center">Tabla Producto</p>
                <asp:GridView ID="GridView2" CssClass="table table-striped table-hover " runat="server"></asp:GridView>

            </div>
        </div>



        <script src="Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>
