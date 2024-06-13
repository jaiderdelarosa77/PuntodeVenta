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
    
    public partial class Inventario : Form
    {
        conexionInventarioNegocio cn= new conexionInventarioNegocio();
        public Inventario()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.consultarInventario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_np_Click(object sender, EventArgs e)
        {
            cn.insertarInventario(tb_producto.Text,tb_categoria.Text,
                float.Parse(tb_precio.Text),Convert.ToInt32(tb_cantidad.Text));
            dataGridView1.DataSource = cn.consultarInventario();
        }

        private void btn_modproduct_Click(object sender, EventArgs e)
        {
            cn.updatearInventario(tb_producto.Text, tb_categoria.Text,
                (float)Convert.ToDouble(tb_precio.Text),Convert.ToInt32(tb_cantidad.Text));
            dataGridView1.DataSource= cn.consultarInventario();
        }

        private void btn_delproduct_Click(object sender, EventArgs e)
        {
            cn.deletearInventario(tb_producto.Text);
            dataGridView1.DataSource = cn.consultarInventario();
        }
    }
}
