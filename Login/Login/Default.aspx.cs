using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Login
{
    public partial class login : System.Web.UI.Page
    {
        string men = "";
        SqlConnection con;
        
        DataSet almacen = new DataSet();
        string usuario = "";
        string pass = "";  
        string privilegios = "";
        string id_usuario = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btningresar_Click(object sender, EventArgs e)
        {
           
            registerclass obj1 = new registerclass();
            obj1.cadena = System.Configuration.ConfigurationManager.ConnectionStrings[1].ToString();
           
           // obj1.cadena = "Initial Catalog = sari;Persist Security Info=False; Data Source=MAURIWOLFF\\DEAMAU;Integrated Security=True";
            con = obj1.Conectar(ref men);
            
                String cons = "Select * from usuario where usuario = '" + txtusuario.Text + "' and pass = '" + txtpass.Text + "'"; ;
                almacen = obj1.consultas(cons, con);
                if (almacen.Tables[0].Rows.Count == 0)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "MiScript", "alert('Contraseña incorrecta')", true);
                   
                }
                else
                {
                    foreach (DataRow fil in almacen.Tables[0].Rows)
                    {
                        usuario = fil["usuario"].ToString();
                        pass = fil["pass"].ToString();
                        privilegios = fil["privilegio"].ToString();
                        id_usuario = fil["id_usuario"].ToString();
                    }
                    User u = new User(usuario, pass, "root");
                    Application["user"] = u;
                    Application["privilegio"] = privilegios;
                    if (u.esValido(txtusuario.Text, txtpass.Text))
                    {
                        switch (area.SelectedIndex)
                        {
                            case 0:
                                Response.Redirect("/RH/Default.aspx");
                                break;
                            case 1:
                                Response.Redirect("/Finanzas/Default.aspx");
                                break;
                            case 2:
                                Response.Redirect("/Materiales/Default.aspx");
                                break; 
                        }
                    } 
                    else
                    {
                        lblerror.Text = "¡Error de Inicio de Sesion los datos porporcionados son incorrectos!";

                    } 
                } 
        }

        protected void LBTNRH2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RH2/Default.aspx");
        }
    }
}