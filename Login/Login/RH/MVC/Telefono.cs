using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARI.MVC
{
    public class Telefono
    {
        public int ID { get; set; }
        public string NumeroTel { set; get; }
        public string TipoTel { set; get; }

        public Telefono(string n, string t, int idTel = -1)
        {
            NumeroTel = n;
            TipoTel = t;
            ID = idTel;
        }
    }
}