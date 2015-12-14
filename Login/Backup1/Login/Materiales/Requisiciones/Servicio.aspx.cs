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
    public partial class Servicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Si la pagina no ha ido al servidor
            if (!IsPostBack)
            {
                // Si no hay cookie
                if (Request.Cookies["dato"] == null)
                {
                    Response.Redirect("../Requisiciones/Nueva Requisicion");
                }
                else
                {
                    // Recupero datos
                    lbid.Text = Request.Cookies["dato"].Values["codigo"];
                    lbidentificador.Text = Request.Cookies["dato"].Values["identificador"];
                    lbnombre.Text = Request.Cookies["dato"].Values["nombre"];
                    lbdescripcion.Text = Request.Cookies["dato"].Values["descripcion"];
                    lbprecio.Text = Request.Cookies["dato"].Values["precio"];


                }
            }


        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Instanciar DetalleBL y le pasamos como parámetro la sesión
            MetodosCarrito tabla2 = new MetodosCarrito((DataTable)Session["carrito2"], (DataTable)Session["carrito2"]);

            // Ejecuto y muestro el mensaje
            string message = tabla2.agregar2(int.Parse(lbid.Text), lbidentificador.Text, lbnombre.Text, lbdescripcion.Text, Decimal.Parse(lbprecio.Text), int.Parse(txtCantidad.Text));

            ClientScript.RegisterStartupScript(typeof(Page), "alert",
            "<script language=JavaScript>alert('" + (message) + "');</script>");

            // Actualizamos la sesión
            Session["carrito2"] = tabla2.getRegistro2;
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