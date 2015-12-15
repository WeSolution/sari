using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARI.MVC
{
    public class VistaInserta
    {
        private SARI.WebForm1 insertar;
        public VistaInserta(SARI.WebForm1 p) 
        {
            insertar = p;
        }

        public void Inserta( int x)
        {
            
        }
        public void Error( string x,System.Drawing.Color c)
        {
            insertar.resp.ForeColor = c;
            insertar.resp.Text = "Mensaje de SARI: " + x;
        }
        public void mostrarTelefonos()
        {
            insertar.formcbtelefono.Items.Clear();
            insertar.formcbtelefono.Items.Add("Nuevo");
            for (int i = 0; i < insertar.telefono.Count; i++)
                insertar.formcbtelefono.Items.Add(((Telefono)(insertar.telefono[i])).TipoTel + " " + ((Telefono)(insertar.telefono[i])).NumeroTel);
        }
        public void mostrarJornada()
        {
            insertar.formcbjornada.Items.Clear();
            insertar.formcbjornada.Items.Add("Nuevo");
            for (int i = 0; i < insertar.jornada.Count; i++)
                insertar.formcbjornada.Items.Add(((Jornada)(insertar.jornada[i])).tipo + " Dias x semana" + ((Jornada)(insertar.jornada[i])).DiasSemana);
        }
        public void mostrarIdiomas()
        {
            insertar.formcbidioma.Items.Clear();
            insertar.formcbidioma.Items.Add("Nuevo");
            for (int i = 0; i < insertar.idioma.Count; i++)
                insertar.formcbidioma.Items.Add(((Idioma)(insertar.idioma[i])).Nombre + " " + ((Idioma)(insertar.idioma[i])).Nivel);
        }
        public void mostrarHabilidades()
        {
            insertar.formcbhabilidad.Items.Clear();
            insertar.formcbhabilidad.Items.Add("Nuevo");
            for (int i = 0; i < insertar.habilidad.Count; i++)
                insertar.formcbhabilidad.Items.Add(((Habilidad)(insertar.habilidad[i])).Tipo);
        }
        public void mostrarAcademica()
        {
            insertar.formcbacademico.Items.Clear();
            insertar.formcbacademico.Items.Add("Nuevo");
            for (int i = 0; i < insertar.academico.Count; i++)
                insertar.formcbacademico.Items.Add(((Academico)(insertar.academico[i])).Titulo_Obt + " " + ((Academico)(insertar.academico[i])).Institucion);
        }
    }
    public class VistaBuscar
    {
        private SARI.WebForm2 Buscar;
        public VistaBuscar(SARI.WebForm2 p)
        {
            Buscar = p;
        }

        public void Inserta(int x)
        {

        }
        public void Error(string x, System.Drawing.Color c)
        {
            Buscar.resp.ForeColor = c;
            Buscar.resp.Text = "Mensaje de SARI: " + x;
        }
        public void mostrarTelefonos()
        {
            Buscar.formcbtelefono.Items.Clear();
            Buscar.formcbtelefono.Items.Add("Nuevo");
            for (int i = 0; i < Buscar.telefono.Count; i++)
                Buscar.formcbtelefono.Items.Add(((Telefono)(Buscar.telefono[i])).TipoTel + " " + ((Telefono)(Buscar.telefono[i])).NumeroTel);
        }
        public void mostrarJornada()
        {
            Buscar.formcbjornada.Items.Clear();
            Buscar.formcbjornada.Items.Add("Nuevo");
            for (int i = 0; i < Buscar.jornada.Count; i++)
                Buscar.formcbjornada.Items.Add(((Jornada)(Buscar.jornada[i])).tipo + " Dias x semana" + ((Jornada)(Buscar.jornada[i])).DiasSemana);
        }
        public void mostrarIdiomas()
        {
            Buscar.formcbidioma.Items.Clear();
            Buscar.formcbidioma.Items.Add("Nuevo");
            for (int i = 0; i < Buscar.idioma.Count; i++)
                Buscar.formcbidioma.Items.Add(((Idioma)(Buscar.idioma[i])).Nombre + " " + ((Idioma)(Buscar.idioma[i])).Nivel);
        }
        public void mostrarHabilidades()
        {
            Buscar.formcbhabilidad.Items.Clear();
            Buscar.formcbhabilidad.Items.Add("Nuevo");
            for (int i = 0; i < Buscar.habilidad.Count; i++)
                Buscar.formcbhabilidad.Items.Add(((Habilidad)(Buscar.habilidad[i])).Tipo);
        }
        public void mostrarAcademica()
        {
            Buscar.formcbacademico.Items.Clear();
            Buscar.formcbacademico.Items.Add("Nuevo");
            for (int i = 0; i < Buscar.academico.Count; i++)
                Buscar.formcbacademico.Items.Add(((Academico)(Buscar.academico[i])).Titulo_Obt + " " + ((Academico)(Buscar.academico[i])).Institucion);
        }


    }
}