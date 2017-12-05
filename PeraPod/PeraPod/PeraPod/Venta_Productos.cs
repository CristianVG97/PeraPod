using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeraPod
{
    class Venta_Productos
    {

        string clave, nombre, cantidad, costo;


        public string claveProducto
        {
            get
            {
                return clave;

            }
            set
            {
                clave = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;

            }
            set
            {
                nombre = value;
            }
        }
        public string Cantidad
        {
            get
            {
                return cantidad;

            }
            set
            {
                cantidad = value;
            }
        }
        public string Costo
        {
            get
            {
                return costo;

            }
            set
            {
                costo = value;
            }
        }

    }
}
