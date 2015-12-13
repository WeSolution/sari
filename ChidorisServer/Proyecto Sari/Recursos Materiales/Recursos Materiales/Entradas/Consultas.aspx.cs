using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.Data;

namespace Recursos_Materiales.Entradas
{
    public partial class Consultas : System.Web.UI.Page
    {
        Conexion1 con = new Conexion1();
        DataTable tab;

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string f1 = Cal1.SelectedDate.ToString("yyyy-MM-dd");
            string f2 = Cal2.SelectedDate.ToString("yyyy-MM-dd");
            tab = con.Consultas("select en.id_entrada as Folio,en.fecha as Fecha,en.hora as Hora,en.descripcion as Descripción,pd.nombre as Producto,den.no_articulos as Cantidad,pr.nombre as Proveedor, en.total as Total " +  
                " from proveedor as pr, producto as pd, entradas as en, detalle_entradas as den where pr.id_proveedor = (select id_proveedor from suministra where id_suministro = den.id_suministro) " +
                " and pd.id_producto = (select id_producto from suministra where id_suministro = den.id_suministro) and den.id_entrada = en.id_entrada and " +
                "en.fecha BETWEEN  '" + f1 + "' And '" + f2 + "';");
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
    }
}