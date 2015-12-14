using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Altaderequisicion;
using System.Data;

namespace Recursos_Materiales.Requisiciones
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Si la pagina no ha ido al servidor
            if (!IsPostBack)
            {
                // Si no hay cookie
                if (Request.Cookies["dato"] == null)
                {
                    Response.Redirect("../Requisiciones/Nueva Requisicion.aspx");
                }
                else
                {
                    // Recupero datos
                    lbcodigo.Text = Request.Cookies["dato"].Values["codigo"];
                    lbidentificador.Text = Request.Cookies["dato"].Values["identificador"];
                    lbnombre.Text = Request.Cookies["dato"].Values["nombre"];
                    lbmarca.Text = Request.Cookies["dato"].Values["marca"];
                    lbmodelo.Text = Request.Cookies["dato"].Values["modelo"];
                    lbdescripcion.Text = Request.Cookies["dato"].Values["descripcion"];
                    lbgrupo.Text = Request.Cookies["dato"].Values["grupo"];
                    lblocalizacion.Text = Request.Cookies["dato"].Values["localizacion"];
                    lbpcompra.Text = Request.Cookies["dato"].Values["pcompra"];
                    lblUnidad.Text = Request.Cookies["dato"].Values["unidad"];
                    lbcantidad.Text = Request.Cookies["dato"].Values["cantidad"];
                    lbstock.Text = Request.Cookies["dato"].Values["stock"];
                    lbfecha.Text = Request.Cookies["dato"].Values["fecha"];

                }
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Instanciar DetalleBL y le pasamos como parámetro la sesión
            MetodosCarrito tabla = new MetodosCarrito((DataTable)Session["carrito"], (DataTable)Session["carrito"]);

            // Ejecuto y muestro el mensaje
            string message = tabla.agregar(int.Parse(lbcodigo.Text), lbidentificador.Text, lbnombre.Text, lbmarca.Text, lbmodelo.Text, lbdescripcion.Text,
                lbgrupo.Text, lblocalizacion.Text, decimal.Parse(lbpcompra.Text), lblUnidad.Text, int.Parse(lbcantidad.Text), int.Parse(lbstock.Text), Convert.ToDateTime(lbfecha.Text), int.Parse(txtCantidad.Text));

            ClientScript.RegisterStartupScript(typeof(Page), "alert",
            "<script language=JavaScript>alert('" + (message) + "');</script>");

            // Actualizamos la sesión
            Session["carrito"] = tabla.getRegistro;
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Requisiciones/Carrito.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Requisiciones/Nueva Requisicion");
        }
    }
}