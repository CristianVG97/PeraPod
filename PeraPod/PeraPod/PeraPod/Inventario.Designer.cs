namespace PeraPod
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_buscarProducto = new System.Windows.Forms.TextBox();
            this.cbx_tipo_operacion = new System.Windows.Forms.ComboBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_existencia = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(56, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(721, 191);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.AccessibleDescription = "";
            this.txt_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_buscarProducto.HideSelection = false;
            this.txt_buscarProducto.Location = new System.Drawing.Point(56, 38);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.Size = new System.Drawing.Size(721, 31);
            this.txt_buscarProducto.TabIndex = 2;
            this.txt_buscarProducto.Text = "Bucar un producto";
            this.txt_buscarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_buscarProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_NomProducto_MouseClick);
            this.txt_buscarProducto.TextChanged += new System.EventHandler(this.txt_NomProducto_TextChanged);
            // 
            // cbx_tipo_operacion
            // 
            this.cbx_tipo_operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo_operacion.FormattingEnabled = true;
            this.cbx_tipo_operacion.Items.AddRange(new object[] {
            "Agregar Exitencia a Un Producto o Cambiar Precio",
            "Agregar Nuevo Producto"});
            this.cbx_tipo_operacion.Location = new System.Drawing.Point(56, 1);
            this.cbx_tipo_operacion.Name = "cbx_tipo_operacion";
            this.cbx_tipo_operacion.Size = new System.Drawing.Size(721, 28);
            this.cbx_tipo_operacion.TabIndex = 3;
            this.cbx_tipo_operacion.Text = "Seleccione una opcion";
            this.cbx_tipo_operacion.TextChanged += new System.EventHandler(this.cbx_tipo_operacion_TextChanged);
            // 
            // txt_clave
            // 
            this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_clave.Location = new System.Drawing.Point(56, 92);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(304, 26);
            this.txt_clave.TabIndex = 4;
            this.txt_clave.Text = "Clave del Producto";
            this.txt_clave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_clave_MouseClick);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_nombre.Location = new System.Drawing.Point(56, 128);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(304, 26);
            this.txt_nombre.TabIndex = 5;
            this.txt_nombre.Text = "Nombre del Producto";
            this.txt_nombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_nombre_MouseClick);
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_precio.Location = new System.Drawing.Point(56, 164);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(304, 26);
            this.txt_precio.TabIndex = 6;
            this.txt_precio.Text = "Precio del procucto";
            this.txt_precio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_precio_MouseClick);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_existencia
            // 
            this.txt_existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_existencia.Location = new System.Drawing.Point(56, 208);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(304, 26);
            this.txt_existencia.TabIndex = 7;
            this.txt_existencia.Text = "Existencia del Producto";
            this.txt_existencia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_existencia_MouseClick);
            this.txt_existencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_existencia_KeyPress);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(630, 111);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(113, 62);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Visible = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(630, 128);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(113, 62);
            this.btn_modificar.TabIndex = 9;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Visible = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 482);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_existencia);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.cbx_tipo_operacion);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_buscarProducto;
        private System.Windows.Forms.ComboBox cbx_tipo_operacion;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_existencia;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
    }
}