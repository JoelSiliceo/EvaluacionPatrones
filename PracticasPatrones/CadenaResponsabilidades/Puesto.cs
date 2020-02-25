using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaResponsabilidades
{
    public  abstract class Puesto : IPuesto
    {
        protected IPuesto puestoSiguiente;
        protected String descripcion;
        protected int montoMaximo;

        public void AgregarSiguiente(IPuesto _puesto)
        {
            this.puestoSiguiente = _puesto;
        }

        public virtual void Ejecutar(Compra _compra)
        {
                if (_compra.Monto <= this.montoMaximo)
                {
                    Console.WriteLine(string.Format("{0} AUTORIZADA por el {1}", _compra.Descripcion, this.descripcion));
                    return;
                }
                else if (this.puestoSiguiente != null)
                {
                    puestoSiguiente.Ejecutar(_compra);
                    return;
                }


            Console.WriteLine(String.Format("{0} DENEGADA", _compra.Descripcion));
        }
    }
}
