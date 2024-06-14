using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PuntodeVenta
{
    public partial class grafico : Form
    {
        conexionFacturaN cn=new conexionFacturaN();
        public grafico()
        {
            InitializeComponent();
        }

        private void grafico_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = cn.consultarFacturaDT();

            chart1.Titles.Add("Productos Vendidos");

            foreach (DataRow row in dt.Rows)
            {
                Series series = chart1.Series.Add(row["Producto"].ToString());
                series.Points.Add(Convert.ToDouble(row["Cantidad de Productos"].ToString()));
                series.Label = row["Cantidad de Productos"].ToString();
            }
        }
    }
}
