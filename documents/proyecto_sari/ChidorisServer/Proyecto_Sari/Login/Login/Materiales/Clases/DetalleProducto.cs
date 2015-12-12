using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Importar Librerías
using System.Data;
using System.Data.SqlClient;

namespace Altaderequisicion
{
    public class DetalleProducto
    {
        // Definir un DataTable: estructura del carrito
        private DataTable tabla;
      

        public DetalleProducto()
        {
            // Inicializar tabla
            tabla = new DataTable();

            // Columnas que Tendra en Carrito para productos 
            tabla.Columns.Add("CODIGO", Type.GetType("System.Int32")); // Le damos un nombre y tipo de dato
            tabla.Columns.Add("IDENTIFICADOR", Type.GetType("System.String"));
            tabla.Columns.Add("NOMBRE", Type.GetType("System.String"));
            tabla.Columns.Add("MARCA", Type.GetType("System.String"));
            tabla.Columns.Add("MODELO", Type.GetType("System.String"));
            tabla.Columns.Add("DESCRIPCION", Type.GetType("System.String"));
            tabla.Columns.Add("GRUPO", Type.GetType("System.String"));
            tabla.Columns.Add("LOCALIZACION", Type.GetType("System.String"));
            tabla.Columns.Add("PRECIO_DE_COMPRA", Type.GetType("System.Decimal"));
            tabla.Columns.Add("PRECIO_DE_VENTA", Type.GetType("System.Decimal"));
            tabla.Columns.Add("CANTI", Type.GetType("System.Int32"));
            tabla.Columns.Add("STOCK", Type.GetType("System.Int32"));
            tabla.Columns.Add("FECHA", Type.GetType("System.DateTime"));
            tabla.Columns.Add("CANTIDAD", Type.GetType("System.Int32"));
            // Columna Calculada
            tabla.Columns.Add("TOTAL", Type.GetType("System.Decimal"), "PRECIO_DE_COMPRA*cantidad");
            // Definir clave
            tabla.PrimaryKey = new DataColumn[] { tabla.Columns[0] };
        }

        // Retornar tabla
        public DataTable getTabla
        {
            get
            {
                return tabla;
            }
        }
    }
}