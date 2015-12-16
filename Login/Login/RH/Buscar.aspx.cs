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
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        private Modelo m = new Modelo();
        private VistaBuscar v;
        public Label resp;
        public ArrayList telefono = new ArrayList();
        public ArrayList idioma = new ArrayList();
        public ArrayList habilidad = new ArrayList();
        public ArrayList academico = new ArrayList();
        public ArrayList jornada = new ArrayList();
        public ArrayList deltelefono = new ArrayList();
        public ArrayList delidioma = new ArrayList();
        public ArrayList delhabilidad = new ArrayList();
        public ArrayList delacademico = new ArrayList();
        public ArrayList deljornada = new ArrayList();
        public Persona per = null; Direccion dir = null; Empleado emple = null;
        public DropDownList formcbtelefono, formcbidioma,formcbhabilidad,formcbacademico,formcbjornada;
        protected void Page_Load(object sender, EventArgs e)
        {
          
            try { 
            file.Attributes.Add("onChange", "document.getElementById('" + btnsavefoto.ClientID + "').click();"); resp = lblerror;
            btnExaminar.Attributes.Add("onclick", "document.getElementById('" + file.ClientID + "').click();");

            formcbtelefono = cbTelefono; formcbidioma = cbIdioma; formcbhabilidad = cbHabilidad; formcbacademico = cbAcademica; formcbjornada = cbJornada;
            v = new VistaBuscar(this); ControlsEnable(false);
            if (!IsPostBack)
            {
                Session["deltelefono"] = deltelefono; Session["delidioma"] = delidioma; Session["delhabilidad"] = delhabilidad; Session["delacademico"] = delacademico; Session["deljornada"] = deljornada ; Session["sempleado"] = emple; Session["sdireccion"] = dir; Session["spersona"] = per; Session["stelefono"] = telefono; Session["sidioma"] = idioma; Session["shabilidad"] = habilidad; Session["sacademico"] = academico; Session["sjornada"] = jornada;
            }
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try{
            delidioma = (ArrayList)Session["delidioma"]; delhabilidad = (ArrayList)Session["delhabilidad"]; delacademico = (ArrayList)Session["delacademico"]; deljornada = (ArrayList)Session["deljornada"]; deltelefono = (ArrayList)Session["deltelefono"]; emple = (Empleado)Session["sempleado"]; dir = (Direccion)Session["sdireccion"]; per = (Persona)Session["spersona"]; idioma = (ArrayList)Session["sidioma"]; telefono = (ArrayList)Session["stelefono"]; habilidad = (ArrayList)Session["shabilidad"]; academico = (ArrayList)Session["sacademico"]; jornada = (ArrayList)Session["sjornada"];
                updateInfo(); m.EditaPersona(per); m.EditaEmpleado(emple); m.EditaDireccion(dir); m.eliminaTelefono(deltelefono); m.eliminaIdioma(delidioma); m.eliminaHabilidad(delhabilidad); m.eliminaAcademico(delacademico); m.eliminaJornada(deljornada);
                m.AlmacenaIdiomas(idioma, m.AlmacenaHabilidades(habilidad, m.AlmacenaJornadas(jornada, m.AlmacenaGradosAcademicos(academico, m.AlmacenaTelefonos(telefono, emple.id)))));
                v.Error("Edicion Correcta...", System.Drawing.Color.Green); Perfil(); btnCancel.Visible = btnGuardar.Visible = true; enableButtonsEdit(!enableButtonSearch(true));
                btnCancelEdit.Visible = btnEliminar.Visible = btnEditar.Visible = !(btnGuardar.Enabled = btnCancel.Visible = btnGuardar.Visible = false); ControlsEnable(false);
                }catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red);}
        }
        public void updateInfo() 
        {
            emple.puesto = txtPuesto.Text; emple.area = txtArea.Text; emple.foto = foto.ImageUrl;
            per.Nombre = txtNombre.Text; per.ApPaterno = txtApaterno.Text; per.ApMaterno = txtAmaterno.Text; per.Curp = txtCurl.Text; per.RFC = txtRFC.Text; per.FechaNac = Convert.ToDateTime(txtFnac.Text); per.Sexo = obtSexo(); per.EstCivil = txtEstadoCivil.Text;
            dir.calle = txtcalle.Text; dir.ninterior = txtninterior.Text; dir.nexterior = Convert.ToInt32(txtnexterior.Text); dir.colonia = txtColonia.Text; dir.cp = Convert.ToInt32(txtcp.Text); dir.estado = txtestado.Text; dir.pais = txtPais.Text;
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
            try { foto.ImageUrl = "~/RH/images/perfil.png"; ControlsEnable(true); }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnsavefoto_Click(object sender, EventArgs e)
        {
            ControlsEnable(true);
            try { if (file.HasFile) 
            {
                string urlfoto = "~/RH/Foto/" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + file.FileName;
                file.SaveAs(Server.MapPath(urlfoto));
                foto.ImageUrl = @urlfoto;
            }}catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red);}
        }

        protected void btnAddTelefono_Click(object sender, ImageClickEventArgs e)
        {
            ControlsEnable(btnGuardar.Visible);
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
            ControlsEnable(btnGuardar.Visible);
            try {
                if (cbTelefono.SelectedIndex > 0)
                {
                    telefono = (ArrayList)Session["stelefono"]; deltelefono = (ArrayList)Session["deltelefono"];
                    if (((Telefono)telefono[cbTelefono.SelectedIndex - 1]).ID != -1)
                        deltelefono.Add(((Telefono)telefono[cbTelefono.SelectedIndex - 1]).ID);
                    telefono.RemoveAt(cbTelefono.SelectedIndex - 1);
                    v.mostrarTelefonos();
                    Session.Remove("stelefono"); Session["stelefono"] = telefono;
                    Session.Remove("deltelefono"); Session["deltelefono"] = deltelefono;
                }
            clearTelefonos();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnaddIdioma_Click(object sender, ImageClickEventArgs e)
        {
            ControlsEnable(btnGuardar.Visible);
            try
            {
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
            ControlsEnable(btnGuardar.Visible);
            try
            {
                if (cbIdioma.SelectedIndex > 0)
                {
                    idioma = (ArrayList)Session["sidioma"]; delidioma = (ArrayList)Session["delidioma"];
                    if (((Idioma)idioma[cbIdioma.SelectedIndex - 1]).id != -1)
                        delidioma.Add(((Idioma)idioma[cbIdioma.SelectedIndex - 1]).id);
                    idioma.RemoveAt(cbIdioma.SelectedIndex - 1);
                    v.mostrarIdiomas();
                    Session.Remove("sidoma"); Session["sidioma"] = idioma;
                    Session.Remove("delidoma"); Session["delidioma"] = delidioma;
                }
                clearIdiomas();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnAddHabilidad_Click(object sender, ImageClickEventArgs e)
        {
            ControlsEnable(btnGuardar.Visible);
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
            ControlsEnable(btnGuardar.Visible);
            try {
                if (cbHabilidad.SelectedIndex > 0)
                {
                    habilidad = (ArrayList)Session["shabilidad"]; delhabilidad = (ArrayList)Session["delhabilidad"];
                    if (((Habilidad)habilidad[cbHabilidad.SelectedIndex - 1]).id != -1)
                        delhabilidad.Add(((Habilidad)habilidad[cbHabilidad.SelectedIndex - 1]).id);
                    habilidad.RemoveAt(cbHabilidad.SelectedIndex - 1);
                    v.mostrarHabilidades();
                    Session.Remove("shabilidad"); Session["shabilidad"] = habilidad;
                    Session.Remove("delhabilidad"); Session["delhabilidad"] = habilidad;
                }
            clearHabilidades();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnAddAcademica_Click(object sender, ImageClickEventArgs e)
        {
            ControlsEnable(btnGuardar.Visible);
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
            ControlsEnable(btnGuardar.Visible);
            try {
                if (cbAcademica.SelectedIndex > 0)
                {
                    academico = (ArrayList)Session["sacademico"]; delacademico = (ArrayList)Session["delacademico"];
                    if (((Academico)academico[cbAcademica.SelectedIndex - 1]).Id != -1)
                        delacademico.Add(((Academico)academico[cbAcademica.SelectedIndex - 1]).Id);
                    academico.RemoveAt(cbAcademica.SelectedIndex - 1);
                    v.mostrarAcademica();
                    Session.Remove("sacademico"); Session["sacademico"] = academico;
                    Session.Remove("delacademico"); Session["delacademico"] = delacademico;
                }
            clearAcademico();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }

        protected void btnaddJornada_Click(object sender, ImageClickEventArgs e)
        {
            ControlsEnable(btnGuardar.Visible);
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
            ControlsEnable(btnGuardar.Visible);
            try
            {
                if (cbJornada.SelectedIndex > 0)
                {
                    jornada = (ArrayList)Session["sjornada"]; deljornada = (ArrayList)Session["deljornada"];
                    if (((Jornada)jornada[cbAcademica.SelectedIndex - 1]).idJornada != -1)
                        delacademico.Add(((Jornada)jornada[cbAcademica.SelectedIndex - 1]).idJornada);
                    jornada.RemoveAt(cbAcademica.SelectedIndex - 1);
                    v.mostrarJornada();
                    Session.Remove("sjornada"); Session["sjornada"] = jornada;
                    Session.Remove("deljornada"); Session["deljornada"] = deljornada;
                }
            clearJornada();
            }
            catch (Exception x) { v.Error(x.Message, System.Drawing.Color.Red); }
        }
        public void clearPersona() { txtCurl.Text = txtRFC.Text = txtNombre.Text = txtApaterno.Text = txtAmaterno.Text = txtFnac.Text = txtEstadoCivil.Text = txtArea.Text = txtPuesto.Text = txtPais.Text = txtestado.Text = txtcp.Text = txtColonia.Text = txtcalle.Text = txtnexterior.Text = txtninterior.Text = ""; rbSexo.Items[0].Selected = true; foto.ImageUrl = "~/RH/images/perfil.png"; clearAcademico(); clearHabilidades(); clearIdiomas(); clearJornada(); clearTelefonos(); Session.Clear(); }
        public void clearTelefonos(){txtTelTipo.Text = txtTelNumero.Text = "";}
        public void clearIdiomas() {txtIdiomaNombre.Text = txtIdiomaNivel.Text = txtIdiomaDes.Text = "";}
        public void clearHabilidades() { txthabilidadTipo.Text = txtHabilidadDesc.Text = ""; }
        public void clearAcademico() { txtAcaFin.Text = txtAcaInicio.Text = txtAcaInstitucion.Text = txtAcaTitulo.Text = ""; }
        public void clearJornada() { txtJornadaDias.Text = txtJornadaHrEntrada.Text = txtJornadaHrSAlida.Text = txtJornadaTipo.Text = ""; cbJornadaTurno.SelectedIndex = 0; }

        protected void cbTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlsEnable(btnGuardar.Visible);
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
            ControlsEnable(btnGuardar.Visible);
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
            ControlsEnable(btnGuardar.Visible);
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
            ControlsEnable(btnGuardar.Visible);
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
            ControlsEnable(btnGuardar.Visible);
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
        private void loadPersona() 
        {
            per = (Persona)Session["spersona"];
            dir = (Direccion)Session["sdireccion"];
            emple = (Empleado)Session["sempleado"];
            txtNombre.Text = per.Nombre; txtApaterno.Text = per.ApPaterno; txtAmaterno.Text = per.ApMaterno; txtCurl.Text = per.Curp; txtRFC.Text = per.RFC; txtFnac.Text = per.FechaNac.ToShortDateString(); loadSexo(per.Sexo); txtEstadoCivil.Text = per.EstCivil;
            txtcalle.Text = dir.calle; txtnexterior.Text = dir.nexterior.ToString(); txtninterior.Text = dir.ninterior; txtColonia.Text = dir.colonia; txtcp.Text = dir.cp.ToString(); txtestado.Text = dir.estado; txtPais.Text = dir.pais;
            txtArea.Text = emple.area; txtPuesto.Text = emple.puesto; foto.ImageUrl = emple.foto;
        }
        private void loadSexo(string s)
        {
            if (s=="Hombre")
                rbSexo.Items[0].Selected = !(rbSexo.Items[1].Selected=false);
            else
                rbSexo.Items[1].Selected=!(rbSexo.Items[0].Selected =false);
        }
        public void ControlsEnable(bool x) 
        {
             btnExaminar.Disabled=!(btnaddJornada.Enabled=btnCancelJornada.Enabled= txtTelNumero.Enabled=txtTelTipo.Enabled=btnCancelar.Enabled=btnAddTelefono.Enabled=btnDelTelefono.Enabled= txtIdiomaDes.Enabled=txtIdiomaNivel.Enabled=txtIdiomaNombre.Enabled=btnaddIdioma.Enabled=btndelidioma.Enabled=txthabilidadTipo.Enabled=txtHabilidadDesc.Enabled=btnAddHabilidad.Enabled=btnDelHabilidad.Enabled=txtAcaFin.Enabled=txtAcaInicio.Enabled=txtAcaInstitucion.Enabled=txtAcaTitulo.Enabled=btnAddAcademica.Enabled=btnDelAcademica.Enabled=txtJornadaDias.Enabled=txtJornadaHrEntrada.Enabled=txtJornadaHrSAlida.Enabled=txtJornadaTipo.Enabled=cbJornadaTurno.Enabled= txtCurl.Enabled = txtRFC.Enabled = txtNombre.Enabled = txtApaterno.Enabled = txtAmaterno.Enabled = txtFnac.Enabled = txtEstadoCivil.Enabled = txtArea.Enabled = txtPuesto.Enabled = rbSexo.Enabled = txtPais.Enabled = txtestado.Enabled = txtcp.Enabled = txtColonia.Enabled = txtcalle.Enabled = txtnexterior.Enabled = txtninterior.Enabled=x);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
           btnCancelEdit.Visible= btnEliminar.Visible = btnEditar.Visible = !(btnGuardar.Enabled = btnCancel.Visible = btnGuardar.Visible = true); ControlsEnable(true);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = btnGuardar.Visible = !(btnCancelEdit.Visible = btnEliminar.Visible = btnEditar.Visible = true);
            Perfil(); 
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
             Perfil();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Perfil();
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Si")
            {
                clearPersona();
                if (m.EliminaenCascada(dir.id) > 0)
                    v.Error("Se elimino el Registro!", System.Drawing.Color.Green);
                else
                    v.Error("Se no se pudo eliminar el Registro!", System.Drawing.Color.Red);
                resetVars(); clearSearch();
                enableButtonsEdit(enableButtonSearch(true));
                cbAcademica.Items.Clear(); cbTelefono.Items.Clear(); cbHabilidad.Items.Clear(); cbJornada.Items.Clear(); cbIdioma.Items.Clear();
            }
        }
        public void Perfil() 
        {
            Persona p = null;
            resetVars();
            try
            {
                switch (cbBuscar.SelectedIndex)
                {
                    case 0:
                        p = m.BuscarPersona(Convert.ToInt32(txtParametro.Text));
                        break;
                    case 1:
                        p = m.BuscarPersonaCURP(txtParametro.Text);
                        break;
                    case 2:
                        p = m.BuscarPersonaRFC(txtParametro.Text);
                        break;
                }
            }
            catch (Exception x) { p = null; }
            if (p != null)
            {
                Session.Remove("spersona"); Session["spersona"] = p;
                Direccion d = m.BuscarDireccion(p.idDir); Session.Remove("sdireccion"); Session["sdireccion"] = d;
                Empleado em = m.BuscarEmpleado(p.id); Session.Remove("sempleado"); Session["sempleado"] = em;
                telefono = m.BuscarTelefono(p.id); Session.Remove("stelefono"); Session["stelefono"] = telefono;
                idioma = m.BuscarIdiomaID(em.id); Session.Remove("sidioma"); Session["sidioma"] = idioma;
                habilidad = m.BuscarHabilidadID(em.id); Session.Remove("shabilidad"); Session["shabilidad"] = habilidad;
                academico = m.BuscarGrado(em.id); Session.Remove("sacademico"); Session["sacademico"] = academico;
                jornada = m.BuscarJornada(em.id); Session.Remove("sjornada"); Session["sjornada"] = jornada;
                loadPersona(); v.mostrarAcademica(); v.mostrarHabilidades(); v.mostrarIdiomas(); v.mostrarJornada(); v.mostrarTelefonos();
                enableButtonsEdit(enableButtonSearch(false));
                if (telefono.Count > 0)
                { loadTelefono(0); cbTelefono.SelectedIndex = 1; }
                if (idioma.Count > 0)
                { loadIdioma(0); cbIdioma.SelectedIndex = 1; }
                if (habilidad.Count > 0)
                { loadHabilidad(0); cbHabilidad.SelectedIndex = 1; }
                if (academico.Count > 0)
                { loadAcademico(0); cbAcademica.SelectedIndex = 1; }
                if (jornada.Count > 0)
                { loadJornada(0); cbJornada.SelectedIndex = 1; } v.Error("Se encontro el Registro!", System.Drawing.Color.Green);
            }
            else
            {
                v.Error("No se encontro el Registro!", System.Drawing.Color.Red); enableButtonsEdit(enableButtonSearch(true));
               
            }
        }
        public void resetVars() 
        {
            delidioma = new ArrayList(); deljornada = new ArrayList(); deltelefono = new ArrayList(); delhabilidad = new ArrayList(); delacademico = new ArrayList();
            Session.Remove("deltelefono"); Session["deltelefono"] = deltelefono;
            Session.Remove("delidioma"); Session["delidioma"] = delidioma;
            Session.Remove("deljornada"); Session["deljornada"] = deljornada;
            Session.Remove("delhabilidad"); Session["delhabilidad"] = delhabilidad;
            Session.Remove("delacademico"); Session["delacademico"] = delacademico;
        }
        public bool enableButtonSearch(bool x) 
        {
            cbBuscar.Enabled = txtParametro.Enabled = btnBuscar.Enabled = x; return !x;
        }
        public void enableButtonsEdit(bool x) 
        {
           btnCancelEdit.Enabled=  btnEditar.Enabled = btnEliminar.Enabled = x;
        }
        public void clearSearch() 
        {
            cbBuscar.SelectedIndex = 0; txtParametro.Text = "";
        }

        protected void btnCancelEdit_Click(object sender, EventArgs e)
        {
            clearSearch(); enableButtonsEdit(enableButtonSearch(true)); clearPersona(); resetVars();
            cbAcademica.Items.Clear(); cbTelefono.Items.Clear(); cbHabilidad.Items.Clear(); cbJornada.Items.Clear(); cbIdioma.Items.Clear();
        }

        protected void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}