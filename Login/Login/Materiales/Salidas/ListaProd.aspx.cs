using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.Data;

namespace Login.Materiales.Salidas
{
    public partial class ListaProd : System.Web.UI.Page
    {
        int index;
        Conexion1 con = new Conexion1();
        DataTable tab = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            tab = con.Consultas("select p.id_producto as Id, p.identificador as Identificador,p.nombre as Nombre, p.marca as Marca, p.modelo as Modelo, p.descripcion as Descripción, " +
                    " p.grupo as Grupo, p.localizacion as Localización, p.precio_compra as Precio, p.unidad_medida as Medida, p.cantidad_medida as Cantidad_Medida, " +
                    " p.stock as Existencia from producto as p");
            GridView1.DataSource = tab;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            index = Convert.ToInt32(e.CommandArgument);

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            //ClientScript.RegisterStartupScript(GetType(), "mensaje", "PassDato(1);", true);
            string id = tab.Rows[index][0].ToString();
            ScriptManager.RegisterStartupScript(this.btn, GetType(), "popup", "PassDato('" + id + "');", true);
        }
    }
}