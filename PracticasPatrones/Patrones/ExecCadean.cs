using CadenaResponsabilidades;
using Patrones.CadenaResponsabilidades;

namespace Patrones
{
    public class ExecCadean
    {
        public static void Exec(string[] args)
        {
            IConceptoCompra conceptCompra = new ConceptoCompra();
            Compra compra = new Compra();
            int monto = 0;

            System.Console.WriteLine("Concepto de compra");
            compra.Descripcion =  System.Console.ReadLine();

            System.Console.WriteLine("Monto");
            int.TryParse(System.Console.ReadLine(), out monto);
            compra.Monto = monto;

            conceptCompra.EjecutarCompra(compra);
            System.Console.ReadLine();

        }
    }
}
