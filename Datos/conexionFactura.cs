using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
            string resultado = "Null";
            string query = "Select(Select distinct top 1 NumFactura from Facturacion order by NumFactura desc)+1 as NumFactura";
            SqlCommand cmd=new SqlCommand(query, con);
            SqlDataReader reg= cmd.ExecuteReader();

            if (reg.Read())
            {
                resultado=reg["NumFactura"].ToString();
            }

            con.Close();
            return resultado;
        }

        public DataTable consultarFacturaDT()
        {
            string query = "Select Producto, Count(Producto) [Cantidad de Productos] from Facturacion group by Producto";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla= new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public Tuple<string,string> consultaInventario(string codigo)
        {
            con.Open();
            string query = "Select * from Inventario where Codigo='"+codigo+"'";
            string resultado = "Null";
            string resultado1 = "Null";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resultado = reg["Producto"].ToString();
                resultado1 = reg["Precio"].ToString();
            }
            con.Close();
            return Tuple.Create(resultado,resultado1);
        }

        public Tuple<string, double> consultaCliente(string codigo)
        {
            con.Open();
            string query = "Select NombreCliente + ' '+ ApellidoCliente as Nombre, Descuento from Clientes where CodigoCliente='"
                + codigo + "'";
            string resultado = "Null";
            double resultado1 = 0;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resultado = reg["Nombre"].ToString();
                resultado1 = double.Parse(reg["Descuento"].ToString());
            }
            con.Close();
            return Tuple.Create(resultado, resultado1);
        }

        public void insertarFactura(List<Factura> F)
        {
            con.Open();

            foreach (Factura f in F)
            {
                string query = "INSERT INTO Facturacion (Codigo, Producto, PrecioxUnidad, Cantidad, Descuento, Cliente, DescuentoCliente, MontoTotal, NumFactura) " +
                "VALUES ('" + f.Codigo + "','" + f.Producto + "'," + Convert.ToDouble(f.PrecioxUnidad) + "," +
                Convert.ToInt32(f.Cantidad) + "," + Convert.ToDouble(f.Descuento) + ",'" + f.Cliente + "'," +
                Convert.ToDouble(f.Clientedesc) + "," + Convert.ToDouble(f.Total) + "," + Convert.ToInt32(f.NFactura) + ")";

                SqlCommand cmd =new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }

    }
}
