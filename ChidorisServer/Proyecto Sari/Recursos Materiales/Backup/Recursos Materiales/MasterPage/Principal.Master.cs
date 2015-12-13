using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recursos_Materiales.MasterPage
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = (string)(Session["user"]);
            string id_usuario = (string)(Session["id_usuario"]);
            string privilegios = (string)(Session["privilegio"]);
            // Page.ClientScript.RegisterStartupScript(GetType(), "MiScript", "alert('Bievenido, conectado al Servidor: " + Session["user"] + " " + Session["id_usuario"] + "')", true);     
            // NameUsuario.Text = "Usuario: " + usuario + " Privilegio:" + privilegios + " id: " + id_usuario;
            NameUsuario.Text = "Name: " + usuario;
            if (!IsPostBack)
            {
                Session["activa"] = true;
                Session.Timeout = 1;
                //lbtiempo.Text = "La sesion actual dura " + (Session.Timeout * 60).ToString() + "segundos";
                int ahora = DateTime.Now.Second;
                int tiemporest = Session.Timeout * 60 - ahora;
                if (tiemporest >= 60)
                {
                    Session.RemoveAll();
                    string script = @"alert('Vuelva Iniciar Sesión');
                   window.location.href='http://localhost:6430/login.aspx';";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

                    //Response.Redirect("login.aspx");
                }
                switch (privilegios)
                {
                    case "Superadministrador":
                      superadmin();
                        break;
                    case "administrador":
                       administrador();
                        break;
                    case "usuario":
                      usuarios();
                        break;
                    case "":
                        Response.Redirect("http://localhost:6430/login.aspx");
                        break;
                    case null:
                        Response.Redirect("http://localhost:6430/login.aspx");
                        break;
                }
            } 

        }

        protected void usuarios()
        {
            string menu = string.Format(@"
         <ul class='nav navbar-nav'>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Entradas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Entradas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='../Entradas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                          <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Salidas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Salidas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='../Salidas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Requisiciones<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Requisiciones/Busqueda de Requisiciones.aspx'>Buscar Requisición</a></li>
                                <li><a href='#'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Almacén<span class='caret'></span></a>
                                <ul class='dropdown-menu'>
                                    <li><a href='../Almacén/Consultas.aspx'>Consultar</a></li>
                                </ul>
                         </li>
");
            this.LiteralMenu.Text = menu;
            //this.Ltmenu.Text = html;
        }
        protected void administrador()
        {

            string menu = string.Format(@"
                    <ul class='nav navbar-nav'>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Entradas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Entradas/Nueva Entrada.aspx'>Nueva Entrada</a></li>
                                <li><a href='../Entradas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='../Entradas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                          <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Salidas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Salidas/Nueva Salida.aspx'>Nueva Salida</a></li>
                                <li><a href='../Salidas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='../Salidas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Requisiciones<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='#'>Nueva Requisición</a></li>
                                <li><a href='../Requisiciones/Busqueda de Requisiciones.aspx'>Buscar Requisición</a></li>
                                <li><a href='#'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Almacén<span class='caret'></span></a>
                                <ul class='dropdown-menu'>
                                    <li><a href='../Almacén/Consultas.aspx'>Consultar</a></li>
                                </ul>
                         </li>

                 ");
            this.LiteralMenu.Text = menu;
        }
        protected void superadmin()
        {

            string menu = string.Format(@"
                    <ul class='nav navbar-nav'>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Entradas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Entradas/Nueva Entrada.aspx'>Nueva Entrada</a></li>
                                <li><a href='../Entradas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='../Entradas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                          <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Salidas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Salidas/Nueva Salida.aspx'>Nueva Salida</a></li>
                                <li><a href='../Salidas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='../Salidas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Requisiciones<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='#'>Nueva Requisición</a></li>
                                <li><a href='../Requisiciones/Busqueda de Requisiciones.aspx'>Buscar Requisición</a></li>
                                <li><a href='#'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Almacén<span class='caret'></span></a>
                                <ul class='dropdown-menu'>
                                    <li><a href='../Almacén/Consultas.aspx'>Consultar</a></li>
                                </ul>
                         </li>
                  ");
            this.LiteralMenu.Text = menu;
        }


        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Session.Clear();

            // FormsAuthentication.SignOut(); 
            Session.Clear();
            Response.Cache.SetCacheability(
            HttpCacheability.NoCache);
            Session.Remove("user");
            Session.Remove("id_usuario");
            Session.Remove("privilegio");

            Response.Redirect("http://localhost:6430/login.aspx");
        }
    }
}