using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeraPod
{
    class _productos
    {
        string clave, nombre,existencia,precio;
       

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
        public string nombreProducto
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
        public string exitenciaProducto
        {
            get
            {
                return existencia;

            }
            set
            {
                existencia = value;
            }
        }
        public string precioProducto
        {
            get
            {
                return precio;

            }
            set
            {
                precio = value;
            }
        }

    }
}
