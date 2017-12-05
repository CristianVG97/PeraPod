using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PeraPod
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        public void cargar(string nombre)
        {
            MySqlCommand consulta = new MySqlCommand();
            // SELECT nombre FROM `productos`
            consulta.CommandText = "SELECT nombre FROM `productos` WHERE `nombre` LIKE '%" + nombre + "%'";
            consulta.Connection = conexion.crear_conexion();
            MySqlDataReader producto = consulta.ExecuteReader();
            lbx_Inventario.Items.Clear();
            while (producto.Read())
            {
                lbx_Inventario.Items.Add(producto[0].ToString());
                
            }

        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            dgv_venta.DataSource = accesobd.mostrarVenta();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargar(txt_buscarProductoventa.Text);
        }

      

        private void lbx_Inventario_SelectedIndexChanged(object sender, EventArgs e)//seleccionar el item
        {
           
        }
    }
}
