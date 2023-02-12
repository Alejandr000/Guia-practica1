using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Categoria : System.Web.UI.Page
    {


        private CategoriaLogica log = new CategoriaLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

            GridView1.DataSource = log.ListaCategoria();
            GridView1.DataBind();

            GridView2.DataSource = log.ListaProducto();
            GridView2.DataBind();
        }
    }
}