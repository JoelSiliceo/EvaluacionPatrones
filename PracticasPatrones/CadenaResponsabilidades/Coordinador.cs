using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaResponsabilidades
{
    public class Coordinador : Puesto
    {
        public Coordinador()
        {
            base.descripcion = "Coordinador";
            base.montoMaximo = 500;
        }

    }
}
