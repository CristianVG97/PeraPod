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
            txt_buscarProducto.Text = "";
            txt_buscarProducto.ForeColor = Color.Black;
        }

        private void txt_NomProducto_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = accesobd.cargarInventario(txt_buscarProducto.Text);
        }

        private void txt_clave_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbx_tipo_operacion.Text == "Agregar Exitencia a Un Producto o Cambiar Precio")
            {
            }
            else
            {
                txt_clave.Text = "";
                txt_clave.ForeColor = Color.Black;
            }
        }

        private void txt_nombre_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbx_tipo_operacion.Text == "Agregar Exitencia a Un Producto o Cambiar Precio")
            {
            }
            else
            {
                txt_nombre.Text = "";
                txt_nombre.ForeColor = Color.Black;
            }
        }

        private void txt_precio_MouseClick(object sender, MouseEventArgs e)
        {
            txt_precio.Text = "";
            txt_precio.ForeColor = Color.Black;
        }

        private void txt_existencia_MouseClick(object sender, MouseEventArgs e)
        {
            txt_existencia.Text = "";
            txt_existencia.ForeColor = Color.Black;
        }

        private void cbx_tipo_operacion_TextChanged(object sender, EventArgs e)
        {
            if (cbx_tipo_operacion.Text == "Agregar Exitencia a Un Producto o Cambiar Precio")
            {
                btn_modificar.Visible = true;
                btn_agregar.Visible = false;
                txt_clave.ReadOnly = true;
                txt_nombre.ReadOnly = true;

            }
             if (cbx_tipo_operacion.Text == "Agregar Nuevo Producto")
            {
                btn_agregar.Visible = true;
                btn_modificar.Visible = false;
            }
           
        }

        public void limpiar_contenedores()

        {
            txt_clave.Text = "Clave del Producto";
            txt_clave.ForeColor = Color.Gray;
            txt_nombre.Text = "Nombre del Producto";
            txt_nombre.ForeColor = Color.Gray;
            txt_precio.Text = "Precio del Producto"; 
            txt_precio.ForeColor = Color.Gray;
            txt_existencia.Text = "Existencia del Producto";
            txt_existencia.ForeColor = Color.Gray;

        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            conexion.crear_conexion();
            _productos nuevo = new _productos();
            nuevo.claveProducto = txt_clave.Text;
            nuevo.nombreProducto = txt_nombre.Text;
            nuevo.precioProducto = txt_precio.Text;
            nuevo.exitenciaProducto = txt_existencia.Text;
            int validacion = accesobd.insertar(nuevo);
            if (validacion > 0)
            {
                dataGridView1.DataSource = accesobd.cargarInventario();
            }
            else
            {
                MessageBox.Show("Error","¡Error al guardar!");
            }

            limpiar_contenedores();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            accesobd.cambiar(Convert.ToDouble(txt_precio.Text), Convert.ToInt32(txt_precio.Text), txt_clave.Text);
            dataGridView1.DataSource = accesobd.cargarInventario();
            limpiar_contenedores();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_clave.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_precio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_existencia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
