using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeraPod
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = accesobd.cargarInventario();
        }

        private void txt_NomProducto_MouseClick(object sender, MouseEventArgs e)
        {
            txt_NomProducto.Text = "";
            txt_NomProducto.ForeColor = Color.Black;
        }

        private void txt_NomProducto_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = accesobd.cargarInventario(txt_NomProducto.Text);
        }
    }
}
