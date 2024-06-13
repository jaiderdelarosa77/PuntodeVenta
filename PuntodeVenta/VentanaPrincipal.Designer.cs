namespace PuntodeVenta
{
    partial class VentanaPrincipal
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.impVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_imp = new System.Windows.Forms.ToolStripTextBox();
            this.descuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_desc = new System.Windows.Forms.ToolStripTextBox();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoProducto = new System.Windows.Forms.TextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_imp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Factura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(807, 409);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ventanaToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impVentaToolStripMenuItem,
            this.descuentoToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(247, 26);
            this.toolStripMenuItem2.Text = "Imp. Venta y Descuento";
            // 
            // impVentaToolStripMenuItem
            // 
            this.impVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_imp});
            this.impVentaToolStripMenuItem.Name = "impVentaToolStripMenuItem";
            this.impVentaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.impVentaToolStripMenuItem.Text = "Imp. Venta";
            // 
            // ts_imp
            // 
            this.ts_imp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_imp.Name = "ts_imp";
            this.ts_imp.Size = new System.Drawing.Size(224, 27);
            this.ts_imp.Text = "9";
            this.ts_imp.Click += new System.EventHandler(this.toolStrip_imp_Click);
            this.ts_imp.TextChanged += new System.EventHandler(this.imp_desChange);
            // 
            // descuentoToolStripMenuItem
            // 
            this.descuentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_desc});
            this.descuentoToolStripMenuItem.Name = "descuentoToolStripMenuItem";
            this.descuentoToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.descuentoToolStripMenuItem.Text = "Descuento";
            // 
            // ts_desc
            // 
            this.ts_desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_desc.Name = "ts_desc";
            this.ts_desc.Size = new System.Drawing.Size(224, 27);
            this.ts_desc.Text = "0";
            this.ts_desc.TextChanged += new System.EventHandler(this.imp_desChange);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.ventanaToolStripMenuItem.Text = "Usuarios";
            this.ventanaToolStripMenuItem.Click += new System.EventHandler(this.ventanaToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeFacturasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // historialDeFacturasToolStripMenuItem
            // 
            this.historialDeFacturasToolStripMenuItem.Name = "historialDeFacturasToolStripMenuItem";
            this.historialDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.historialDeFacturasToolStripMenuItem.Text = "Historial de facturas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuntodeVenta.Properties.Resources.VentanaPrincipal1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 244);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sub Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo de Producto:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_CodigoProducto
            // 
            this.txt_CodigoProducto.Location = new System.Drawing.Point(469, 323);
            this.txt_CodigoProducto.Name = "txt_CodigoProducto";
            this.txt_CodigoProducto.Size = new System.Drawing.Size(127, 22);
            this.txt_CodigoProducto.TabIndex = 7;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(469, 352);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(260, 57);
            this.btn_addProduct.TabIndex = 8;
            this.btn_addProduct.Text = "Agregar producto";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 54);
            this.label5.TabIndex = 10;
            this.label5.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descuento:";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(341, 339);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.Size = new System.Drawing.Size(84, 22);
            this.txt_desc.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 99);
            this.button2.TabIndex = 13;
            this.button2.Text = "Facturar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(602, 323);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(127, 22);
            this.txt_cantidad.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad:";
            // 
            // txt_imp
            // 
            this.txt_imp.Location = new System.Drawing.Point(341, 310);
            this.txt_imp.Name = "txt_imp";
            this.txt_imp.ReadOnly = true;
            this.txt_imp.Size = new System.Drawing.Size(84, 22);
            this.txt_imp.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Imp. Venta:";
            // 
            // txt_Factura
            // 
            this.txt_Factura.Location = new System.Drawing.Point(245, 33);
            this.txt_Factura.Name = "txt_Factura";
            this.txt_Factura.ReadOnly = true;
            this.txt_Factura.Size = new System.Drawing.Size(114, 22);
            this.txt_Factura.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "N. Factura:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Codigo Cliente:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(36, 201);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(487, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cliente";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(541, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(248, 22);
            this.textBox7.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Factura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_imp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.txt_CodigoProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CodigoProducto;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeFacturasToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_imp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Factura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem impVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox ts_imp;
        private System.Windows.Forms.ToolStripTextBox ts_desc;
    }
}