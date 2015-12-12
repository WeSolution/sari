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
        
        ////Método que permite conectar con la base de datos
        //public static SqlConnection conectar_bd(string s)
        //{
        //   // String cadena = "Persist Security Info=False;User ID=Server;pwd=F46987DE89;Initial Catalog=sari;Data Source=sari.servehttp.com";
            
        //    //string cadena = "Data Source =recuerdos.ddns.net; Initial Catalog = sari; user id =Server; password =F46987DE89;";
        //    SqlConnection conexion = new SqlConnection(s);
        //    return conexion;
        //}
        public  SqlConnection conectar_bd(string s)
        {
            // String cadena = "Persist Security Info=False;User ID=Server;pwd=F46987DE89;Initial Catalog=sari;Data Source=sari.servehttp.com";

            //string cadena = "Data Source =recuerdos.ddns.net; Initial Catalog = sari; user id =Server; password =F46987DE89;";
            SqlConnection conexion = new SqlConnection(s); 
            return conexion;
        }
    }
}