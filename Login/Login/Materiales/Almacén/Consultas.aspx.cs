using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;

namespace Recursos_Materiales.Catálogo
{
    public partial class Consultas : System.Web.UI.Page
    {
        Conexion1 con = new Conexion1();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = con.Consultas("select p.id_producto as Id, p.identificador as Identificador,p.nombre as Nombre, p.marca as Marca, p.modelo as Modelo, p.descripcion as Descripción, " +
                    " p.grupo as Grupo, p.localizacion as Localización, p.precio_compra as Precio, p.unidad_medida as Medida, p.cantidad_medida as Cantidad_Medida, " +
                    " p.stock as Existencia from producto as p");
            GridView1.DataBind();
        }
    }
}