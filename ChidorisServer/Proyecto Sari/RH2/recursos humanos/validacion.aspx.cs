using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recursos_Humanos
{
    public partial class validacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id_usuario = Convert.ToString(Request.QueryString["id"]);
            string usuario = Convert.ToString(Request.QueryString["user"]);
            string privilegio = Convert.ToString(Request.QueryString["privilegio"]);
            //Page.ClientScript.RegisterStartupScript(GetType(), "MiScript", "alert('Bievenido, conectado al Servidor: " + usuario + " " + privilegio + "')", true);

            Session.Add("user", usuario);
            Session.Add("privilegio", privilegio);
            Session.Add("id_usuario", id_usuario);
            Response.Redirect("http://localhost:2888/MasterPage/");
        }
    }
}