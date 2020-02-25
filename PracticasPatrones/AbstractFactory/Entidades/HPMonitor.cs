using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entidades
{
    public class HPMonitor : ProveedorProducto
    {

        public HPMonitor(Pedido pedido) : base(pedido)
        {
            base.precio = 3700;
            base.IVA = 16;
        }
    }
}
