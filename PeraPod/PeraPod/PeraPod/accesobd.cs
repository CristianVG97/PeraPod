﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PeraPod
{
    class accesobd
    {
        public static int  insertar(_productos datos)
        {
            int resultado = 0;
            MySqlCommand consulta = new MySqlCommand();
            
            consulta.CommandText = "INSERT INTO `productos` (`clave`, `nombre`, `pecio`, `existencia`) VALUES ('" + datos.claveProducto+"','"+datos.nombreProducto+"','"+datos.precioProducto+"','"+datos.exitenciaProducto+"');";
            consulta.Connection = conexion.crear_conexion();
            resultado = consulta.ExecuteNonQuery();
            return resultado;

        }
        public static int insertarVenta(Venta_Productos datos)
        {
            int resultado = 0;
            MySqlCommand consulta = new MySqlCommand();

            consulta.CommandText = "INSERT INTO `venta` (`clave`, `nombre`, `cantidad`, `costo`) VALUES ('" +datos.claveProducto+ "','" + datos.Nombre+ "','" + datos.Cantidad+ "','" + datos.Costo+ "');";
            consulta.Connection = conexion.crear_conexion();
            resultado = consulta.ExecuteNonQuery();
            return resultado;

        }
        public static double montopago()
        {
            double pago = 0;
            MySqlCommand consulta = new MySqlCommand();
            consulta.CommandText = "SELECT `costo` FROM `venta`";
            consulta.Connection = conexion.crear_conexion();
            MySqlDataReader producto = consulta.ExecuteReader();
          

            while (producto.Read())
            {
                pago += Convert.ToDouble(producto["costo"]);


            }
            return pago;

        }
        public static int cambiar(double precio, int existencia, string clave)
        {
            int resultado = 0;
            MySqlCommand consulta = new MySqlCommand();
            //UPDATE `productos` SET `clave`= 'fvv' WHERE clave = 'bbi'
            consulta.CommandText = "UPDATE `productos` SET `pecio`='"+precio+"', `existencia`='"+existencia+"' WHERE clave ='"+clave+"';";
            consulta.Connection = conexion.crear_conexion();
            resultado = consulta.ExecuteNonQuery();
            return resultado;

        }
        public static int cambiar( int existencia, string clave)
        {
            int resultado = 0;
            MySqlCommand consulta = new MySqlCommand();
            //UPDATE `productos` SET `clave`= 'fvv' WHERE clave = 'bbi'
            consulta.CommandText = "UPDATE `productos` SET `existencia`='" + existencia + "' WHERE clave ='" + clave + "';";
            consulta.Connection = conexion.crear_conexion();
            resultado = consulta.ExecuteNonQuery();
            return resultado;

        }


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
        public static List<Venta_Productos> mostrarVenta()
        {
            List<Venta_Productos> listaProductosVenta = new List<Venta_Productos>();
            MySqlCommand consulta = new MySqlCommand();
            consulta.CommandText = "SELECT * FROM `venta`";
            consulta.Connection = conexion.crear_conexion();
            MySqlDataReader producto = consulta.ExecuteReader();
            while (producto.Read())
            {
                Venta_Productos nuevo = new Venta_Productos();
               nuevo.claveProducto = producto["clave"].ToString();
                nuevo.Nombre = producto["nombre"].ToString();
                nuevo.Cantidad = producto["cantidad"].ToString();
                nuevo.Costo = producto["costo"].ToString();
                listaProductosVenta.Add(nuevo);
            }

            return listaProductosVenta;

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
