using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Proceso
    {
        public enum Paso
        {
            Subir = 1,
            Notificador = 2,
            Compilador = 3,
            PruebasUnitarias = 4,
            Instaldor = 5
        }
    }
}
