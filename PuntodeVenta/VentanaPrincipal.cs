using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using System.Drawing.Printing;

namespace PuntodeVenta
{
    public partial class VentanaPrincipal : Form
    {
        private DataTable dt;
        conexionFacturaN cfn=new conexionFacturaN();
        private double subtotal = 0;
        private double total = 0;
        private double descuento = 0;
        private string cliente = "";

        public VentanaPrincipal()
        {
            InitializeComponent();
            txt_desc.Text = ts_desc.Text;
            txt_imp.Text = ts_imp.Text;
            
            // Columnas del DataGridView
            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio x Unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio Total");

            dataGridView1.DataSource = dt;

            txt_Factura.Text = cfn.consultaFactura();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers v1= new FormUsers();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            this.Hide();
            inventario.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_imp_Click(object sender, EventArgs e)
        {

        }

        private void imp_desChange(object sender, EventArgs e)
        {
            txt_imp.Text= ts_imp.Text;
            txt_desc.Text= ts_desc.Text;
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            var resultado=cfn.consultaInventario(txt_CodigoProducto.Text);
            DataRow row = dt.NewRow();

            row["Codigo"] = txt_CodigoProducto.Text;
            row["Producto"] = resultado.Item1;
            row["Precio x Unidad"]=resultado.Item2;
            row["Cantidad"]=txt_cantidad.Text;
            row["Descuento"]=txt_desc.Text;
            row["Precio Total"] = Int32.Parse(txt_cantidad.Text)*double.Parse(resultado.Item2);

            dt.Rows.Add(row);

            subtotal = subtotal + (Int32.Parse(txt_cantidad.Text) * double.Parse(resultado.Item2));

            if (descuento == 0)
            {
                total = subtotal + (subtotal * double.Parse(ts_imp.Text) / 100);
            }
            else
            {
                total = subtotal + (subtotal * double.Parse(ts_imp.Text) / 100);
                total = total - (total * descuento);
            }

            lbl_subtotal.Text = subtotal.ToString();
            lbl_total.Text = total.ToString();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            var resultado2 = cfn.consultaCliente(txt_clienteCodigo.Text);
            txt_clienteInfo.Text = resultado2.Item1+" DESC: "+resultado2.Item2;
            cliente = resultado2.Item1;
            descuento = resultado2.Item2;
            
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {

            List<Factura> factos = new List<Factura>();
            foreach (DataRow row in dt.Rows)
            {
                Factura fact = new Factura();
                fact.Codigo = row["Codigo"].ToString();
                fact.Producto = row["Producto"].ToString();
                fact.PrecioxUnidad = row["Precio x Unidad"].ToString();
                fact.Cantidad = row["Cantidad"].ToString();
                fact.Descuento = row["Descuento"].ToString();
                fact.PrecioTotal = row["Precio Total"].ToString();
                fact.Subtotal=subtotal.ToString();
                fact.Cliente=cliente.ToString();
                fact.Clientedesc=descuento.ToString();
                fact.Total = total.ToString();
                fact.NFactura=txt_Factura.Text;

                factos.Add(fact);
                //MessageBox.Show(fact.Clientedesc);
            }


            cfn.insertarFactura(factos);
            txt_Factura.Text = cfn.consultaFactura();

            //PROCESO DE IMPRESION

            printDocument1 = new PrintDocument();
            PrinterSettings ps=new PrinterSettings();
            printDocument1.PrinterSettings= ps;
            printDocument1.PrintPage += imprimir;
            printDocument1.Print();
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial",14);
            int ancho = 300;
            int y = 20;

            e.Graphics.DrawString("---Punto de Venta---", font, Brushes.Black,new RectangleF(0,y+=20,ancho,20));
            e.Graphics.DrawString("Factura#"+txt_Factura.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: "+cliente.ToString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("---Productos---", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

            foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["Codigo"].ToString()  +   " " +
                    row["Producto"].ToString()  +   " " +
                    row["Precio Total"].ToString()
                    ,font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            }

            e.Graphics.DrawString("Subtotal: " + subtotal.ToString(), font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("--- Total: $" + total.ToString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("--- Gracias por visitarnos ---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
        }

        private void gráficoDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grafico v2 = new grafico();
            this.Hide();
            v2.ShowDialog();
            this.Show();
        }
    }
}
