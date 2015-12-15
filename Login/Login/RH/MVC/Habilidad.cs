using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARI.MVC
{
    public class Habilidad
    {
        public int id { get; set; }
        public String Tipo { set; get; }
        public String Descripcion { set; get; }
        public int idEmp { set; get; }

        public Habilidad(String t, String d, int emp=-1, int idHab = -1)
        {
            Tipo = t;
            Descripcion = d;
            idEmp = emp;
            id = idHab;
        }
    }
}