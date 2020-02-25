using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadenaResponsabilidades;

namespace Patrones.CadenaResponsabilidades
{
    public class ConceptoCompra : IConceptoCompra
    {
        public void EjecutarCompra(Compra _compra)
        {
            IPuesto coordinador = new Coordinador();
            IPuesto gerente = new Gerente();
            IPuesto subdirector = new Subdirector();
            IPuesto director = new Director();

            coordinador.AgregarSiguiente(gerente);
            gerente.AgregarSiguiente(subdirector);
            subdirector.AgregarSiguiente(director);

            coordinador.Ejecutar(_compra);
        }
    }
}
