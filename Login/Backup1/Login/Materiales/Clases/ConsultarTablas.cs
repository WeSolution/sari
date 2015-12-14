using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Importar Librerías
using System.Data;
using System.Data.SqlClient;

namespace Altaderequisicion
{
    public class ConsultarTablas
    {
        // Instanciar la conexión
        ConexionBL cn = new ConexionBL();

        // Definir una vista que filtre los productos
        private DataView dv;
        public ConsultarTablas()
        {
            // Definir al DataView como vista de productos
            dv = listadoServicios().DefaultView;
            dv = listadoProducto().DefaultView;
        }

       

        // Listar Productos
        public DataTable listadoProducto()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from producto", cn.getCn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        // Listar Servicios
        public DataTable listadoServicios()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from servicios", cn.getCn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        // Filtrar productos por su nombre
        public DataView filtro(string nom)
        {
            // Filtrar por las iniciales del nombre
            dv.RowFilter = "nombre LIKE '" + nom + "%'";
            // Retornar vista
            return dv;
        }
    }
}