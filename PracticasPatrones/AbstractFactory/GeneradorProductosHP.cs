using AbstractFactory.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class GeneradorProductosHP : IGeneradorProducto
    {
        private Pedido pedido;
        internal GeneradorProductosHP(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public IProveedorProducto GenerarLaptop()
        {
            return new HPLaptop(this.pedido);
        }

        public IProveedorProducto GenerarMonitor()
        {
            return new HPMonitor(this.pedido);
        }
    }
}
