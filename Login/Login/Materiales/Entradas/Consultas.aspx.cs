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
        int index;
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string f1 = Cal1.SelectedDate.ToString("yyyy-MM-dd");
                string f2 = Cal2.SelectedDate.ToString("yyyy-MM-dd");
                tab = con.Consultas("Select id_entrada as Folio, Convert(char,fecha,103) as Fecha,Convert(nvarchar,hora,108) as Hora,descripcion as Descripción, total as Total," +
                    "nombre as Proveedor from entradas,proveedor where entradas.id_proveedor = proveedor.id_proveedor and fecha BETWEEN '" + f1 + "' And '" + f2 + "';");
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
                index = Convert.ToInt32(e.CommandArgument);
                string ide = GridView1.Rows[index].Cells[1].Text;
                GridView2.DataSource = con.Consultas("Select p.nombre as Producto,p.precio_compra as Precio,de.no_articulos as Cantidad from entradas as e,detalle_entradas as de,producto as p" +
                    " where e.id_entrada = de.id_entrada and de.id_producto = p.id_producto and e.id_entrada =" + ide);
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('" + ex.Message + "');</script>");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            con.DML("DELETE from detalle_entradas where id_entrada=" + GridView1.Rows[index].Cells[1].Text);
            con.DML("DELETE from entradas where id_entrada=" + GridView1.Rows[index].Cells[1].Text);
            string script = @"alert('Registro Eliminado');
                        window.location.href='../Entradas/Consultas.aspx'";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Mensaje", script, true);
        }
    }
}