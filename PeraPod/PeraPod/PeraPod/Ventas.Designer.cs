namespace PeraPod
{
    partial class Ventas
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
            this.txt_buscarProductoventa = new System.Windows.Forms.TextBox();
            this.lbx_Inventario = new System.Windows.Forms.ListBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.dgv_venta = new System.Windows.Forms.DataGridView();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.lbl_montopago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscarProductoventa
            // 
            this.txt_buscarProductoventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarProductoventa.Location = new System.Drawing.Point(12, 12);
            this.txt_buscarProductoventa.Name = "txt_buscarProductoventa";
            this.txt_buscarProductoventa.Size = new System.Drawing.Size(361, 31);
            this.txt_buscarProductoventa.TabIndex = 0;
            this.txt_buscarProductoventa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbx_Inventario
            // 
            this.lbx_Inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_Inventario.FormattingEnabled = true;
            this.lbx_Inventario.ItemHeight = 25;
            this.lbx_Inventario.Location = new System.Drawing.Point(12, 54);
            this.lbx_Inventario.Name = "lbx_Inventario";
            this.lbx_Inventario.Size = new System.Drawing.Size(361, 354);
            this.lbx_Inventario.TabIndex = 1;
            this.lbx_Inventario.SelectedIndexChanged += new System.EventHandler(this.lbx_Inventario_SelectedIndexChanged);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(415, 91);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(44, 31);
            this.txt_cantidad.TabIndex = 2;
            this.txt_cantidad.Text = "1";
            // 
            // dgv_venta
            // 
            this.dgv_venta.AllowUserToAddRows = false;
            this.dgv_venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venta.Location = new System.Drawing.Point(532, 54);
            this.dgv_venta.Name = "dgv_venta";
            this.dgv_venta.Size = new System.Drawing.Size(355, 354);
            this.dgv_venta.TabIndex = 4;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Location = new System.Drawing.Point(591, 12);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(200, 20);
            this.dt_fecha.TabIndex = 5;
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(549, 414);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(75, 23);
            this.btn_comprar.TabIndex = 6;
            this.btn_comprar.Text = "Realizar compra";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // lbl_montopago
            // 
            this.lbl_montopago.AutoSize = true;
            this.lbl_montopago.Location = new System.Drawing.Point(740, 423);
            this.lbl_montopago.Name = "lbl_montopago";
            this.lbl_montopago.Size = new System.Drawing.Size(13, 13);
            this.lbl_montopago.TabIndex = 7;
            this.lbl_montopago.Text = "0";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 506);
            this.Controls.Add(this.lbl_montopago);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.dgv_venta);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbx_Inventario);
            this.Controls.Add(this.txt_buscarProductoventa);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buscarProductoventa;
        private System.Windows.Forms.ListBox lbx_Inventario;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.DataGridView dgv_venta;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Label lbl_montopago;
    }
}