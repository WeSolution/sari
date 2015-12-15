using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARI.MVC
{
    public class Persona
    {
        public int id { get;set; }
        public String Nombre { set; get; }
        public String ApPaterno { set; get; }
        public String ApMaterno { set; get; }
        public String Curp { set; get; }
        public String RFC { set; get; }
        public DateTime FechaNac { set; get; }
        public String Sexo { set; get; }
        public String EstCivil { set; get; }
        public string estatus { get; set; }
        public int idDir { set; get; }
        public Persona(String n, String aP, String aM, String c, String r, DateTime fn, String s, String ec,string es, int dir=-1,int idPer=-1)
        {
            Nombre = n;
            ApPaterno = aP;
            ApMaterno = aM;
            Curp = c;
            RFC = r;
            FechaNac = fn;
            Sexo = s;
            EstCivil = ec;
            idDir = dir;
            id = idPer;
            estatus = es;
        }
    }
}