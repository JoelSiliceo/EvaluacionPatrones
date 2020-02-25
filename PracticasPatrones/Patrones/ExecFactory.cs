using Factory;

namespace Patrones
{
    class ExecFactory
    {
        public static void Exec(string[] args)
        {
            Pedido pedido = new Pedido();

            System.Console.WriteLine("Concepto:");
            pedido.Concepto = System.Console.ReadLine();

            System.Console.WriteLine("Importe:");
            pedido.Importe = double.Parse(System.Console.ReadLine());

            
            System.Console.WriteLine("1 - Tarjeta");
            System.Console.WriteLine("2 - Efectivo");
            string tipoPago = System.Console.ReadLine();
            if (tipoPago == "1")
            {
                pedido.Modalidad = Pago.Modalidad.Tarjeta;
            }
            else if (tipoPago == "2")
            {
                pedido.Modalidad = Pago.Modalidad.Efectivo;
            }
            

            IProcesadorPedidos procesador = new Factory.ProcesadorPedido(pedido);
            System.Console.WriteLine(procesador.ProcesarPedidos());

            System.Console.ReadKey();
        }
    }
}
