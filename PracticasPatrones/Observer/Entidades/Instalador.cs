

namespace Observer.Entidades
{
    public class Instalador : IProcesoIntegrador
    {
        public void Ejecutar()
        {
            System.Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}
