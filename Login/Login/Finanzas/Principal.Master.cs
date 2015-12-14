using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security;
using System.Security.Authentication;
using Login;
namespace Recursos_Financieros.MasterPage
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        User u = null;
        string privilegio;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    u = (User)Application["user"];
                    privilegio = (string)Application["privilegio"];
                    NameUsuario.Text = "Usuario: " + u.user + " Privilegio:" + privilegio;
                    verificaUsuario();
                    switch (privilegio)
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
                            Response.Redirect("/");
                            break;
                        case null:
                            Response.Redirect("/");
                            break;
                    }
                }

            }
            catch (Exception x) { Response.Redirect("/"); }       
            

        }

        private void verificaUsuario()
        {
            if (!u.Valido)
                Response.Redirect("/");
        }

        protected void usuarios()
        {
            string menu = string.Format(@"<ul class='nav navbar-nav'>
<li><a href='/Finanzas/Formularios/ReporteMensual.aspx'><img src='/Finanzas/Imagenes/reports-icon.png' height='20' width='20'/>Reportes<span class='sr-only'>(current)</span></a></li>
              ");
            this.LiteralMenu.Text = menu;
            //this.Ltmenu.Text = html;
        }
        protected void administrador()
        {

            string menu = string.Format(@"
                <ul class='nav navbar-nav'>
<li><a class='active' href='/Finanzas/Formularios/Solicitudes.aspx'><img src='/Finanzas/Imagenes/requi-icon.png' height='20' width='20'/>Requisiciones Pendientes<span class='sr-only'>(current)</span></a></li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='/Finanzas/Imagenes/prod-icon.png' height='20' width='20'/>Productos<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Finanzas/Formularios/AltaProducto.aspx'>Producto</a></li>
                            </ul>
                         </li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='/Finanzas/Imagenes/serv_icon.png' height='20' width='20'/>Servicios<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Finanzas/Formularios/AltaServicio.aspx'>Nuevo Servicio</a></li>
                            </ul>
                         </li>
<li><a href='/Finanzas/Formularios/ReporteMensual.aspx'><img src='/Finanzas/Imagenes/reports-icon.png' height='20' width='20'/>Reportes<span class='sr-only'>(current)</span></a></li>
  ");
            this.LiteralMenu.Text = menu;
        }
        protected void superadmin()
        {

            string menu = string.Format(@"
                <ul class='nav navbar-nav'>
                        <li><a class='active' href='/Finanzas/Formularios/Solicitudes.aspx'><img src='/Finanzas/Imagenes/requi-icon.png' height='20' width='20'/>Requisiciones Pendientes<span class='sr-only'>(current)</span></a></li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='/Finanzas/Imagenes/prod-icon.png' height='20' width='20'/>Productos<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Finanzas/Formularios/AltaProducto.aspx'>Producto</a></li>
                            </ul>
                         </li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='/Finanzas/Imagenes/serv_icon.png' height='20' width='20'/>Servicios<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Finanzas/Formularios/AltaServicio.aspx'>Nuevo Servicio</a></li>
                            </ul>
                         </li>
                        <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'><img src='/Finanzas/Imagenes/provider-icon.png' height='20' width='20'>Proveedores<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Finanzas/Formularios/AltaProveedor.aspx'>Nuevo Proveedor</a></li>
                                <li><a href='/Finanzas/Formularios/ValidarProveedor.aspx'>Validar Proveedor</a></li>
                            </ul>
                         </li>
                        <li><a href='/Finanzas/Formularios/ReporteMensual.aspx'><img src='/Finanzas/Imagenes/reports-icon.png' height='20' width='20'/>Reportes<span class='sr-only'>(current)</span></a></li>
            ");
            this.LiteralMenu.Text = menu;
        }

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            
        }

        protected void Cerrar_Click1(object sender, EventArgs e)
        {
            Application["user"] = null;
            Response.Redirect("/");

        }
    }
}