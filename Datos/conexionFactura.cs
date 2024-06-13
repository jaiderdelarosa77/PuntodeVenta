using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class conexionFactura
    {
        static string conexion = "server=localhost;database=PuntodeVenta;integrated security=true";

        SqlConnection con=new SqlConnection(conexion);

        public string consultaFactura()
        {
            con.Open();
            string query = "Select(Select distinct top 1 NumFactura from Facturacion order by NumFactura desc)+1 as NumFactura";
            SqlCommand cmd=new SqlCommand(query, con);
            SqlDataReader reg= cmd.ExecuteReader();

            if (reg.Read())
            {
                return reg["NumFactura"].ToString();
            }
            else
            {
                return "NULL";
            }
            con.Close();
        }
    }
}
