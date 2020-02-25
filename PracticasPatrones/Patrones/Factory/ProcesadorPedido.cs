using Factory;

namespace Patrones.Factory
{
    public class ProcesadorPedido : IProcesadorPedidos
    {
        Pedido pedido;
        public ProcesadorPedido(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public string ProcesarPedidos()
        {
            ICreadorTipoPago creadorPago = new CreadorTipoPago(this.pedido);
            IRealizadorPago realizadorPago =  creadorPago.CrearModalidadPago();

            return realizadorPago.HacerPago();
        }
    }
}
