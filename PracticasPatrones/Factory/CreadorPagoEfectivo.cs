using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CreadorPagoEfectivo : ICreadorPago
    {
        private Pedido pedido;
        internal CreadorPagoEfectivo(Pedido _pedido)
        {
            this.pedido = _pedido;
        }
        public IRealizadorPago CrearModalidadPago()
        {
            return new PagoEfectivo(this.pedido);
        }
    }
}
