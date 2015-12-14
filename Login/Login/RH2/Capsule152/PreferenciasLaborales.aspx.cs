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
    public partial class PreferenciasLaborales : System.Web.UI.Page
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
        }

        protected void BNSig_Pag_Click(object sender, EventArgs e)
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            AgregarLaWea();
            Response.Redirect("/RH2/Capsule152/Mas_Info.aspx?IDCandidato=" + IDCandidato);
        }

        protected void RadioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonNo.Checked)
            {
                LabelHow.Visible = false;
                TBArea.Visible = false;
            }
        }

        protected void RadioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonYes.Checked)
            {
                LabelHow.Visible = true;
                TBArea.Visible = true;
            }
        }
        private void AgregarLaWea()
        {
            int IDCandidato = Convert.ToInt32(Request.QueryString["IDCandidato"]);
            SqlConnection cn = S.Conect(ref men);

            SqlCommand comando = new SqlCommand();
            SqlParameter Turno = new SqlParameter("@Turno", SqlDbType.VarChar);
            SqlParameter Area = new SqlParameter("@Area", SqlDbType.VarChar);
            SqlParameter Puesto = new SqlParameter("@Puesto", SqlDbType.VarChar);
            SqlParameter Sueldo = new SqlParameter("@Sueldo", SqlDbType.Money);
            SqlParameter Objetivo = new SqlParameter("@Objetivo", SqlDbType.VarChar);
            SqlParameter How = new SqlParameter("@How", SqlDbType.VarChar);
            SqlParameter Candidato = new SqlParameter("@IDCandidato", SqlDbType.Int);

            if (cn != null)
            {
                comando.Connection = cn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarMoreInfo";

                Turno.Value = TBTurno.Text;
                Area.Value = TBArea.Text;
                Puesto.Value = TBPuesto.Text;
                Sueldo.Value = TBSueldo.Text;
                Objetivo.Value = TBObjet.Text;
                if (RadioButtonNo.Checked)
                {
                    How.Value = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    How.Value = TBHow.Text;
                }
                Candidato.Value = IDCandidato;

                comando.Parameters.Add(Turno);
                comando.Parameters.Add(Area);
                comando.Parameters.Add(Puesto);
                comando.Parameters.Add(Sueldo);
                comando.Parameters.Add(Objetivo);
                comando.Parameters.Add(How);
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
        }
    }
}