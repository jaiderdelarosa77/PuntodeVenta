using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class conexionFacturaN
    {
        conexionFactura cn=new conexionFactura();
        public string consultaFactura()
        {
            return cn.consultaFactura();
        }
        public Tuple<string, string> consultaInventario(string code)
        {
            return cn.consultaInventario(code);
        }
        public Tuple<string, double> consultaCliente(string code)
        {
            return cn.consultaCliente(code);
        }

        public void insertarFactura(List<Factura> F)
        {
            cn.insertarFactura(F);
        }

        public DataTable consultarFacturaDT()
        {
            return cn.consultarFacturaDT();
        }

    }
}
