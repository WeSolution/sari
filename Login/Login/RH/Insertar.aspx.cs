using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SARI.MVC;
using System.Collections;


namespace SARI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        private Modelo m = new Modelo();
        private VistaInserta v;
        public Label resp;
        public ArrayList telefono = new ArrayList();
        public ArrayList idioma = new ArrayList();
        public ArrayList habilidad = new ArrayList();
        public ArrayList academico = new ArrayList();
        public ArrayList jornada = new ArrayList();
        public DropDownList formcbtelefono, formcbidioma,formcbhabilidad,formcbacademico,formcbjornada;
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
            file.Attributes.Add("onChange", "document.getElementById('" + btnsavefoto.ClientID + "').click();"); resp = lblerror;
            btnExaminar.Attributes.Add("onclick", "document.getElementById('" + file.ClientID + "').click();");
            formcbtelefono = cbTelefono; formcbidioma = cbIdioma; formcbhabilidad = cbHabilidad; formcbacademico = cbAcademica; formcbjornada = cbJornada;
            v = new VistaInserta(this);
            if (!IsPostBack)
            {
                Session["stelefono"] = telefono; Session["sidioma"] = idioma; Session["shabilidad"] = habilidad; Session["sacademico"] = academico; Session["sjornada"] = jornada;
            }
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try{
                idioma = (ArrayList)Session["sidioma"]; telefono = (ArrayList)Session["stelefono"]; habilidad = (ArrayList)Session["shabilidad"]; academico = (ArrayList)Session["sacademico"]; jornada = (ArrayList)Session["sjornada"];
                m.AlmacenaIdiomas(idioma, m.AlmacenaHabilidades(habilidad, m.AlmacenaJornadas(jornada, m.AlmacenaGradosAcademicos(academico, m.AlmacenaEmpleado(new Empleado(txtPuesto.Text, txtArea.Text, foto.ImageUrl, m.AlmacenaTelefonos(telefono, m.AlmacenaPersona(new Persona(txtNombre.Text, txtApaterno.Text, txtAmaterno.Text, txtCurl.Text, txtRFC.Text, Convert.ToDateTime(txtFnac.Text), obtSexo(), txtEstadoCivil.Text,"Empleado", m.AlmacenaDireccion(new Direccion(txtcalle.Text, txtninterior.Text, Convert.ToInt32(txtnexterior.Text), txtColonia.Text, Convert.ToInt32(txtcp.Text), txtestado.Text, txtPais.Text)))))))))));
                v.Error("Insercion Correcta... " + DateTime.Now.ToLongTimeString(), System.Drawing.Color.Green); academico = new ArrayList(); jornada = new ArrayList(); habilidad = new ArrayList(); telefono = new ArrayList(); idioma = new ArrayList(); Session.Clear();
                Session["stelefono"] = telefono; Session["sidioma"] = idioma; Session["shabilidad"] = habilidad; Session["sacademico"] = academico; Session["sjornada"] = jornada;

            clearPersona();}catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red);}
        }
        private string obtSexo()
        {
            string r="";
            if (rbSexo.Items[0].Selected)
                r = "Hombre";
            else
                r = "Mujer";
            return r;
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            try{foto.ImageUrl = "~/RH/images/perfil.png";}catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red);}
            
        }

        protected void btnsavefoto_Click(object sender, EventArgs e)
        {
            try { if (file.HasFile) 
            {
                string urlfoto = "~/RH/Foto/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + file.FileName;
                file.SaveAs(Server.MapPath(urlfoto));
                foto.ImageUrl = @urlfoto;
            }}catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red);}

        }

        protected void btnAddTelefono_Click(object sender, ImageClickEventArgs e)
        {
            try{
            telefono = (ArrayList)Session["stelefono"];
            if (cbTelefono.SelectedIndex < 1)
                telefono.Add(new Telefono(txtTelNumero.Text, txtTelTipo.Text));
            else
            {
                Telefono t = (Telefono)telefono[cbTelefono.SelectedIndex-1];
                t.TipoTel = txtTelTipo.Text;
                t.NumeroTel = txtTelNumero.Text;
            }
            v.mostrarTelefonos();
            Session.Remove("stelefono");Session["stelefono"] = telefono;
            clearTelefonos();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnDelTelefono_Click(object sender, ImageClickEventArgs e)
        {
            try {
                if (cbTelefono.SelectedIndex > 0)
                {
                    telefono = (ArrayList)Session["stelefono"];
                    telefono.RemoveAt(cbTelefono.SelectedIndex - 1);
                    v.mostrarTelefonos();
                    Session.Remove("stelefono"); Session["stelefono"] = telefono;
                }
            clearTelefonos();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnaddIdioma_Click(object sender, ImageClickEventArgs e)
        {
            try{
                idioma = (ArrayList)Session["sidioma"];
                if (cbIdioma.SelectedIndex < 1)
                    idioma.Add(new Idioma(txtIdiomaNombre.Text, txtIdiomaNivel.Text, txtIdiomaDes.Text));
                else
                {
                    Idioma i = (Idioma)idioma[cbIdioma.SelectedIndex - 1];
                    i.Descripcion = txtIdiomaDes.Text;
                    i.Nivel = txtIdiomaNivel.Text;
                    i.Nombre = txtIdiomaNombre.Text;
                }
                v.mostrarIdiomas();
                Session.Remove("sidoma"); Session["sidioma"] = idioma;
                clearIdiomas();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btndelidioma_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (cbIdioma.SelectedIndex > 0)
                {
                    idioma = (ArrayList)Session["sidioma"];
                    idioma.RemoveAt(cbIdioma.SelectedIndex - 1);
                    v.mostrarIdiomas();
                    Session.Remove("sidoma"); Session["sidioma"] = idioma;
                }
                clearIdiomas();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnAddHabilidad_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            habilidad = (ArrayList)Session["shabilidad"];
            if (cbHabilidad.SelectedIndex < 1)
                habilidad.Add(new Habilidad(txthabilidadTipo.Text, txtHabilidadDesc.Text));
            else
            {
                Habilidad h = (Habilidad)habilidad[cbHabilidad.SelectedIndex - 1];
                h.Descripcion = txtHabilidadDesc.Text;
                h.Tipo = txthabilidadTipo.Text;
            }
                v.mostrarHabilidades();
            Session.Remove("shabilidad");Session["shabilidad"] = habilidad;
            clearHabilidades();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnDelHabilidad_Click(object sender, ImageClickEventArgs e)
        {
            try {
                if (cbHabilidad.SelectedIndex > 0)
                {
                    habilidad = (ArrayList)Session["shabilidad"];
                    habilidad.RemoveAt(cbHabilidad.SelectedIndex - 1);
                    v.mostrarHabilidades();
                    Session.Remove("shabilidad"); Session["shabilidad"] = habilidad;
                }
            clearHabilidades();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnAddAcademica_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            academico = (ArrayList)Session["sacademico"];
            if (cbAcademica.SelectedIndex < 1)
                academico.Add(new Academico(Convert.ToDateTime(txtAcaInicio.Text), Convert.ToDateTime(txtAcaFin.Text), txtAcaTitulo.Text, txtAcaInstitucion.Text));
            else 
            {
                Academico a = (Academico)academico[cbAcademica.SelectedIndex - 1];
                a.Institucion = txtAcaInstitucion.Text;
                a.Titulo_Obt = txtAcaTitulo.Text;
                a.Fecha_Ini = Convert.ToDateTime(txtAcaInicio.Text);
                a.Fecha_Ter = Convert.ToDateTime(txtAcaFin.Text);
            }
            v.mostrarAcademica();
            Session.Remove("sacademico");Session["sacademico"] = academico;
            clearAcademico();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }
        protected void btnDelAcademica_Click(object sender, ImageClickEventArgs e)
        {
            try {
                if (cbAcademica.SelectedIndex > 0)
                {
                    academico = (ArrayList)Session["sacademico"];
                    academico.RemoveAt(cbAcademica.SelectedIndex - 1);
                    v.mostrarAcademica();
                    Session.Remove("sacademico"); Session["sacademico"] = academico;
                }
            clearAcademico();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnaddJornada_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            jornada = (ArrayList)Session["sjornada"];
            if (cbJornada.SelectedIndex < 1)
                jornada.Add(new Jornada(txtJornadaTipo.Text, Convert.ToInt32(txtJornadaDias.Text), cbJornadaTurno.SelectedValue, txtJornadaHrEntrada.Text, txtJornadaHrSAlida.Text));
            else {
                Jornada j = (Jornada)jornada[cbJornada.SelectedIndex - 1];
                j.tipo = txtJornadaTipo.Text;
                j.turno = cbJornada.Text;
                j.hrEntrada = txtJornadaHrEntrada.Text;
                j.hrSalida = txtJornadaHrSAlida.Text;
            }
            v.mostrarJornada();
            Session.Remove("sjornada");Session["sjornada"] = jornada;
            clearJornada();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }
        protected void btnCancelJornada_Click(object sender, ImageClickEventArgs e)
        {
            try{
                if (cbJornada.SelectedIndex > 0)
                {
                    jornada = (ArrayList)Session["sjornada"];
                    jornada.RemoveAt(cbAcademica.SelectedIndex - 1);
                    v.mostrarJornada();
                    Session.Remove("sjornada"); Session["sjornada"] = jornada;
                }
            clearJornada();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }
        public void clearPersona() { txtCurl.Text = txtRFC.Text = txtNombre.Text = txtApaterno.Text = txtAmaterno.Text = txtFnac.Text = txtEstadoCivil.Text = txtArea.Text = txtPuesto.Text = txtPais.Text = txtestado.Text = txtcp.Text = txtColonia.Text = txtcalle.Text = txtnexterior.Text = txtninterior.Text = ""; rbSexo.Items[0].Selected = true; foto.ImageUrl = "~/RH/images/perfil.png"; clearAcademico(); clearHabilidades(); clearIdiomas(); clearJornada(); clearTelefonos(); v.mostrarAcademica(); v.mostrarHabilidades(); v.mostrarIdiomas(); v.mostrarJornada(); v.mostrarTelefonos(); }
        public void clearTelefonos(){txtTelTipo.Text = txtTelNumero.Text = "";}
        public void clearIdiomas() {txtIdiomaNombre.Text = txtIdiomaNivel.Text = txtIdiomaDes.Text = "";}
        public void clearHabilidades() { txthabilidadTipo.Text = txtHabilidadDesc.Text = ""; }
        public void clearAcademico() { txtAcaFin.Text = txtAcaInicio.Text = txtAcaInstitucion.Text = txtAcaTitulo.Text = ""; }
        public void clearJornada() { txtJornadaDias.Text = txtJornadaHrEntrada.Text = txtJornadaHrSAlida.Text = txtJornadaTipo.Text = ""; cbJornadaTurno.SelectedIndex = 0; }

        protected void cbTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTelefono.SelectedIndex < 1)
                clearTelefonos();
            else
            {
                telefono = (ArrayList)Session["stelefono"];
                loadTelefono(cbTelefono.SelectedIndex - 1);
            }
        }

        protected void cbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdioma.SelectedIndex < 1)
                clearIdiomas();
            else
            {
                idioma = (ArrayList)Session["sidioma"];
                loadIdioma(cbIdioma.SelectedIndex - 1);
            }
        }

        protected void cbHabilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHabilidad.SelectedIndex < 1)
                clearHabilidades();
            else
            {
                habilidad = (ArrayList)Session["shabilidad"];
                loadHabilidad(cbHabilidad.SelectedIndex - 1);
            }
        }

        protected void cbAcademica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAcademica.SelectedIndex < 1)
                clearAcademico();
            else
            {
                academico = (ArrayList)Session["sacademico"];
                loadAcademico(cbAcademica.SelectedIndex - 1);
            }
        }

        protected void cbJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJornada.SelectedIndex < 1)
                clearJornada();
            else
            {
                jornada = (ArrayList)Session["sjornada"];
                loadJornada(cbJornada.SelectedIndex - 1);
            }

        }
        private void loadTelefono(int x) 
        {
            txtTelTipo.Text = ((Telefono)telefono[x]).TipoTel;
            txtTelNumero.Text = ((Telefono)telefono[x]).NumeroTel;
        }
        private void loadIdioma(int x)
        {
            txtIdiomaNombre.Text = ((Idioma)idioma[x]).Nombre;
            txtIdiomaNivel.Text = ((Idioma)idioma[x]).Nivel;
            txtIdiomaDes.Text = ((Idioma)idioma[x]).Descripcion;
        }
        private void loadHabilidad(int x) 
        {
            txthabilidadTipo.Text = ((Habilidad)habilidad[x]).Tipo;
            txtHabilidadDesc.Text= ((Habilidad)habilidad[x]).Descripcion;
        }
        private void loadAcademico(int x)
        {
            txtAcaInicio.Text = ((Academico)academico[x]).Fecha_Ini.ToShortDateString();
            txtAcaFin.Text = ((Academico)academico[x]).Fecha_Ter.ToShortDateString();
            txtAcaInstitucion.Text = ((Academico)academico[x]).Institucion;
            txtAcaTitulo.Text = ((Academico)academico[x]).Titulo_Obt;
        }
        private void loadJornada(int x) 
        {
            txtJornadaDias.Text = ((Jornada)jornada[x]).DiasSemana.ToString();
            txtJornadaTipo.Text = ((Jornada)jornada[x]).tipo;
            txtJornadaHrEntrada.Text = ((Jornada)jornada[x]).hrEntrada;
            txtJornadaHrSAlida.Text = ((Jornada)jornada[x]).hrSalida;
            cbJornadaTurno.Text = ((Jornada)jornada[x]).turno;
        }

    }

}