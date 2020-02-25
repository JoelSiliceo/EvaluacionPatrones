using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Paqueteria : IPaqueteria
    {
        protected ITransporte transporte;
        protected String nombrePaqueteria;

        public Paqueteria(ITransporte _transporte)
        {
            this.transporte = _transporte;
        }

        public virtual void CambiarMedio(ITransporte _transporte)
        {
            this.transporte = _transporte;
        }

        public virtual void Ejecutar()
        {
            this.transporte.RecogerPedido();
            this.transporte.EnviarPedido();
            this.transporte.EntregarPedido();
        }
    }
}
