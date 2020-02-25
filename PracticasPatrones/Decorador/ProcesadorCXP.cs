using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public abstract class ProcesadorCXP : IOperacion
    {
        protected IOperacion operacion;

        public ProcesadorCXP(IOperacion _operacion)
        {
            this.operacion = _operacion;
        }
        public abstract void EjecutarOperacion();

        public abstract void AgregarOperacion(IOperacion _operacion);
    }
}
