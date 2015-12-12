using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.Data;

namespace Recursos_Materiales.Salidas
{
    public partial class Consultas : System.Web.UI.Page
    {
        Conexion1 con = new Conexion1();
        DataTable tab;

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string f1 = Cal1.SelectedDate.ToString("yyyy-MM-dd");
            string f2 = Cal2.SelectedDate.ToString("yyyy-MM-dd");
            tab = con.Consultas("select s.id_salida as Folio,s.fecha as Fecha,s.hora as Hora,p.nombre as Producto,ds.no_articulos as Cantidad," +
                "e.nombre + ' ' + e.apellido_p + ' ' + e.apellido_m as Solicitante, s.descripcion as Descripción " +
                    "from salida as s, detalle_salida as ds, producto as p, empleado as e " + 
                    "where s.id_salida = ds.id_salida and p.id_producto = ds.id_producto and s.fecha BETWEEN '" + f1 + "' And '" + f2 + "';");
            if (tab.Rows.Count > 0)
            {
                GridView1.DataSource = tab;
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>window.alert('No hay registros en el rango de fechas seleccionados');</script>");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}