using Decorador;
using Patrones.Decorador;

namespace Patrones
{
    public class ExecDecorador
    {
        public static void Exec(string[] args)
        {
            IOperacion envioCorreo = new EnviadorCorreo();
            IOperacion guardaHistorial = new GuardadorHistorial();
            ProcesadorCXP cXPConCorreoHistorial = new ProcesadorComplejo(guardaHistorial);
            cXPConCorreoHistorial.AgregarOperacion(envioCorreo);
            ICXP cxp = new CXP(envioCorreo);

            System.Console.WriteLine("Modificación 1");
            cxp.Ejecutar();

            System.Console.WriteLine("Modificación 2");
            cxp.CambiarOperacion(guardaHistorial);
            cxp.Ejecutar();

            System.Console.WriteLine("Modificación 3");
            cxp.CambiarOperacion(cXPConCorreoHistorial);
            cxp.Ejecutar();

            System.Console.ReadLine();
        }
    }
}
