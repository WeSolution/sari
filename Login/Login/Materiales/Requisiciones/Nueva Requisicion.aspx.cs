using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Altaderequisicion;

namespace Recursos_Materiales.Requisiciones
{
    public partial class Nueva_Requisicion : System.Web.UI.Page
    {
        // Instanciar ProductoBL
        ConsultarTablas p = new ConsultarTablas();


        protected void Page_Load(object sender, EventArgs e)
        {




        }


        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Al cambiar de pagina
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = p.listadoProducto();
            GridView1.DataBind();
        }

        /* protected void btnBuscar_Click(object sender, EventArgs e)
         {
             // Filtrar
             GridView1.DataSource = p.filtro(txtNombre.Text);
             GridView1.DataBind();
           
         }
         */
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el indice de la fila seleccionada
            int f = GridView1.SelectedIndex;
            // Al seleccionar una fila enviar los datos del producto al siguiente formulario
            HttpCookie dato = new HttpCookie("dato");
            if (rbtproducto.Checked == true)
            {
                // Recuperamos datos
                dato.Values.Add("codigo", GridView1.Rows[f].Cells[1].Text);
                dato.Values.Add("identificador", Server.HtmlDecode(GridView1.Rows[f].Cells[2].Text));
                dato.Values.Add("nombre", Server.HtmlDecode(GridView1.Rows[f].Cells[3].Text));
                dato.Values.Add("marca", Server.HtmlDecode(GridView1.Rows[f].Cells[4].Text));
                dato.Values.Add("modelo", Server.HtmlDecode(GridView1.Rows[f].Cells[5].Text));
                dato.Values.Add("descripcion", Server.HtmlDecode(GridView1.Rows[f].Cells[6].Text));
                dato.Values.Add("grupo", Server.HtmlDecode(GridView1.Rows[f].Cells[7].Text));
                dato.Values.Add("localizacion", Server.HtmlDecode(GridView1.Rows[f].Cells[8].Text));
                dato.Values.Add("pcompra", GridView1.Rows[f].Cells[9].Text);
                dato.Values.Add("pventa", GridView1.Rows[f].Cells[10].Text);
                dato.Values.Add("cantidad", GridView1.Rows[f].Cells[11].Text);
                dato.Values.Add("stock", GridView1.Rows[f].Cells[12].Text);
                dato.Values.Add("fecha", GridView1.Rows[f].Cells[13].Text);

                // Enviar al cookie
                Response.Cookies.Add(dato);
                // Redireccionar
                Response.Redirect("../Requisiciones/Producto.aspx");
            }
            else
            {
                if (rbtservicio.Checked == true)
                {
                    // Recuperamos datos
                    dato.Values.Add("codigo", GridView1.Rows[f].Cells[1].Text);
                    dato.Values.Add("identificador", Server.HtmlDecode(GridView1.Rows[f].Cells[2].Text));
                    dato.Values.Add("nombre", Server.HtmlDecode(GridView1.Rows[f].Cells[3].Text));
                    dato.Values.Add("descripcion", Server.HtmlDecode(GridView1.Rows[f].Cells[4].Text));
                    dato.Values.Add("precio", GridView1.Rows[f].Cells[5].Text);

                    // Enviar al cookie
                    Response.Cookies.Add(dato);
                    // Redireccionar
                    Response.Redirect("../Requisiciones/Servicio.aspx");
                }
            }


        }
        //Boton que ejecuta consulta de producto o servicio 
        protected void btnVer_Click(object sender, EventArgs e)
        {
            if (rbtservicio.Checked == true)
            {

                GridView1.DataSource = p.listadoServicios();
                GridView1.DataBind();
            }
            else
            {
                if (rbtproducto.Checked == true)
                {

                    GridView1.DataSource = p.listadoProducto();
                    GridView1.DataBind();


                }
            }
        }

        protected void rbtproducto_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rbtservicio_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}