using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARI.MVC
{


    public class Direccion
    {
        public int id { get; set; }
        public string pais { get; set; }
        public string estado { get; set; }
        public int cp { get; set; }    
        public string colonia { get; set; }
        public string calle { get; set; }    
        public string ninterior { get; set; }
        public int nexterior { get; set; }
        public Direccion(string ca, string ni, int ne, string co,  int c, string e, string p, int idDir = -1) 
        {
            pais = p; estado = e; cp = c; colonia = co; calle = ca; ninterior = ni; nexterior = ne; id = idDir;
        }
    }
}