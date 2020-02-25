using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entidades
{
    public class HPLaptop : ProveedorProducto
    {

        public HPLaptop(Pedido pedido) : base(pedido)
        {
            base.precio = 5700;
            base.IVA = 16;
        }
    }
}
