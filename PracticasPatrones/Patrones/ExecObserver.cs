using Observer;
using Patrones.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    public class ExecObserver
    {
        public static void Exec(string[] args)
        {
            int opcion = 0;
            IPublicador publicador = new Publicador();
            IProcesarIntegracion procesadorPedidos = new ProcesarIntegracion(publicador);
            Proceso.Paso paso;
            while (opcion < 6)
            {
                Console.Clear();
                Console.WriteLine("1 = Subir Código");
                Console.WriteLine("2 = Agregar Notificador");
                Console.WriteLine("3 = Agregar Compilador");
                Console.WriteLine("4 = Agregar Ejecutor de Pruebas Unitarias");
                Console.WriteLine("5 = Agregar Instalador");
                Console.WriteLine("6 = Salir");

                int.TryParse(Console.ReadLine(), out opcion);

                if (opcion > 0 && opcion < 6)
                {
                    paso = (Proceso.Paso)opcion;
                    procesadorPedidos.Ejecutar(paso);
                    Console.ReadLine();
                }
            }
            
        }
    }
}
