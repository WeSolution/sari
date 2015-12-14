using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Recursos_Humanos.Capsule152
{
    public partial class Registro : System.Web.UI.Page
    {
        SQLServer S = new SQLServer();
        String men = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //S.Seguridad = false;
            //S.InitialCatalog = "SARI_RH_Candy";
            //S.Server = @"BLUEEQUINOX\SQLEXPRESS";

            //S.Seguridad = true;
            //S.InitialCatalog = "SARI_RH_Candy";
            //S.Server = @"sari.servehttp.com";
            //S.Login = "Server";
            //S.Password = "F46987DE89";

            DDLSexo.Items.Clear();
            DDLSexo.Items.Add("Masculino");
            DDLSexo.Items.Add("Femenino");
            this.CalendarFecha_Nac.VisibleDate = new DateTime(1990, 1, 1); //y/m/d
            DDLEstadoCivil.Items.Clear();
            DDLEstadoCivil.Items.Add("Soltero(a)");
            DDLEstadoCivil.Items.Add("Casado(a)");
            DDLEstadoCivil.Items.Add("Viudo(a)");
            DDLEstadoCivil.Items.Add("Divorciado(a)");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String date = DDLDia.SelectedValue.ToString() + "/" + DDLMes.SelectedValue.ToString() + "/" + DDLAno.SelectedValue.ToString();
            DateTime FechaNac = Convert.ToDateTime(date);
            int IDCandidato = 0;
            if (TBNombre1.Text == "" || TBApaterno.Text == "" || TBAmaterno.Text == "" ||
                DDLSexo.SelectedIndex == -1 || TBNacio.Text == "" || TBEmail.Text == "" ||
                DDLEstadoCivil.SelectedIndex == -1 || TBCurp.Text == "" || TBTel1.Text == "" ||
                DDLDia.SelectedIndex == -1 || DDLMes.SelectedIndex == -1 || DDLAno.SelectedIndex == -1)
            {
                String Mensaje = "Los campos marcados con * son obligatorios";
                MessageBox.Show(this, Mensaje);
            }
            else
            {
                SqlConnection cn = S.Conect(ref men);

                SqlCommand comando = new SqlCommand();
                SqlParameter Nom = new SqlParameter("@Nombre", SqlDbType.VarChar);
                SqlParameter AP = new SqlParameter("@Ape_Pat", SqlDbType.VarChar);
                SqlParameter AM = new SqlParameter("@Ape_Mat", SqlDbType.VarChar);
                SqlParameter Sexo = new SqlParameter("@Sexo", SqlDbType.VarChar);
                SqlParameter Nacimiento = new SqlParameter("@Fecha_Nac", SqlDbType.Date);
                SqlParameter Nacionalidad = new SqlParameter("@Nacionalidad", SqlDbType.VarChar);
                SqlParameter Correo = new SqlParameter("@E_Mail", SqlDbType.VarChar);
                SqlParameter EstadoCivil = new SqlParameter("@Estado_Civil", SqlDbType.VarChar);
                SqlParameter RFC = new SqlParameter("@RFC", SqlDbType.VarChar);
                SqlParameter Seguro = new SqlParameter("@No_IMSS", SqlDbType.VarChar);
                SqlParameter CURP = new SqlParameter("@CURP", SqlDbType.VarChar);
                SqlParameter Telefono1 = new SqlParameter("@Telefono1", SqlDbType.VarChar);
                SqlParameter Telefono2 = new SqlParameter("@Telefono2", SqlDbType.VarChar);

                SqlParameter idnuevo = new SqlParameter("@IDNuevo", SqlDbType.Int);
                idnuevo.Direction = ParameterDirection.Output;

                if (cn != null)
                {
                    comando.Connection = cn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "IngresarCandidato";

                    Nom.Value = TBNombre1.Text;
                    AP.Value = TBApaterno.Text;
                    AM.Value = TBAmaterno.Text;
                    Sexo.Value = DDLSexo.SelectedValue;
                    Nacimiento.Value = FechaNac;
                    Nacionalidad.Value = TBNacio.Text;
                    Correo.Value = TBEmail.Text;
                    EstadoCivil.Value = DDLEstadoCivil.SelectedValue;
                    RFC.Value = TBRFC.Text;
                    Seguro.Value = TBIMSS.Text;
                    CURP.Value = TBCurp.Text;
                    Telefono1.Value = TBTel1.Text;
                    Telefono2.Value = TBTel2.Text;

                    idnuevo.Value = 0;

                    comando.Parameters.Add(Nom);
                    comando.Parameters.Add(AP);
                    comando.Parameters.Add(AM);
                    comando.Parameters.Add(Sexo);
                    comando.Parameters.Add(Nacimiento);
                    comando.Parameters.Add(Nacionalidad);
                    comando.Parameters.Add(Correo);
                    comando.Parameters.Add(EstadoCivil);
                    comando.Parameters.Add(RFC);
                    comando.Parameters.Add(Seguro);
                    comando.Parameters.Add(CURP);
                    comando.Parameters.Add(Telefono1);
                    comando.Parameters.Add(Telefono2);

                    comando.Parameters.Add(idnuevo);

                    try
                    {
                        comando.ExecuteNonQuery();
                        IDCandidato = (int)idnuevo.Value;
                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(this, "A͟l͝gún̛ ̧c̕am͏p̛o dej̕aste e͏n ̨bla͡ņco ҉o̵ ҉al̛g̶o͘ ͏pu͢d̴o ̴ha͟be̢r ͏sa̧l̸i̶do ́m͟a̶l,͟ ̡pru̡e͠ba ̷o̧t͢ra v̨e͝z̶.̢ \n ̷S̢i͜ e̷l pr̸oble̛ma p͟e̢rsi͞st͝e,̵ ́péga̛l͢e͡ ͢a͠l̀ ͡C̕PU.̨ ̀Eso͜ ͢si͡empr͞e fu̵n̕c̷i͏o͜na! ;)");
                        MessageBox.Show(this, "Error: " + w.Message);
                    }

                    MessageBox.Show(this, men);

                    cn.Close();

                }
                Response.Redirect("/RH2/Capsule152/Direccion.aspx?IDCandidato=" + IDCandidato);
            }
        }
    }
}