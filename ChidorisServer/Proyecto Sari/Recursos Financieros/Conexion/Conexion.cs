using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Recursos_Financieros.Conexion
{
    public class Conexion
    {
        //Método que permite conectar con la base de datos
        public static SqlConnection conectar_bd()
        {
           // String cadena = "Persist Security Info=False;User ID=Server;pwd=F46987DE89;Initial Catalog=sari;Data Source=sari.servehttp.com";
            string cadena = "Initial Catalog = sari;Persist Security Info=False; Data Source=localhost;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            return conexion;
        }
    }
}