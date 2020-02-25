using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Tren : ITransporte
    {
        public void EntregarPedido()
        {
            Console.WriteLine("Entregando pedido por tren"); 
        }

        public void EnviarPedido()
        {
            Console.WriteLine("Enviando pedido por tren");
        }

        public void RecogerPedido()
        {
            Console.WriteLine("Recogiendo pedido para tren ");
        }
    }
}
