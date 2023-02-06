using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_1
{
    public partial class formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            resul.Visible= false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

         Text4.Value  = Text1.Value;
          Number1.Value   = Text2.Value;
          Number2.Value = Text3.Value;
          resul.Visible = true;

        }
        private void limpiar() {


             Text1.Value = " ";
            Text2.Value = " ";
            Text3.Value = " ";
            resul.Visible = false;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}