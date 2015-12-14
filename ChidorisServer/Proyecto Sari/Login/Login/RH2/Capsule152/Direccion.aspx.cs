using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Recursos_Humanos.Capsule152
{
    public partial class Direccion : System.Web.UI.Page
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

            DDLPais.Items.Clear();
            DDLPais.Items.Add("México");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            int IDPersona = Convert.ToInt32(Request.QueryString["IDPersona"]);
            int IDDireccion = 0;
            if (TBCalle.Text == "" || TBNoInt.Text == "" || TBColonia.Text == "" ||
                TBCP.Text == "" || TBCiudad.Text == "" || DDLPais.SelectedIndex == -1)
            {
                String Mensaje = "Algún campo (Excepto el numero exterior) dejaste en blanco.";
                MessageBox.Show(this, Mensaje);
            }
            else
            {
                if (VerificarNumero(TBNoInt.Text) || VerificarNumero(TBNoExt.Text) || VerificarNumero(TBCP.Text))
                {
                    SqlConnection cn = S.Conect(ref men);

                    SqlCommand comando = new SqlCommand();
                    SqlParameter Calle = new SqlParameter("@calle", SqlDbType.VarChar);
                    SqlParameter Num_Int = new SqlParameter("@numerointerior", SqlDbType.Int);
                    SqlParameter Num_Ext = new SqlParameter("@numeroexterior", SqlDbType.Int);
                    SqlParameter Colonia = new SqlParameter("@colonia", SqlDbType.VarChar);
                    SqlParameter CP = new SqlParameter("@codigopostal", SqlDbType.Int);
                    SqlParameter Ciudad = new SqlParameter("@estado", SqlDbType.VarChar);
                    SqlParameter Pais = new SqlParameter("@pais", SqlDbType.VarChar);
                    SqlParameter idnuevo = new SqlParameter("@return", SqlDbType.Int);
                    idnuevo.Direction = ParameterDirection.Output;

                    if (cn != null)
                    {
                        comando.Connection = cn;
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "insertarDireccion";

                        Calle.Value = TBCalle.Text;
                        Num_Int.Value = TBNoInt.Text;
                        Num_Ext.Value = TBNoExt.Text;
                        Colonia.Value = TBColonia.Text;
                        CP.Value = TBCP.Text;
                        Ciudad.Value = TBCiudad.Text;
                        Pais.Value = DDLPais.SelectedValue;
                        idnuevo.Value = 0;

                        comando.Parameters.Add(Calle);
                        comando.Parameters.Add(Num_Int);
                        comando.Parameters.Add(Num_Ext);
                        comando.Parameters.Add(Colonia);
                        comando.Parameters.Add(CP);
                        comando.Parameters.Add(Ciudad);
                        comando.Parameters.Add(Pais);
                        comando.Parameters.Add(idnuevo);

                        try
                        {
                            comando.ExecuteNonQuery();
                            IDDireccion = (int)idnuevo.Value;
                            String sentencia = "UPDATE Persona SET Persona.fkdireccion = " + IDDireccion 
                                + " WHERE idpersona = " + IDPersona + ";";
                        }
                        catch (Exception w)
                        {
                            MessageBox.Show(this, "A͟l͝gún̛ ̧c̕am͏p̛o dej̕aste e͏n ̨bla͡ņco ҉o̵ ҉al̛g̶o͘ ͏pu͢d̴o ̴ha͟be̢r ͏sa̧l̸i̶do ́m͟a̶l,͟ ̡pru̡e͠ba ̷o̧t͢ra v̨e͝z̶.̢ \n ̷S̢i͜ e̷l pr̸oble̛ma p͟e̢rsi͞st͝e,̵ ́péga̛l͢e͡ ͢a͠l̀ ͡C̕PU.̨ ̀Eso͜ ͢si͡empr͞e fu̵n̕c̷i͏o͜na! ;)");
                            MessageBox.Show(this, "Error: " + w.Message);
                        }

                        MessageBox.Show(this, men);

                        cn.Close();

                    }
                    Response.Redirect("/RH2/Capsule152/HistoriaLaboral.aspx?IDCandidato=" + IDCandidato);
                }
                else
                {
                    String Mensaje2 = "Los Campos de Numero Interior, Numero Exterior y Código Postal solo pueden tener numeros... LOL!";
                    MessageBox.Show(this, Mensaje2);
                }

            }
        }
        public bool VerificarNumero(String f)
        {
            bool OkSsuka = true;

            char[] b = new char[f.Length];
            b = f.ToCharArray();

            foreach (char c in b)
            {
                if (!Char.IsNumber(c))
                {
                    OkSsuka = false;
                }
            }

            return OkSsuka;
        }
    }
}