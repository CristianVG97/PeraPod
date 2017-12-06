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
        public void buscar(string nombre, int cantidad)
        {
            
            MySqlCommand consulta = new MySqlCommand();
            consulta.CommandText = "SELECT * FROM `productos` WHERE `nombre` ='" + nombre + "';";
            consulta.Connection = conexion.crear_conexion();
            MySqlDataReader producto = consulta.ExecuteReader();
            Venta_Productos nuevo = new Venta_Productos();

            while (producto.Read())
            {
                nuevo.claveProducto = producto["clave"].ToString();
                nuevo.Nombre=producto["nombre"].ToString();
                nuevo.Cantidad = cantidad.ToString();
                nuevo.Costo =Convert.ToString((Convert.ToDouble( producto["pecio"])*cantidad));


            }


            int validacion = accesobd.insertarVenta(nuevo);
            if (validacion > 0)
            {
                dgv_venta.DataSource = accesobd.mostrarVenta();
            }
            else
            {
                MessageBox.Show("Error", "¡No se pudo realizar la compra!");

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
            String nombre = lbx_Inventario.Text;
            int cantidad = Convert.ToInt32(txt_cantidad.Text);
            buscar(nombre,cantidad);

        }

        
    }
}
