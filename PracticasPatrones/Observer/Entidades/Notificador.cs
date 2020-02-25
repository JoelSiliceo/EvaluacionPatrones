using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Entidades
{
    public class Notificador : IProcesoIntegrador
    {
        public void Ejecutar()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
