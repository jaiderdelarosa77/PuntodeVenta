using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class conexionSQLN
    {
        ConexionSQL cn=new ConexionSQL();
        public int conSQL(string user, string password)
        {
            return cn.consultaLogin(user, password);
        }

        public DataTable consultaDT()
        {
            return cn.ConsultarUsuariosDG();
        }

        public int insertarUsuario(string nombre, string apellido, string dni, string telefono,
            string usuario, string contraseña)
        {
            return cn.insertarUsuario(nombre, apellido, dni, telefono, usuario, contraseña);
        }

        public int modificarUsuario(string nombre, string apellido, string dni, string telefono,
            string usuario, string contraseña)
        {
            return cn.modificarUsuario(nombre, apellido, dni, telefono, usuario, contraseña);
        }

        public int eliminarUsuario(string dni)
        {
            return cn.eliminarUsuario(dni);
        }
    }
}
