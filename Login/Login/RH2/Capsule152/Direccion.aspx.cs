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
            if (TBCalle.Text == "" || TBNoInt.Text == "" || TBColonia.Text == "" ||
                TBCP.Text == "" || TBCiudad.Text == "" || TBProvin.Text == "" ||
                TBMuni.Text == "" || DDLPais.SelectedIndex == -1)
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
                    SqlParameter Calle = new SqlParameter("@Calle", SqlDbType.VarChar);
                    SqlParameter Num_Int = new SqlParameter("@Num_Int", SqlDbType.Int);
                    SqlParameter Num_Ext = new SqlParameter("@Num_Ext", SqlDbType.Int);
                    SqlParameter Colonia = new SqlParameter("@Colonia", SqlDbType.VarChar);
                    SqlParameter CP = new SqlParameter("@CP", SqlDbType.Int);
                    SqlParameter Ciudad = new SqlParameter("@Ciudad", SqlDbType.VarChar);
                    SqlParameter Provincia = new SqlParameter("@Provincia", SqlDbType.VarChar);
                    SqlParameter Municipio = new SqlParameter("@Municipio", SqlDbType.VarChar);
                    SqlParameter Pais = new SqlParameter("@Pais", SqlDbType.VarChar);
                    SqlParameter Candidato = new SqlParameter("@IDCandidato", SqlDbType.Int);

                    if (cn != null)
                    {
                        comando.Connection = cn;
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "InsertarDireccion";

                        Calle.Value = TBCalle.Text;
                        Num_Int.Value = TBNoInt.Text;
                        Num_Ext.Value = TBNoExt.Text;
                        Colonia.Value = TBColonia.Text;
                        CP.Value = TBCP.Text;
                        Ciudad.Value = TBCiudad.Text;
                        Provincia.Value = TBProvin.Text;
                        Municipio.Value = TBMuni.Text;
                        Pais.Value = DDLPais.SelectedValue;
                        Candidato.Value = IDCandidato;

                        comando.Parameters.Add(Calle);
                        comando.Parameters.Add(Num_Int);
                        comando.Parameters.Add(Num_Ext);
                        comando.Parameters.Add(Colonia);
                        comando.Parameters.Add(CP);
                        comando.Parameters.Add(Ciudad);
                        comando.Parameters.Add(Provincia);
                        comando.Parameters.Add(Municipio);
                        comando.Parameters.Add(Pais);
                        comando.Parameters.Add(Candidato);

                        try
                        {
                            comando.ExecuteNonQuery();
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