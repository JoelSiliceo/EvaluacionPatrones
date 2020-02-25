using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Barco : ITransporte
    {
        public void EntregarPedido()
        {
            Console.WriteLine("Entregando pedido por barco");
        }

        public void EnviarPedido()
        {
            Console.WriteLine("Enviando pedido por barco");
        }

        public void RecogerPedido()
        {
            Console.WriteLine("Recogiendo pedido para barco ");
        }
    }
}
