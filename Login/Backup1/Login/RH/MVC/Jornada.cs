using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARI.MVC
{
    public class Jornada
    {
        public string tipo { get; set; }
        public int idJornada { get; set; }
        public int DiasSemana { get; set; }
        public string turno { get; set; }
        public string hrEntrada { get; set; }
        public string hrSalida { get; set; }
        public Jornada(string t, int dsSem, string turn, string hrE, string hrSa,int id=-1)
        {
            tipo = t;
            DiasSemana = dsSem;
            turno = turn;
            hrEntrada = hrE;
            hrSalida = hrSa;
            idJornada = id;
        }
    }
}