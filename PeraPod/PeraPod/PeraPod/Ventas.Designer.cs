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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscarProductoventa
            // 
            this.txt_buscarProductoventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarProductoventa.Location = new System.Drawing.Point(12, 65);
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
            this.lbx_Inventario.Location = new System.Drawing.Point(12, 117);
            this.lbx_Inventario.Name = "lbx_Inventario";
            this.lbx_Inventario.Size = new System.Drawing.Size(361, 304);
            this.lbx_Inventario.TabIndex = 1;
            this.lbx_Inventario.SelectedIndexChanged += new System.EventHandler(this.lbx_Inventario_SelectedIndexChanged);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(589, 65);
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
            this.dgv_venta.Location = new System.Drawing.Point(439, 117);
            this.dgv_venta.Name = "dgv_venta";
            this.dgv_venta.Size = new System.Drawing.Size(355, 301);
            this.dgv_venta.TabIndex = 4;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Location = new System.Drawing.Point(209, 12);
            this.dt_fecha.MinDate = new System.DateTime(2017, 12, 6, 2, 18, 19, 0);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(460, 31);
            this.dt_fecha.TabIndex = 5;
            this.dt_fecha.Value = new System.DateTime(2017, 12, 6, 2, 18, 19, 0);
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(811, 117);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(117, 301);
            this.btn_comprar.TabIndex = 6;
            this.btn_comprar.Text = "Realizar compra";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // lbl_montopago
            // 
            this.lbl_montopago.AutoSize = true;
            this.lbl_montopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montopago.Location = new System.Drawing.Point(527, 421);
            this.lbl_montopago.Name = "lbl_montopago";
            this.lbl_montopago.Size = new System.Drawing.Size(51, 55);
            this.lbl_montopago.TabIndex = 7;
            this.lbl_montopago.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad";
            // 
            // txt_importe
            // 
            this.txt_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe.Location = new System.Drawing.Point(810, 427);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(118, 49);
            this.txt_importe.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Importe: $";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_importe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Label label3;
    }
}