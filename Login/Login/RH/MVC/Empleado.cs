using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARI.MVC
{
    public class Empleado
    {
        public int id { get; set; }
        public string puesto { get; set; }
        public string area { get; set; }
        public string foto { get; set; }
        public int fkpersona { get; set; }
        public  Empleado(string p,string a,string f,int fk=-1,int idEmp=-1) 
        {
            puesto = p; area = a; foto = f; fkpersona = fk; id = idEmp;
        }
    }
}