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
            conexion.crear_conexion();
            button1.Text = "conectado";
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = accesobd.cargarInventario();
        }
    }
}
