using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Datos
{
    public class ConexionSQL
    {
        static string conexionString = "server= localhost; database= PuntodeVenta;" +
            " integrated security= true";
        SqlConnection con= new SqlConnection(conexionString);
        public int consultaLogin(string usuario, string contrasena)
        {
            int contador;
            con.Open();
            string query = "Select Count(*) From Persona where usuario='"+usuario+"'"+
                " and contrasena='"+contrasena+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            contador=Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return contador;
        }

        public DataTable ConsultarUsuariosDG()
        {
            con.Open();
            string query = "Select * from Persona";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            con.Close();
            return dt;
        }

        public int insertarUsuario(string nombre, string apellido, string dni, string telefono,
            string usuario, string contraseña)
        {
            int flag = 0;
            con.Open();
            string query="Insert into Persona values ('"+nombre+"','"+apellido+"','"+dni+"','"+
                telefono+"','"+usuario+"','"+contraseña+"')";
            SqlCommand sqlCommand= new SqlCommand(query, con);
            flag=sqlCommand.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int modificarUsuario(string nombre, string apellido, string dni, string telefono,
            string usuario, string contraseña)
        {
            int flag = 0;
            con.Open();
            string query="Update Persona set nombre='"+nombre+"', apellidos='"+apellido+"', telefono='" +
                telefono + "', usuario='" + usuario + "', contrasena='" + contraseña + "' where dni='" + dni + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag=cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int eliminarUsuario(string dni)
        {
            int flag= 0;
            con.Open();
            string query = "Delete from Persona where dni='"+dni+"'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            flag=sqlCommand.ExecuteNonQuery();
            con.Close();
            return flag; 
        }
    }
}
