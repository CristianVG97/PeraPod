using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PeraPod
{
    class conexion
    {
        public static MySqlConnection crear_conexion()
        {
            string server = "localhost";
            string port = "3306";
            string usuario = "root";
            string password = "";
            string db = "perapod";
            string cadenaconexion = string.Format("Server={0};port={1};Uid={2};Pwd={3};database={4};",server,port,usuario,password,db);
            MySqlConnection conecta = new MySqlConnection();
            conecta.ConnectionString = cadenaconexion;
            conecta.Open();
            return conecta;

        }
    }
}
