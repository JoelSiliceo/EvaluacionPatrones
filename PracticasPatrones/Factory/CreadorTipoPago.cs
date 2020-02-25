using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CreadorTipoPago : ICreadorTipoPago
    {
        private Pedido pedido;

        public CreadorTipoPago(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public IRealizadorPago CrearModalidadPago()
        {
            ICreadorPago creadorPago = null;

            switch (this.pedido.Modalidad)
            {
                case Pago.Modalidad.Efectivo:
                    creadorPago = new CreadorPagoEfectivo(this.pedido);
                    break;
                case Pago.Modalidad.Tarjeta:
                    creadorPago =  new CreadorPagoTarjeta(this.pedido);
                    break;
            }

            return creadorPago.CrearModalidadPago();

        }
    }
}
