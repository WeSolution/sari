using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recursos_Humanos.MasterPage
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    string usuario = (string)(Session["user"]);
            //    string id_usuario = (string)(Session["id_usuario"]);
            //    string privilegios = (string)(Session["privilegio"]);
            //    // Page.ClientScript.RegisterStartupScript(GetType(), "MiScript", "alert('Bievenido, conectado al Servidor: " + Session["user"] + " " + Session["id_usuario"] + "')", true);     
            //    // NameUsuario.Text = "Usuario: " + usuario + " Privilegio:" + privilegios + " id: " + id_usuario;
            //    NameUsuario.Text = "Name: " + usuario;
            //    Session["activa"] = true;
            //    Session.Timeout = 1;
            //    //lbtiempo.Text = "La sesion actual dura " + (Session.Timeout * 60).ToString() + "segundos";
            //    int ahora = DateTime.Now.Second;
            //    int tiemporest = Session.Timeout * 60 - ahora;
            //    if (tiemporest >= 60)
            //    {
            //        Session.RemoveAll();
            //        string script = @"alert('Vuelva Iniciar Sesión');
            //       window.location.href='http://localhost:6430/login.aspx';";
            //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

            //        //Response.Redirect("login.aspx");
            //    }

            //    if (usuario == null || id_usuario == null || privilegios == null)
            //    {
            //        Response.Redirect("http://localhost:6430/login.aspx");
            //    }

            //}
        }
        

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            //Session.RemoveAll();
            //Session.Abandon();
            //Session.Clear();

            //// FormsAuthentication.SignOut(); 
            //Session.Clear();
            //Response.Cache.SetCacheability(
            //HttpCacheability.NoCache);
            //Session.Remove("user");
            //Session.Remove("id_usuario");
            //Session.Remove("privilegio");

            //Response.Redirect("http://localhost:6430/login.aspx");
        }
    }
}