using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class GuardadorHistorial : IOperacion
    {
        public void EjecutarOperacion()
        {
            Console.WriteLine("Guardando historial");
        }
    }
}
