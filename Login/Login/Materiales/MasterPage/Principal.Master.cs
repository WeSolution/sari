using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Login; 
namespace Recursos_Materiales.MasterPage
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

        protected void usuarios()
        {
            string menu = string.Format(@"
         <ul class='nav navbar-nav'>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Entradas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Materiales/Entradas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='/Materiales/Entradas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                          <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Salidas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Materiales/Salidas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='/Materiales/Salidas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Requisiciones<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Materiales/Requisiciones/Busqueda de Requisiciones.aspx'>Buscar Requisición</a></li> 
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Almacén<span class='caret'></span></a>
                                <ul class='dropdown-menu'>
                                    <li><a href='/Materiales/Almacén/Consultas.aspx'>Consultar</a></li>
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
                                <li><a href='/Materiales/Entradas/Nueva Entrada.aspx'>Nueva Entrada</a></li>
                                <li><a href='/Materiales/Entradas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='/Materiales/Entradas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                          <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Salidas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Materiales/Salidas/Nueva Salida.aspx'>Nueva Salida</a></li>
                                <li><a href='/Materiales/Salidas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='/Materiales/Salidas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Requisiciones<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                 
                                <li><a href='/Materiales/Requisiciones/Busqueda de Requisiciones.aspx'>Buscar Requisición</a></li>
                                <li><a href='#'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Almacén<span class='caret'></span></a>
                                <ul class='dropdown-menu'>
                                    <li><a href='/Materiales/Almacén/Consultas.aspx'>Consultar</a></li>
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
                                <li><a href='/Materiales/Entradas/Nueva Entrada.aspx'>Nueva Entrada</a></li>
                                <li><a href='/Materiales/Entradas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='/Materiales/Entradas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                          <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Salidas<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                <li><a href='/Materiales/Salidas/Nueva Salida.aspx'>Nueva Salida</a></li>
                                <li><a href='/Materiales/Salidas/Consultas.aspx'>Consultas</a></li>
                                <li><a href='/Materiales/Salidas/Reportes.aspx'>Reportes</a></li>
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Requisiciones<span class='caret'></span></a>
                            <ul class='dropdown-menu'>
                                
                                <li><a href='/Materiales/Requisiciones/Busqueda de Requisiciones.aspx'>Buscar Requisición</a></li>
                              
                            </ul>
                         </li>
                         <li class='dropdown'>
                            <a class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Almacén<span class='caret'></span></a>
                                <ul class='dropdown-menu'>
                                    <li><a href='/Materiales/Almacén/Consultas.aspx'>Consultar</a></li>
                                </ul>
                         </li>
                  ");
            this.LiteralMenu.Text = menu;
        }

        private void verificaUsuario()
        {
            if (!u.Valido)
                Response.Redirect("/");
        }

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Application["user"] = null;
            Session.Clear();
            Response.Cache.SetCacheability(
            HttpCacheability.NoCache);
            Response.Redirect("/");
        }
    }
}