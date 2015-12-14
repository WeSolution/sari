using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Data;
namespace Login
{
    public partial class Register : System.Web.UI.Page
    {
        string usuario = "";
        string men = "";
        SqlConnection con;
        DataSet almacen = new DataSet();
        int id_empleado, user;
       registerclass obj1 = new registerclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            obj1.cadena = System.Configuration.ConfigurationManager.ConnectionStrings[1].ToString();
            Privilegio.Items.Add("Superadministrador");
            Privilegio.Items.Add("administrador");
            Privilegio.Items.Add("usuario");
            Privilegio.Items.Add("Invitado");
 
            area.Items.Add("Recursos Humanos");
            area.Items.Add("Finanzas");
            area.Items.Add("Recursos Materiales");

            Sexo.Items.Add("Masculino");
            Sexo.Items.Add("Femenino");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = obj1.Conectar(ref men);
            String cons = "Select usuario from usuario where usuario = '" + txtusuario.Text + "'"; 
            almacen = obj1.consultas(cons, con);
            foreach (DataRow fill in almacen.Tables[0].Rows)
            {
                usuario = fill["usuario"].ToString();

            }
            if (usuario == txtusuario.Text)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "MiScript", "alert('Usuario ya está en uso')", true);
            }
            else
            {

                id_empleado = obj1.insertarEmpleados(con, Nombre_empleado.Text, Apellido_p.Text, Apellido_m.Text, Direccion.Text, Telefono.Text, Correo.Text, Sexo.Text, ref men);

                obj1.InsertarUsuario(con, txtusuario.Text, txtpass.Text, id_empleado, Privilegio.Text, ref men);

                obj1.InsertarArea(con, area.Text, descripcion.Text, telearea.Text,id_empleado, ref men); 

                Page.ClientScript.RegisterStartupScript(GetType(), "MiScript", "alert('Registrado')", true);
                 
            }

        }
    }
}