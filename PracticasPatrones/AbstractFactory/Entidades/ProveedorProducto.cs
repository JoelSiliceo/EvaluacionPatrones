using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entidades
{
    public abstract class ProveedorProducto : IProveedorProducto
    {
        protected Pedido pedido;
        protected int precio;
        protected int IVA;

        public ProveedorProducto(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public virtual string GenerarCotizacion()
        {
            double precio = Convert.ToDouble(this.pedido.Cantidad) * Convert.ToDouble(this.precio) * (1 + (Convert.ToDouble(this.IVA) / 100));
            string mensaje = String.Format("Cotización: La compra tendría un importe " +
                "de {0}", precio);

                return mensaje;
        }

        public virtual string GenerarRequisicion()
        {
            string mensaje = String.Format("Requisición: Compra de {0} {1} con {2}", this.pedido.Cantidad, this.pedido.Producto, this.pedido.Proveedor);

            return mensaje;
        }
    }
}
