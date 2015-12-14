using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;

namespace Recursos_Materiales.Requisiciones
{
    public partial class Detalle_de_Requisicion : System.Web.UI.Page
    {
        Metodos M = new Metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Si la pagina no ha ido al servidor
            if (!IsPostBack)
            {
                // Si no hay Cookie
                if (Request.Cookies["dato"] == null)
                {
                    //Si no hay Cookie redirecciona automaticaente a la pagina de busqueda de requisicion
                    Response.Redirect("Busqueda de Requisiciones.aspx");
                }
                else
                {
                    // Recupero datos del Cookie y se las asigna a las etiquetas
                    lbIdrequisicion.Text = Request.Cookies["dato"].Values["idcompra"];
                    lbCaracteristicas.Text = Request.Cookies["dato"].Values["caracteristica"];
                    lbTipo.Text = Request.Cookies["dato"].Values["tipo"];
                    lbMonto.Text = Request.Cookies["dato"].Values["monto"];
                    lbFecha.Text = Request.Cookies["dato"].Values["fecha"];
                    lbStatus.Text = Request.Cookies["dato"].Values["status"];
                    int id_cli = Convert.ToInt32(Request.Cookies["dato"].Values["idusu"]);
                    lbIdusuario.Text = M.Obtener_NombreCliente(id_cli); //llama a un metodo y obtiene una cadena de caracteres

                    //Se llama  a un metodo y obtiene de regreso una tabla 
                    GVListaPS.DataSource = M.Obtener_Productos(Convert.ToInt32(lbIdrequisicion.Text));
                    GVListaPS.DataBind();
                    //Se llama  a un metodo y obtiene de regreso una tabla
                    GVListaServicios.DataSource = M.Obtener_Servicios(Convert.ToInt32(lbIdrequisicion.Text));
                    GVListaServicios.DataBind();
                }
            }
        }

        protected void GVListaServicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            // Redirecciona a la pagina de busqueda de requisicion
            Response.Redirect("Busqueda de Requisiciones.aspx");
        }

        protected void GVListaPS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}