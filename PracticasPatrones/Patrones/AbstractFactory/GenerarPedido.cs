using AbstractFactory;

namespace Patrones.AbstractFactory
{
    public class GenerarPedido : IGenerarPedido
    {
        IProveedorProducto proveedorProducto;
        private Pedido pedido;

        public GenerarPedido(Pedido _pedido)
        {
            this.pedido = _pedido;
            ISelectorProveedorProducto selectorProveedor = new SelectorProveedorProducto(this.pedido);
            IGeneradorProducto generadorProducto = selectorProveedor.SeleccionarProveedorProducto();
            if (generadorProducto == null)
            {
                System.Console.WriteLine("Solo hay HP o DELL.");
                return;
            }
            ObtenerProveedorProducto(generadorProducto);
        }

        public void GenerarCotizacion()
        {
            if (proveedorProducto !=null)
            {
                System.Console.WriteLine(proveedorProducto.GenerarCotizacion());
            }
            
        }

        void IGenerarPedido.GenerarPedido()
        {
            if (proveedorProducto != null)
            {
                System.Console.WriteLine(proveedorProducto.GenerarRequisicion());
            }
        }

        private void ObtenerProveedorProducto(IGeneradorProducto _generadorProducto)
        {
            switch (this.pedido.Producto)
            {
                case "Monitor":
                    proveedorProducto = _generadorProducto.GenerarMonitor();
                    break;
                case "Laptop":
                    proveedorProducto = _generadorProducto.GenerarLaptop();
                    break;
                default:
                    System.Console.WriteLine("Solo hay Monitor o Laptop");
                    break;
            }
            
        }
    }
}
