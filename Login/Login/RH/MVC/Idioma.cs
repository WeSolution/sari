using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARI.MVC
{
    public class Idioma
    {
        public int id { get; set; }
        public String Nombre { set; get; }
        public String Nivel { set; get; }
        public String Descripcion { set; get; }
        public int idEmp { set; get; }

        public Idioma(String nom, String niv, String d, int emp=-1, int idIdm = -1)
        {
            Nombre = nom;
            Nivel = niv;
            Descripcion = d;
            idEmp = emp;
            id = idIdm;
        }
    }
}