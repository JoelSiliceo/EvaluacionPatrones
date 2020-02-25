using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CreadorPagoTarjeta : ICreadorPago
    {
        private Pedido pedido;
        internal CreadorPagoTarjeta(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public IRealizadorPago CrearModalidadPago()
        {
            return new PagoTarjeta(this.pedido);
        }
    }
}
