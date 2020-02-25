using Bridge;
using Patrones.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    public class ExecBridge
    {
        public static void Exec(string[] args)
        {
            ITransporte barco = new Barco();
            ITransporte tren = new Tren();
            ITransporte avion = new Avion();

            IPaqueteria paqueteriaDHL = new DHL(avion);
            IPaqueteria paqueteriaFedex = new DHL(barco);
            IPaqueteria paqueteriaEstafeta = new DHL(tren);

            IPedidos pedido = new Pedidos(paqueteriaDHL);

            Console.WriteLine("Pedido DHL avion");
            pedido.Ejecutar();

            Console.WriteLine("Pedido DHL barco");
            pedido.CambiarTransporte(barco);
            pedido.Ejecutar();

            Console.WriteLine("Pedido Fedex");
            pedido.CambiarPaqueteria(paqueteriaFedex);
            pedido.Ejecutar();

            Console.WriteLine("Pedido Estafeta");
            pedido.CambiarPaqueteria(paqueteriaEstafeta);
            pedido.Ejecutar();

            Console.ReadLine();
        }


    }
}
