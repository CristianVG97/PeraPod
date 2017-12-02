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
    }
}
