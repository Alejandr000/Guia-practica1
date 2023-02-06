using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sesionI.Visible = false;
            sesionE.Visible=false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Text1.Value.ToString() == "" && Text2.Value.ToString()== ""  ) {


                 log.Visible = false;
                sesionE.Visible = true;
             

            }
            else
            {
             
                sesionI.Visible = true;
                log.Visible = false;
            }

        }
    }
}