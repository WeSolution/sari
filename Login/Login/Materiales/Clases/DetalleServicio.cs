using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Importar Librerías
using System.Data;
using System.Data.SqlClient;

namespace Altaderequisicion.Metodos
{
    public class DetalleServicio
    {
         // Definir un DataTable: estructura del carrito
        private DataTable tabla2;
      

        public DetalleServicio()
        {
            // Inicializar tabla2
            tabla2 = new DataTable();

            // Columnas que tendra el carrito para servicios
            tabla2.Columns.Add("ID", Type.GetType("System.Int32")); // Le damos un nombre y tipo de dato
            tabla2.Columns.Add("IDENTIFICADOR", Type.GetType("System.String"));
            tabla2.Columns.Add("NOMBRE", Type.GetType("System.String"));
            tabla2.Columns.Add("DESCRIPCION", Type.GetType("System.String"));
            tabla2.Columns.Add("PRECIO", Type.GetType("System.Decimal"));
            tabla2.Columns.Add("CANTIDAD", Type.GetType("System.Int32"));
            // Columna Calculada
            tabla2.Columns.Add("TOTAL", Type.GetType("System.Decimal"), "PRECIO*CANTIDAD");
            // Definir clave
            tabla2.PrimaryKey = new DataColumn[] { tabla2.Columns[0] };
        }

        // Retornar tabla2
        public DataTable getTabla2
        {
            get
            {
                return tabla2;
            }
        }
    }
}