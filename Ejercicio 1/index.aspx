<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Ejercicio_1.formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Formulario</title>
</head>
<body>
    <div class="container d-flex justify-content-center mt-5">
        
         <form id="form1" runat="server">
              <div class="row ">

                  <div class="card position-absolute z-index-4 " id="resul" runat="server" style="width:20rem">
                      <div class="card-body">
                          <h4 class="card-title fw-bold mb-4">Datos del producto</h4>

                 <div class="col-lg mb-3">
                    <label class="form-label">Nomnbre del producto</label>
                    <input class="form-control" id="Text4" type="text" runat="server" />
                </div>
                  <div class="col-lg mb-3">
                    <label class="form-label">Unidades</label>
                    <input class="form-control" id="Number1" type="number" runat="server"/>
                      
                </div>
                  <div class="col-lg mb-3">
                    <label class="form-label">Precio del producto</label>
                    <input class="form-control" id="Number2" type="number" runat="server" />
                </div>
                 
                       

                          <asp:Button CssClass="btn btn-primary mb-5" ID="Button2" runat="server" Text="X" OnClick="Button2_Click" />

                      </div>
                  </div>






                  <div class="card  position-static" style="width:20rem">
                      <div class="card-body">
                          <h4 class="card-title fw-bold mb-4">Agregar un producto</h4>

                 <div class="col-lg mb-3">
                    <label class="form-label">Nomnbre del producto</label>
                    <input class="form-control" id="Text1" type="text" runat="server" />
                </div>
                  <div class="col-lg mb-3">
                    <label class="form-label">Unidades</label>
                    <input class="form-control" id="Text2" type="number" runat="server"/>
                      
                </div>
                  <div class="col-lg mb-3">
                    <label class="form-label">Precio del producto</label>
                    <input class="form-control" id="Text3" type="number" runat="server" />
                </div>
                  <div class="col-lg mb-3">
                      <asp:Button CssClass="btn btn-outline-primary" ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" />
                </div>
                

                      </div>
                  </div>
                  
                  </div>
    </form>
        
   
        </div>
</body>
</html>
