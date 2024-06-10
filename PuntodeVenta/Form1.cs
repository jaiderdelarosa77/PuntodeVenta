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
    public partial class Form1 : Form
    {
        conexionSQLN cn=new conexionSQLN();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(tb_user.Text, tb_password.Text) == 1)
            {
                VentanaPrincipal v1= new VentanaPrincipal();
                this.Hide();
                v1.Show();  
            }
        }
    }
}
