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
        public void guardarventa( )
        {
        
            MySqlCommand consulta = new MySqlCommand();

            consulta.CommandText = "INSERT INTO `registroventas`  VALUES (?clave, ?nombre,?cantidad,?costo,?fecha);";
            consulta.Connection = conexion.crear_conexion();

            
                foreach (DataGridViewRow row in dgv_venta.Rows)
                {
                    consulta.Parameters.Clear();
                    consulta.Parameters.Add("?clave", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells[0].Value);
                    consulta.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells[1].Value);
                    consulta.Parameters.Add("?cantidad", MySqlDbType.Int16).Value = Convert.ToInt16(row.Cells[2].Value);
                    consulta.Parameters.Add("?costo", MySqlDbType.Float).Value = Convert.ToDouble(row.Cells[3].Value);
                    consulta.Parameters.Add("?fecha", MySqlDbType.Datetime).Value = Convert.ToDateTime(dt_fecha.Value);

                    consulta.ExecuteNonQuery();

                }


           
        }
        public void borrar_registros()
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.CommandText = "TRUNCATE TABLE `venta`";
            consulta.Connection = conexion.crear_conexion();
            consulta.ExecuteNonQuery();

        }
        public void buscar(string nombre, int cantidad)
        {
            int existencia;
            MySqlCommand consulta = new MySqlCommand();
            consulta.CommandText = "SELECT * FROM `productos` WHERE `nombre` ='" + nombre + "';";
            consulta.Connection = conexion.crear_conexion();
            MySqlDataReader producto = consulta.ExecuteReader();
            Venta_Productos nuevo = new Venta_Productos();

         
                producto.Read();
                nuevo.claveProducto = producto["clave"].ToString();
                nuevo.Nombre=producto["nombre"].ToString();
            existencia = Convert.ToInt16(producto["existencia"]);
                nuevo.Cantidad = cantidad.ToString();
                nuevo.Costo =Convert.ToString((Convert.ToDouble( producto["pecio"])*cantidad));


            int canexitencia = existencia - cantidad;
            if (canexitencia < 0)
            {
                MessageBox.Show("No cuenta con el producto suficiente para realizar esta venta", "Error");
            }
            else
            {
                int validacom = accesobd.cambiar(canexitencia, nuevo.claveProducto);

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
            lbl_montopago.Text = Convert.ToString(accesobd.montopago());

        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {

            double importe = Convert.ToDouble(txt_importe.Text);
            double  montopago= Convert.ToDouble(lbl_montopago.Text);
            double cambio = importe - montopago; 
            cambio cam = new cambio(cambio);

            if (txt_importe.Text == ""||importe<montopago)
            {
                MessageBox.Show("Error: debe introducir el importe o el importe es incorrecto");
            }
            else
            {
                guardarventa();



                borrar_registros();
                dgv_venta.DataSource = accesobd.mostrarVenta();

                cam.Show();
               
                txt_buscarProductoventa.Text = "";
                txt_cantidad.Text = "1";
                txt_importe.Text = "";
                lbl_montopago.Text = "0";

            }


          
        }
    }
}
