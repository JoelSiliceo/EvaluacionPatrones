using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Entidades
{
    public class PruebasUnitarias : IProcesoIntegrador
    {
        public void Ejecutar()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
