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
            this.lbx_Inventario.Size = new System.Drawing.Size(361, 429);
            this.lbx_Inventario.TabIndex = 1;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 506);
            this.Controls.Add(this.lbx_Inventario);
            this.Controls.Add(this.txt_buscarProductoventa);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buscarProductoventa;
        private System.Windows.Forms.ListBox lbx_Inventario;
    }
}