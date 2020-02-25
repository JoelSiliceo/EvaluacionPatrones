using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaResponsabilidades
{
    public interface IPuesto
    {
        void AgregarSiguiente(IPuesto puesto);

        void Ejecutar(Compra _compra);
    }
}
