using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    class ExecAbstractFactory
    {
        public static void Exec(string[] args)
        {
            Pedido pedido = new Pedido();
            
            Console.WriteLine("Proveedor");
            pedido.Proveedor = Console.ReadLine();

            Console.WriteLine("Producto");
            pedido.Producto = Console.ReadLine();

            Console.WriteLine("Cantidad");
            pedido.Cantidad = int.Parse( Console.ReadLine());

            AbstractFactory.IGenerarPedido generarPedido = new AbstractFactory.GenerarPedido(pedido);

            generarPedido.GenerarPedido();
            generarPedido.GenerarCotizacion();

            Console.ReadLine();
        }
    }
}
