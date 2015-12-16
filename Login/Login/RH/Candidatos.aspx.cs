using SARI.MVC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login.RH
{
    public partial class Candidatos : System.Web.UI.Page
    {
        private Modelo m = new Modelo();
        public Label resp;
        public ArrayList telefono = new ArrayList();
        public Persona per = null; Direccion dir = null; 
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Session["sdireccion"] = dir; Session["spersona"] = per; Session["stelefono"] = telefono;
                    m.loadCandidatos(cbCandidatos);
                }
            }
            catch (Exception x) { }
        }
        protected void cbCandidatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbCandidatos.SelectedIndex)
            {
                case 0:
                    cbEstatus.SelectedIndex = 0;
                    cbEstatus.Enabled = false;
                    txtArea.Enabled = txtPuesto.Enabled = btnGuardar.Enabled = false;
                    clearPersona();
                    break;
                default:
                    cbEstatus.Enabled = true;
                    Perfil();
                    break;
            }
        }
        public void clearPersona() { txtCurl.Text = txtRFC.Text = txtNombre.Text = txtApaterno.Text = txtAmaterno.Text = txtFnac.Text = txtEstadoCivil.Text = txtArea.Text = txtPuesto.Text = txtPais.Text = txtestado.Text = txtcp.Text = txtColonia.Text = txtcalle.Text = txtnexterior.Text = txtninterior.Text = ""; rbSexo.Items[0].Selected = true; Session.Clear(); }
        private void loadPersona()
        {
            per = (Persona)Session["spersona"];
            dir = (Direccion)Session["sdireccion"];
            txtNombre.Text = per.Nombre; txtApaterno.Text = per.ApPaterno; txtAmaterno.Text = per.ApMaterno; txtCurl.Text = per.Curp; txtRFC.Text = per.RFC; txtFnac.Text = per.FechaNac.ToShortDateString(); loadSexo(per.Sexo); txtEstadoCivil.Text = per.EstCivil;
            txtcalle.Text = dir.calle; txtnexterior.Text = dir.nexterior.ToString(); txtninterior.Text = dir.ninterior; txtColonia.Text = dir.colonia; txtcp.Text = dir.cp.ToString(); txtestado.Text = dir.estado; txtPais.Text = dir.pais;
        }
        private void loadSexo(string s)
        {
            if (s == "Hombre")
                rbSexo.Items[0].Selected = !(rbSexo.Items[1].Selected = false);
            else
                rbSexo.Items[1].Selected = !(rbSexo.Items[0].Selected = false);
        }
        public void Perfil()
        {
            Persona p = null;
            try
            {
                p = m.BuscarCandidato(cbCandidatos.SelectedItem.ToString());
            }
            catch (Exception x) { p = null; }
            if (p != null)
            {
                Session.Remove("spersona"); Session["spersona"] = p;
                Direccion d = m.BuscarDireccion(p.idDir); Session.Remove("sdireccion"); Session["sdireccion"] = d;
                //Empleado em = m.BuscarEmpleado(p.id); Session.Remove("sempleado"); Session["sempleado"] = em;
                telefono = m.telCandidatos(p.id); Session.Remove("stelefono"); Session["stelefono"] = telefono;
                loadPersona();
            }
            else
            {
                //v.Error("No se encontro el Registro!", System.Drawing.Color.Red); enableButtonsEdit(enableButtonSearch(true));

            }
        }

        protected void cbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstatus.SelectedIndex == 1)
            {
                txtArea.Enabled = true;
                txtPuesto.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                txtArea.Enabled = false;
                txtPuesto.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                per = (Persona)Session["spersona"];
                m.AlmacenaTelefonos(m.telCandidatos(per.id),m.AlmacenaEmpleado(new Empleado(txtPuesto.Text, txtArea.Text, "~/RH/images/perfil.png", per.id)));
                m.changeStatus(cbEstatus.SelectedItem.Text, per.id);
                cbEstatus.SelectedIndex = 0;
                cbEstatus.Enabled = false;
                txtArea.Enabled = txtPuesto.Enabled = btnGuardar.Enabled = false;
                clearPersona(); m.loadCandidatos(cbCandidatos); lblerror.ForeColor = System.Drawing.Color.Green;
                lblerror.Text = "Operacion correcta!";

            }
            catch (Exception x) { lblerror.ForeColor = System.Drawing.Color.Red; lblerror.Text = x.Message; }
        }
       
    }
}