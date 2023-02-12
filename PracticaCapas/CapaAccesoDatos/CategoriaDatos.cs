using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class CategoriaDatos
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString);
        public DataTable selectCategoriaDatos()
        {
            SqlCommand comand = new SqlCommand("SelectCategoria",conexion);
            comand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comand);
            DataTable dataTable= new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable selectProducto() {

            SqlCommand comand = new SqlCommand("selectProudcto", conexion);
            comand.CommandType = CommandType.StoredProcedure;   
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comand);    
            DataTable dataTable= new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        
        }
    }
}
