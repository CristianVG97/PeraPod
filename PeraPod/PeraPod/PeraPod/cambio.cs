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
    public partial class cambio : Form
    {
        private double cam;

        public cambio(double cambio)
        {
            cam = cambio;
            InitializeComponent();
        }

        

        private void cambio_Load(object sender, EventArgs e)
        {
            lbl_cambio.Text = "$" + Convert.ToString(cam);
        }

        private void btn_cerra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
