using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Pedido
    {
        public string Concepto { get; set; }

        public double Importe { get; set; }

        public Pago.Modalidad Modalidad { get; set; }
    }
}
