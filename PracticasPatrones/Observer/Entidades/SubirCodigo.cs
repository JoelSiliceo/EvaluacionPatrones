using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Entidades
{
    public class SubirCodigo : IProcesoIntegrador
    {
        public void Ejecutar()
        {
            Console.WriteLine("Commit de código de la versión 1.1");
        }
    }
}
