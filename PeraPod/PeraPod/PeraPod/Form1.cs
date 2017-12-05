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
    public partial class MainForm : Form
    {
        Inventario inventario;
        Ventas ventas;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inventario==null)
            {
                inventario = new Inventario();
                inventario.MdiParent = this;
                inventario.FormClosed += new FormClosedEventHandler(inventario_closed);
                inventario.Show();
            }
        }

        private void inventario_closed(object sender, FormClosedEventArgs e)
        {
            inventario = null;
        }
        private void ventas_closed(object sender, FormClosedEventArgs e)
        {
            ventas = null;
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventas == null)
            {
               ventas = new Ventas();
               ventas.MdiParent = this;
               ventas.FormClosed += new FormClosedEventHandler(ventas_closed);
                ventas.Show();
            }

        }
    }
}
