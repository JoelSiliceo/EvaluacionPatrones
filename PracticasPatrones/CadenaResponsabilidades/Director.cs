using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaResponsabilidades
{
    public class Director : Puesto
    {
        public Director()
        {
            base.descripcion = "Director";
            base.montoMaximo = 50000;
        }

    }
}
