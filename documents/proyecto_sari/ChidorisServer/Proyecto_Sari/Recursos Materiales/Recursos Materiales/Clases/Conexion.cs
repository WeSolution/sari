using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Recursos_Materiales.Clases
{
    public class Conexion2
    {
        private SqlConnection cn;

        public Conexion2()
        {
            //cn = new SqlConnection("Data Source = sari.servehttp.com; Initial Catalog = SARI; user= Server; pwd=F46987DE89;");
            cn = new SqlConnection("Initial Catalog = sari;Persist Security Info=False; Data Source=localhost;Integrated Security=True");
        }

        public SqlConnection getCn
        {
            get
            {
                return cn;
            }
        }
    }
}