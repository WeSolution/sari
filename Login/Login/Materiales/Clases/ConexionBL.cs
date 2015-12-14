using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Importar Librerías
using System.Data;
using System.Data.SqlClient;

namespace Altaderequisicion
{
    public class ConexionBL
    {
        // Establecer la conexión
        private SqlConnection cn;

        public ConexionBL()
        {
            // Inicializar la conexión
            cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[5].ToString());
        }

        // Retornar la conexión
        public SqlConnection getCn
        {
            get
            {
                return cn;
            }
        }
    }
}