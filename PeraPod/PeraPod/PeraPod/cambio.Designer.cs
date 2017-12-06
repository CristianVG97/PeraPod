namespace PeraPod
{
    partial class cambio
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
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.btn_cerra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.Location = new System.Drawing.Point(119, 55);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(0, 73);
            this.lbl_cambio.TabIndex = 0;
            // 
            // btn_cerra
            // 
            this.btn_cerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerra.Location = new System.Drawing.Point(322, 183);
            this.btn_cerra.Name = "btn_cerra";
            this.btn_cerra.Size = new System.Drawing.Size(75, 23);
            this.btn_cerra.TabIndex = 1;
            this.btn_cerra.Text = "Aceptar";
            this.btn_cerra.UseVisualStyleBackColor = true;
            this.btn_cerra.Click += new System.EventHandler(this.btn_cerra_Click);
            // 
            // cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 218);
            this.Controls.Add(this.btn_cerra);
            this.Controls.Add(this.lbl_cambio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cambio";
            this.Text = "Cambio";
            this.Load += new System.EventHandler(this.cambio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.Button btn_cerra;
    }
}