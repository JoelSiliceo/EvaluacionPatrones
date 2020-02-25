using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entidades
{
    public class DellMonitor : ProveedorProducto
    {
        public DellMonitor(Pedido pedido) : base(pedido)
        {
            base.precio = 4150;
            base.IVA = 15;
        }
    }
}
