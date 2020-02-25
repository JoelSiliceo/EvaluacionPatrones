using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    class Ejecutar
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion < 9)
            {
                Console.Clear();
                Console.WriteLine("1. Factory");
                Console.WriteLine("2. Abstract Factory");
                Console.WriteLine("3. Observer");
                Console.WriteLine("4. Strategy");
                Console.WriteLine("5. Adaptador");
                Console.WriteLine("6. Bridge");
                Console.WriteLine("7. Decorador");
                Console.WriteLine("8. Cadena Responsabilidades");
                Console.WriteLine("9. Salir");

                int.TryParse(System.Console.ReadLine(), out opcion);

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        ExecFactory.Exec(args);
                        break;
                    case 2:
                        ExecAbstractFactory.Exec(args);
                        break;
                    case 3:
                        ExecObserver.Exec(args);
                        break;
                    case 4:
                        ExecStrategy.Exec(args);
                        break;
                    case 5:
                        ExecAdaptador.Exec(args);
                        break;
                    case 6:
                        ExecBridge.Exec(args);
                        break;
                    case 7:
                        ExecDecorador.Exec(args);
                        break;
                    case 8:
                        ExecCadean.Exec(args);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
    }
}
