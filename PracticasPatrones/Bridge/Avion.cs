using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Avion : ITransporte
    {
        public void EntregarPedido()
        {
            Console.WriteLine("Entregando pedido por avión");
        }

        public void EnviarPedido()
        {
            Console.WriteLine("Enviando pedido por avión");
        }

        public void RecogerPedido()
        {
            Console.WriteLine("Recogiendo pedido para avión ");
        }
    }
}
