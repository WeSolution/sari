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
            cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[5].ToString());
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