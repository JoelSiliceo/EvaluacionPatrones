using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;
using Observer.Entidades;

namespace Patrones.Observer
{
    public class ProcesarIntegracion : IProcesarIntegracion
    {
        private IPublicador publicador;
        private IProcesoIntegrador subirCodigo;
        private IProcesoIntegrador compilador;
        private IProcesoIntegrador uTesting;
        private IProcesoIntegrador notificador;
        private IProcesoIntegrador instalador;


        public ProcesarIntegracion(IPublicador _publicador)
        {
            this.publicador = _publicador;
            subirCodigo = new SubirCodigo();
            compilador = new Compilador();
            uTesting = new PruebasUnitarias();
            notificador = new Notificador();
            instalador = new Instalador();

            this.publicador.AgregarQuitarIntegrador(this.subirCodigo);
        }

        public void Ejecutar(Proceso.Paso opcion)
        {
            switch (opcion)
            {
                case Proceso.Paso.Compilador:
                    this.publicador.AgregarQuitarIntegrador(this.compilador);
                    break;
                case Proceso.Paso.Instaldor:
                    this.publicador.AgregarQuitarIntegrador(this.instalador);
                    break;
                case Proceso.Paso.Notificador:
                    this.publicador.AgregarQuitarIntegrador(this.notificador);
                    break;
                case Proceso.Paso.PruebasUnitarias:
                    this.publicador.AgregarQuitarIntegrador(this.uTesting);
                    break;
                case Proceso.Paso.Subir:
                    this.publicador.Notificar();
                    break;
                default:
                    Console.WriteLine("Operación no válida");
                    break;
            }
        }
    }
}
