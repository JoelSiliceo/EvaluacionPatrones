using Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Observer
{
    public interface IProcesarIntegracion
    {
        void Ejecutar(Proceso.Paso opcion);
    }
}
