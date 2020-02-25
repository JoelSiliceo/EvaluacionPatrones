using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Fedex : Paqueteria
    {
        public Fedex(ITransporte _transporte) : base(_transporte)
        {
            base.nombrePaqueteria = "Fedex";
        }
    }
}
