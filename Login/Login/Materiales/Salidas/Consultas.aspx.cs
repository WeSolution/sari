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
            try
            {
                string f1 = Cal1.SelectedDate.ToString("yyyy-MM-dd");
                string f2 = Cal2.SelectedDate.ToString("yyyy-MM-dd");
                tab = con.Consultas("Select id_salida as Folio, Convert(char,fecha,103) as Fecha,Convert(nvarchar,hora,108) as Hora, descripcion as Descripción, nombre + ' ' + apellido_p + ' ' + apellido_m as Empleado  from salida, empleado" + 
                    " where salida.id_empleado = empleado.id_empleado and fecha BETWEEN '" + f1 + "' And '" + f2 + "';");
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
            catch (Exception)
            {
                Response.Write("<script>window.alert('No hay registros en el rango de fechas seleccionados');</script>");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string ids = GridView1.Rows[index].Cells[1].Text;
                GridView2.DataSource = con.Consultas("Select producto.id_producto as ID, nombre as Producto, no_articulos as Cantidad from producto, detalle_salida" +
                    " where producto.id_producto = detalle_salida.id_salida and id_salida = " + ids);
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }


    }
}