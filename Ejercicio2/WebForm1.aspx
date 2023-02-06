<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Ejercicio 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container d-flex justify-content-center mt-5">



            <div class="card text-center text-danger" id="sesionE"  runat="server" style="width:20rem">

                <div class="card-body">


                    <label>Error al iniciar sesion</label>
                </div>
            </div>
              <div class="card text-center" id="sesionI"  runat="server" style="width:20rem">

                <div class="card-body ">


                    <label class="text-success  ">Sesion iniciada</label>
                </div>
            </div>



             <div class="card position-static" id="log" runat="server" style="width:20rem">
                      <div class="card-body">
                          <h4 class="card-title fw-bold mb-4">Iniciar sesion</h4>

                 <div class="col-lg mb-3">
                    <label class="form-label">Usuario</label>
                    <input class="form-control" id="Text1" type="text" runat="server" />
                </div>
                  <div class="col-lg mb-4">
                    <label class="form-label">Contraseña</label>
                    <input class="form-control" id="Text2" type="text" runat="server"/>
                      
                </div>
                  <div class="col-lg  mb-3">
                      <asp:Button CssClass="btn btn-outline-success  w-100" ID="Button1" runat="server" Text="Iniciar sesion" OnClick="Button1_Click" />
                </div>
                
                      

                      </div>
                  </div>
        </div>
    </form>
</body>
</html>
