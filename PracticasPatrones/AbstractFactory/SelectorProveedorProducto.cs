using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SelectorProveedorProducto : ISelectorProveedorProducto
    {
        Pedido pedido;
        public SelectorProveedorProducto(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public IGeneradorProducto SeleccionarProveedorProducto()
        {
            switch (this.pedido.Proveedor.ToUpper())
            {
                case "HP":
                    return new GeneradorProductosHP(this.pedido);
                case "DELL":
                    return new GeneradorPoductosDell(this.pedido);
            }

            return null;
        }
    }
}
