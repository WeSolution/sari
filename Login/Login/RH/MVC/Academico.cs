using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARI.MVC
{
    public class Academico
    {
        public int Id { set; get; }
        public DateTime Fecha_Ini { set; get; }
        public DateTime Fecha_Ter { set; get; }
        public String Titulo_Obt { set; get; }
        public String Institucion { set; get; }
        public int IdfkEmpleado { set; get; }

        public Academico(DateTime FI, DateTime FT, String TO, String Inst, int Empl = -1, int I=-1)
        {
            Id = I;
            Fecha_Ini = FI;
            Fecha_Ter = FT;
            Titulo_Obt = TO;
            Institucion = Inst;
            IdfkEmpleado = Empl;
        }
    }
}