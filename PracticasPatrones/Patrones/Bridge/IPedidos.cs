using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Bridge
{
    public interface IPedidos
    {

        void Ejecutar();

        void CambiarTransporte(ITransporte _transporte);

        void CambiarPaqueteria(IPaqueteria _paqueteria);
    }
}
