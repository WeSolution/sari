using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.Data;

namespace Recursos_Materiales.Requisiciones
{
    public partial class Busqueda_de_Requisiciones : System.Web.UI.Page
    {
        Metodos M = new Metodos();
        string area = "RM";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // Si la pagina no ha ido al servidor
            if (!IsPostBack)
            {
                // Listar
                DataTable tab = M.Obtener_Requisiciones(area);
                GVListaRequisicion.DataSource = M.Obtener_Requisiciones(area);
                GVListaRequisicion.DataBind();
            }
        }

        protected void GVListaRequisicion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVListaRequisicion.PageIndex = e.NewPageIndex;
            GVListaRequisicion.DataSource = M.Obtener_Requisiciones(area);
            GVListaRequisicion.DataBind();
        }

        protected void GVListaRequisicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenemos el Indice de la fila seleccionada
            int f = GVListaRequisicion.SelectedIndex;

            // Al seleccionar una fila, este enviara los datos de la requisicion a la siguiente ventana
            HttpCookie dato = new HttpCookie("dato");

            // Recuperamos datos
            dato.Values.Add("idcompra", GVListaRequisicion.Rows[f].Cells[1].Text);
            dato.Values.Add("caracteristica", Server.HtmlDecode(GVListaRequisicion.Rows[f].Cells[2].Text));
            dato.Values.Add("tipo", Server.HtmlDecode(GVListaRequisicion.Rows[f].Cells[3].Text));
            dato.Values.Add("monto", GVListaRequisicion.Rows[f].Cells[4].Text);
            dato.Values.Add("fecha", GVListaRequisicion.Rows[f].Cells[5].Text);
            dato.Values.Add("status", GVListaRequisicion.Rows[f].Cells[6].Text);
            dato.Values.Add("idusu", GVListaRequisicion.Rows[f].Cells[7].Text);

            // Envia los datos al Cookie
            Response.Cookies.Add(dato);

            // Redirecciona
            Response.Redirect("Detalle de Requisicion.aspx");
        }
    }
}