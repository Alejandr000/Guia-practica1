using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class CategoriaLogica
    {

        private CategoriaDatos Datos = new CategoriaDatos();

        public DataTable ListaCategoria()
        {



            return Datos.selectCategoriaDatos();
        }
        public DataTable ListaProducto()
        {



            return Datos.selectProducto();
        }
    }
}
