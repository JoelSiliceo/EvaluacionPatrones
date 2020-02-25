using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaResponsabilidades
{
    public class Subdirector : Puesto
    {
        public Subdirector()
        {
            base.descripcion = "Subdirector";
            base.montoMaximo = 15000;
        }
    }
}
