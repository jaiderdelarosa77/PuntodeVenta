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
    public class conexionInventarioNegocio
    {
        conexionInventario conexionInventario= new conexionInventario();
        public DataTable consultarInventario()
        {
            return conexionInventario.consultarInventario();
        }

        public int insertarInventario(string producto, string categoria, float precio, int cantidad)
        {
            return conexionInventario.insertarInventario(producto,categoria,precio,cantidad);
        }
        public int updatearInventario(string producto, string categoria, float precio, int cantidad)
        {
            return conexionInventario.updatearInventario(producto,categoria,precio,cantidad);
        }

        public int deletearInventario(string producto)
        {
            return conexionInventario.deletearInventario(producto);
        }
    }
}
