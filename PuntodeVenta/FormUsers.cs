using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace PuntodeVenta
{
    public partial class FormUsers : Form
    {
        conexionSQLN cn=new conexionSQLN();
        public FormUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.consultaDT();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            cn.insertarUsuario(tb_name.Text, tb_lastname.Text, tb_dni.Text, tb_phone.Text, tb_user.Text,
                tb_password.Text);
            dataGridView1.DataSource = cn.consultaDT();
        }

        private void tb_moduser_Click(object sender, EventArgs e)
        {
            cn.modificarUsuario(tb_name.Text, tb_lastname.Text, tb_dni.Text, tb_phone.Text,
                tb_user.Text, tb_password.Text);
            dataGridView1.DataSource = cn.consultaDT();
        }

        private void tb_deleteuser_Click(object sender, EventArgs e)
        {
            cn.eliminarUsuario(tb_dni.Text);
            dataGridView1.DataSource = cn.consultaDT();
        }
    }
}
