using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class ProcesadorComplejo : ProcesadorCXP
    {
        private IOperacion operacion;

        public ProcesadorComplejo(IOperacion _operacion) : base (_operacion)
        {
            base.operacion = _operacion;
        }

        public override void EjecutarOperacion()
        {
            base.operacion.EjecutarOperacion();
            this.operacion.EjecutarOperacion();
        }

        public override void AgregarOperacion(IOperacion _operacion)
        {
            this.operacion = _operacion;
        }
    }
}
