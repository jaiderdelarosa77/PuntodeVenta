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

namespace PuntodeVenta
{
    public partial class VentanaPrincipal : Form
    {
        private DataTable dt;
        conexionFacturaN cfn=new conexionFacturaN();
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
            //DataRow row = dt.NewRow();

            //row["Codigo"]
        }
    }
}
