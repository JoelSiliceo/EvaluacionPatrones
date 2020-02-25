using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Entidades
{
    public class Compilador : IProcesoIntegrador
    {
        public void Ejecutar()
        {
            Console.WriteLine("Compilación de código correcta");
        }
    }
}
