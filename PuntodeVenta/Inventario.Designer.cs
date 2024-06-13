namespace PuntodeVenta
{
    partial class Inventario
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_producto = new System.Windows.Forms.TextBox();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.tb_categoria = new System.Windows.Forms.TextBox();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.btn_np = new System.Windows.Forms.Button();
            this.btn_delproduct = new System.Windows.Forms.Button();
            this.btn_modproduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // tb_producto
            // 
            this.tb_producto.Location = new System.Drawing.Point(12, 253);
            this.tb_producto.Name = "tb_producto";
            this.tb_producto.Size = new System.Drawing.Size(139, 22);
            this.tb_producto.TabIndex = 2;
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(328, 253);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(139, 22);
            this.tb_precio.TabIndex = 3;
            // 
            // tb_categoria
            // 
            this.tb_categoria.Location = new System.Drawing.Point(171, 253);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.Size = new System.Drawing.Size(139, 22);
            this.tb_categoria.TabIndex = 4;
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(488, 253);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(139, 22);
            this.tb_cantidad.TabIndex = 5;
            // 
            // btn_np
            // 
            this.btn_np.Location = new System.Drawing.Point(16, 383);
            this.btn_np.Name = "btn_np";
            this.btn_np.Size = new System.Drawing.Size(135, 53);
            this.btn_np.TabIndex = 7;
            this.btn_np.Text = "Nuevo Producto";
            this.btn_np.UseVisualStyleBackColor = true;
            this.btn_np.Click += new System.EventHandler(this.btn_np_Click);
            // 
            // btn_delproduct
            // 
            this.btn_delproduct.Location = new System.Drawing.Point(355, 383);
            this.btn_delproduct.Name = "btn_delproduct";
            this.btn_delproduct.Size = new System.Drawing.Size(149, 53);
            this.btn_delproduct.TabIndex = 8;
            this.btn_delproduct.Text = "Eliminar Producto";
            this.btn_delproduct.UseVisualStyleBackColor = true;
            this.btn_delproduct.Click += new System.EventHandler(this.btn_delproduct_Click);
            // 
            // btn_modproduct
            // 
            this.btn_modproduct.Location = new System.Drawing.Point(174, 383);
            this.btn_modproduct.Name = "btn_modproduct";
            this.btn_modproduct.Size = new System.Drawing.Size(136, 53);
            this.btn_modproduct.TabIndex = 9;
            this.btn_modproduct.Text = "Modificar Producto";
            this.btn_modproduct.UseVisualStyleBackColor = true;
            this.btn_modproduct.Click += new System.EventHandler(this.btn_modproduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuntodeVenta.Properties.Resources.gestionar_el_inventario_en_las_empresas_de_comercio_electronico;
            this.pictureBox1.Location = new System.Drawing.Point(654, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modproduct);
            this.Controls.Add(this.btn_delproduct);
            this.Controls.Add(this.btn_np);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.tb_categoria);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.tb_producto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_producto;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.TextBox tb_categoria;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Button btn_np;
        private System.Windows.Forms.Button btn_delproduct;
        private System.Windows.Forms.Button btn_modproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}