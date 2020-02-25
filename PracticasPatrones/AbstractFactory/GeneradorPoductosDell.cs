
namespace AbstractFactory
{
    public class GeneradorPoductosDell : IGeneradorProducto
    {
        private Pedido pedido;
        internal GeneradorPoductosDell(Pedido _pedido)
        {
            this.pedido = _pedido;
        }
        public IProveedorProducto GenerarLaptop()
        {
            return new Entidades.DellLaptop(this.pedido);
        }

        public IProveedorProducto GenerarMonitor()
        {
            return new Entidades.DellMonitor(this.pedido); 
        }
    }
}
