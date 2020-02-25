using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PagoTarjeta : IRealizadorPago
    {
        private Pedido pedido;

        internal PagoTarjeta(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public string HacerPago()
        {
            if (this.pedido.Importe > 5000)
            {
                return String.Format("Pedido {0} con importe de {1} {2} fue aceptado.", this.pedido.Concepto, this.pedido.Importe, this.pedido.Modalidad);
            }
            else
            {
                return String.Format("Pedido {0} con importe de {1} {2} fue rechazado.", this.pedido.Concepto, this.pedido.Importe, this.pedido.Modalidad);
            }
            
        }
    }
}
