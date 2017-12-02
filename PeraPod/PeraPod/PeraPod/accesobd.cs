using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PeraPod
{
    class accesobd
    {
        public static List<_productos> cargarInventario()
        {
            List<_productos> listaProductos = new List<_productos>();
            MySqlCommand consulta = new MySqlCommand();
            consulta.CommandText = "SELECT * FROM `productos`";
            consulta.Connection = conexion.crear_conexion();
            MySqlDataReader producto = consulta.ExecuteReader();
            while (producto.Read())
            {
                _productos nuevo = new _productos();
                nuevo.claveProducto = producto["clave"].ToString();
                nuevo.nombreProducto= producto["nombre"].ToString();
                nuevo.precioProducto =producto["pecio"].ToString();
                nuevo.exitenciaProducto= producto["existencia"].ToString();
                listaProductos.Add(nuevo);
            }

            return listaProductos;

        }
        public static List<_productos> cargarInventario( string nombre)
        {
            List<_productos> listaProductos = new List<_productos>();
            MySqlCommand consulta = new MySqlCommand();
            // consulta.CommandText = "SELECT * FROM `productos` WHERE nombre='" + nombre + "';";
            consulta.CommandText = "SELECT * FROM `productos` WHERE `nombre` LIKE '%" + nombre + "%'";
            consulta.Connection = conexion.crear_conexion();
            MySqlDataReader producto = consulta.ExecuteReader();
            while (producto.Read())
            {
                _productos nuevo = new _productos();
                nuevo.claveProducto = producto["clave"].ToString();
                nuevo.nombreProducto = producto["nombre"].ToString();
                nuevo.precioProducto = producto["pecio"].ToString();
                nuevo.exitenciaProducto = producto["existencia"].ToString();
                listaProductos.Add(nuevo);
            }

            return listaProductos;

        }

    }
}
