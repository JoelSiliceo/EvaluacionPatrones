using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entidades
{
    public class DellLaptop : ProveedorProducto
    {
        public DellLaptop(Pedido pedido): base (pedido)
        {
            base.precio = 6150;
            base.IVA = 15;
        }
    }
}
