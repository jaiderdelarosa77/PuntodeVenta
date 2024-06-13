using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class conexionInventario
    {
        static string conexion = "server=localhost; database=PuntodeVenta; integrated security=true";
        SqlConnection con=new SqlConnection(conexion);

        public DataTable consultarInventario()
        {
            con.Open();
            string query = "Select * from Inventario";
            SqlCommand cmd=new SqlCommand(query, con);
            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            con.Close();
            return dt;
        }

        public int insertarInventario(string producto, string categoria, float precio, int cantidad)
        {
            con.Open();
            string query="insert into Inventario values ('"+producto+"','"+categoria+"',"+precio+","+
                cantidad+")";
            SqlCommand cmd = new SqlCommand(query, con);
            int flag= cmd.ExecuteNonQuery();
            con.Close() ;
            return flag;
        }
        public int updatearInventario(string producto, string categoria, float precio, int cantidad) {
            int flag;
            con.Open();
            string query = "update Inventario set categoria='"+categoria+"', precio="+precio+
                ", cantidad="+cantidad+" where producto='"+producto+"'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            flag= sqlCommand.ExecuteNonQuery();
            con.Close() ;
            return flag;
        }

        public int deletearInventario(string producto) {
            int flag;
            con.Open();
            string query = "Delete from Inventario where producto='" + producto + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            flag = sqlCommand.ExecuteNonQuery();
            con.Close();
            return flag;
        }
    }
}
