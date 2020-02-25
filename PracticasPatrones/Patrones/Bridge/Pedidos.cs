using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace Patrones.Bridge
{
    public class Pedidos : IPedidos
    {
        private IPaqueteria paqueteria;

        public Pedidos(IPaqueteria _paqueteria)
        {
            this.paqueteria = _paqueteria;
        }

        public void CambiarPaqueteria(IPaqueteria _paqueteria)
        {
            this.paqueteria = _paqueteria;
        }

        public void CambiarTransporte(ITransporte _transporte)
        {
            this.paqueteria.CambiarMedio( _transporte);
        }

        public void Ejecutar()
        {
            this.paqueteria.Ejecutar();
        }




    }
}
