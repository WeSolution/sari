using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security;
using System.Security.Authentication;
namespace Recursos_Financieros.MasterPage
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
               //string tipo = (string)Session["privilegio"];
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
            string menu = string.Format(@"<ul class='nav navbar-nav'>
<li><a href='../Formularios/ReporteMensual.aspx'><img src='../Imagenes/reports-icon.png' height='20' width='20'/>Reportes<span class='sr-only'>(current)</span></a></li>
   ");
            this.LiteralMenu.Text = menu;
            //this.Ltmenu.Text = html;
        }
        protected void administrador()
        {

            string menu = string.Format(@"
                <ul class='nav navbar-nav'>
<li><a class='active' href='../Formularios/Solicitudes.aspx'><img src='../Imagenes/requi-icon.png' height='20' width='20'/>Requisiciones Pendientes<span class='sr-only'>(current)</span></a></li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='../Imagenes/prod-icon.png' height='20' width='20'/>Productos<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Formularios/AltaProducto.aspx'>Producto</a></li>
                            </ul>
                         </li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='../Imagenes/serv_icon.png' height='20' width='20'/>Servicios<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Formularios/AltaServicio.aspx'>Nuevo Servicio</a></li>
                            </ul>
                         </li>
<li><a href='../Formularios/ReporteMensual.aspx'><img src='../Imagenes/reports-icon.png' height='20' width='20'/>Reportes<span class='sr-only'>(current)</span></a></li>
  ");
            this.LiteralMenu.Text = menu;
        }
        protected void superadmin()
        {

            string menu = string.Format(@"
                <ul class='nav navbar-nav'>
                        <li><a class='active' href='../Formularios/Solicitudes.aspx'><img src='../Imagenes/requi-icon.png' height='20' width='20'/>Requisiciones Pendientes<span class='sr-only'>(current)</span></a></li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='../Imagenes/prod-icon.png' height='20' width='20'/>Productos<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Formularios/AltaProducto.aspx'>Producto</a></li>
                            </ul>
                         </li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='../Imagenes/serv_icon.png' height='20' width='20'/>Servicios<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Formularios/AltaServicio.aspx'>Nuevo Servicio</a></li>
                            </ul>
                         </li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='../Imagenes/provider-icon.png' height='20' width='20'>Proveedores<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='../Formularios/AltaProveedor.aspx'>Nuevo Proveedor</a></li>
                                <li><a href='../Formularios/ValidarProveedor.aspx'>Validar Proveedor</a></li>
                            </ul>
                         </li>
                        <li><a href='../Formularios/ReporteMensual.aspx'><img src='../Imagenes/reports-icon.png' height='20' width='20'/>Reportes<span class='sr-only'>(current)</span></a></li>
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