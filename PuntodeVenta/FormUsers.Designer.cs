﻿namespace PuntodeVenta
{
    partial class FormUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_user = new System.Windows.Forms.Button();
            this.tb_moduser = new System.Windows.Forms.Button();
            this.tb_deleteuser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(916, 351);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Cerrar";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(997, 243);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(15, 301);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(146, 22);
            this.tb_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(189, 301);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(146, 22);
            this.tb_lastname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(358, 301);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(146, 22);
            this.tb_dni.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(526, 301);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(146, 22);
            this.tb_phone.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_user);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(694, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 83);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Acceso";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(163, 40);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(146, 22);
            this.tb_password.TabIndex = 12;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contraseña";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(0, 40);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(146, 22);
            this.tb_user.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Usuario";
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(15, 343);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(131, 31);
            this.btn_user.TabIndex = 11;
            this.btn_user.Text = "Nuevo Usuario";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // tb_moduser
            // 
            this.tb_moduser.Location = new System.Drawing.Point(189, 343);
            this.tb_moduser.Name = "tb_moduser";
            this.tb_moduser.Size = new System.Drawing.Size(146, 31);
            this.tb_moduser.TabIndex = 12;
            this.tb_moduser.Text = "Modificar Usuario";
            this.tb_moduser.UseVisualStyleBackColor = true;
            this.tb_moduser.Click += new System.EventHandler(this.tb_moduser_Click);
            // 
            // tb_deleteuser
            // 
            this.tb_deleteuser.Location = new System.Drawing.Point(358, 343);
            this.tb_deleteuser.Name = "tb_deleteuser";
            this.tb_deleteuser.Size = new System.Drawing.Size(146, 31);
            this.tb_deleteuser.TabIndex = 13;
            this.tb_deleteuser.Text = "Eliminar Usuario";
            this.tb_deleteuser.UseVisualStyleBackColor = true;
            this.tb_deleteuser.Click += new System.EventHandler(this.tb_deleteuser_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 384);
            this.Controls.Add(this.tb_deleteuser);
            this.Controls.Add(this.tb_moduser);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_exit);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button tb_moduser;
        private System.Windows.Forms.Button tb_deleteuser;
    }
}