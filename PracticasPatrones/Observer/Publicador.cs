using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Publicador : IPublicador
    {
        public List<IProcesoIntegrador> procesosIntegrador { get; set; }

        public Publicador()
        {
            this.procesosIntegrador = new List<IProcesoIntegrador>();
        }

        public void AgregarQuitarIntegrador(IProcesoIntegrador _procesoIntegrador)
        {
            if (existeProcesoIntegrador(_procesoIntegrador))
            {
                this.procesosIntegrador.Remove(_procesoIntegrador);
                this.MostrarOperacion("quitó", _procesoIntegrador);
            }
            else
            {
                this.procesosIntegrador.Add(_procesoIntegrador);
                this.MostrarOperacion("agregó",_procesoIntegrador);
                
            }
        }

        private void MostrarOperacion(string operacion,IProcesoIntegrador _procesoIntegrador)
        {
            Console.WriteLine(String.Format("Se {0} {1} al proceso: ",operacion, _procesoIntegrador.ToString().Split('.')[2]));
        }

        public void Notificar()
        {
            foreach(IProcesoIntegrador procesoIntegrador in procesosIntegrador)
            {
                procesoIntegrador.Ejecutar();
            }
        }

        private bool existeProcesoIntegrador(IProcesoIntegrador _procesoIntegrador)
        {
            return this.procesosIntegrador.Any(p => p == _procesoIntegrador);
        }
    }
}
