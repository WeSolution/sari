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
            int IDPersona = 0;
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
                #region insertaPersona
                SqlConnection cn = S.Conect(ref men);

                SqlCommand comando = new SqlCommand();
                SqlParameter Nom = new SqlParameter("@nombre", SqlDbType.VarChar);
                SqlParameter AP = new SqlParameter("@apaterno", SqlDbType.VarChar);
                SqlParameter AM = new SqlParameter("@amaterno", SqlDbType.VarChar);
                SqlParameter CURP = new SqlParameter("@curp", SqlDbType.VarChar);
                SqlParameter RFC = new SqlParameter("@rfc", SqlDbType.VarChar);
                SqlParameter Nacimiento = new SqlParameter("@fechanac", SqlDbType.Date);
                SqlParameter Sexo = new SqlParameter("@sexo", SqlDbType.VarChar);
                SqlParameter EstadoCivil = new SqlParameter("@estadocivil", SqlDbType.VarChar);
                SqlParameter Estatus = new SqlParameter("@estatus", SqlDbType.VarChar);
                SqlParameter Direccion = new SqlParameter("@fkdireccion", SqlDbType.Int);
                SqlParameter idnuevo = new SqlParameter("@return", SqlDbType.Int);
                idnuevo.Direction = ParameterDirection.Output;

                if (cn != null)
                {
                    comando.Connection = cn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "insertaPersona";

                    Nom.Value = TBNombre1.Text;
                    AP.Value = TBApaterno.Text;
                    AM.Value = TBAmaterno.Text;
                    CURP.Value = TBCurp.Text;
                    RFC.Value = TBRFC.Text;
                    Nacimiento.Value = FechaNac;
                    Sexo.Value = DDLSexo.SelectedValue;
                    EstadoCivil.Value = DDLEstadoCivil.SelectedValue;
                    Estatus.Value = "Candidato";
                    Direccion.Value = System.Data.SqlTypes.SqlString.Null;
                    idnuevo.Value = 0;

                    comando.Parameters.Add(Nom);
                    comando.Parameters.Add(AP);
                    comando.Parameters.Add(AM);
                    comando.Parameters.Add(CURP);
                    comando.Parameters.Add(RFC);
                    comando.Parameters.Add(Nacimiento);
                    comando.Parameters.Add(Sexo);
                    comando.Parameters.Add(EstadoCivil);
                    comando.Parameters.Add(Estatus);
                    comando.Parameters.Add(Direccion);
                    comando.Parameters.Add(idnuevo);

                    try
                    {
                        comando.ExecuteNonQuery();
                        IDPersona = (int)idnuevo.Value;
                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(this, "A͟l͝gún̛ ̧c̕am͏p̛o dej̕aste e͏n ̨bla͡ņco ҉o̵ ҉al̛g̶o͘ ͏pu͢d̴o ̴ha͟be̢r ͏sa̧l̸i̶do ́m͟a̶l,͟ ̡pru̡e͠ba ̷o̧t͢ra v̨e͝z̶.̢ \n ̷S̢i͜ e̷l pr̸oble̛ma p͟e̢rsi͞st͝e,̵ ́péga̛l͢e͡ ͢a͠l̀ ͡C̕PU.̨ ̀Eso͜ ͢si͡empr͞e fu̵n̕c̷i͏o͜na! ;)");
                        MessageBox.Show(this, "Error: " + w.Message);
                    }

                    MessageBox.Show(this, men);

                    cn.Close();

                }
                #endregion

                #region IngresarCandidato
                SqlConnection cn2 = S.Conect(ref men);

                SqlCommand comando2 = new SqlCommand();
                SqlParameter Nacionalidad = new SqlParameter("@Nacionalidad", SqlDbType.VarChar);
                SqlParameter Correo = new SqlParameter("@E_Mail", SqlDbType.VarChar);
                SqlParameter Seguro = new SqlParameter("@No_IMSS", SqlDbType.VarChar);
                SqlParameter Telefono1 = new SqlParameter("@Telefono1", SqlDbType.VarChar);
                SqlParameter Telefono2 = new SqlParameter("@Telefono2", SqlDbType.VarChar);
                SqlParameter Persona = new SqlParameter("@id_Persona", SqlDbType.Int);
                SqlParameter idnuevo2 = new SqlParameter("@IDNuevo", SqlDbType.Int);
                idnuevo2.Direction = ParameterDirection.Output;

                if (cn2 != null && IDPersona != 0)
                {
                    comando2.Connection = cn2;
                    comando2.CommandType = CommandType.StoredProcedure;
                    comando2.CommandText = "IngresarCandidato";

                    Nacionalidad.Value = TBNacio.Text;
                    Correo.Value = TBEmail.Text;
                    Seguro.Value = TBIMSS.Text;
                    Telefono1.Value = TBTel1.Text;
                    Telefono2.Value = TBTel2.Text;
                    Persona.Value = IDPersona;
                    idnuevo2.Value = 0;

                    comando2.Parameters.Add(Nacionalidad);
                    comando2.Parameters.Add(Correo);
                    comando2.Parameters.Add(Seguro);
                    comando2.Parameters.Add(Telefono1);
                    comando2.Parameters.Add(Telefono2);
                    comando2.Parameters.Add(Persona);
                    comando2.Parameters.Add(idnuevo2);


                    try
                    {
                        comando2.ExecuteNonQuery();
                        IDCandidato = (int)idnuevo2.Value;
                    }
                    catch (Exception w)
                    {
                        MessageBox.Show(this, "A͟l͝gún̛ ̧c̕am͏p̛o dej̕aste e͏n ̨bla͡ņco ҉o̵ ҉al̛g̶o͘ ͏pu͢d̴o ̴ha͟be̢r ͏sa̧l̸i̶do ́m͟a̶l,͟ ̡pru̡e͠ba ̷o̧t͢ra v̨e͝z̶.̢ \n ̷S̢i͜ e̷l pr̸oble̛ma p͟e̢rsi͞st͝e,̵ ́péga̛l͢e͡ ͢a͠l̀ ͡C̕PU.̨ ̀Eso͜ ͢si͡empr͞e fu̵n̕c̷i͏o͜na! ;)");
                        MessageBox.Show(this, "Error: " + w.Message);
                    }

                    MessageBox.Show(this, men);

                    cn.Close();

                }

                #endregion
                Response.Redirect("/RH2/Capsule152/Direccion.aspx?IDCandidato=" + IDCandidato + "&IDPersona=" + IDPersona);
            }
        }
    }
}