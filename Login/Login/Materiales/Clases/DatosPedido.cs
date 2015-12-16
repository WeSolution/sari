using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//paramettros que ingrasremos en sol_requesicion
namespace Altaderequisicion
{
    public class DatosPedido
    {
        // Declaración de variables
       
        private decimal monto;
        private DateTime fecha;
        private int idcliente;

        public DatosPedido()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        // Métodos de acceso
       
        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
      
        public int idCliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
    }
}