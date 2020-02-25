using Decorador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Decorador
{
    public class CXP : ICXP
    {
        private IOperacion operacion;

        public CXP(IOperacion _operacion)
        {
            this.operacion = _operacion;
        }

        public void CambiarOperacion(IOperacion _operacion)
        {
            this.operacion = _operacion;
        }

        public void Ejecutar()
        {
            operacion.EjecutarOperacion();
        }
    }
}
