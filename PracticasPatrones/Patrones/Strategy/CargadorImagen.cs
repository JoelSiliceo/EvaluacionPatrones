using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;
using Strategy.Entidades;

namespace Patrones.Strategy
{
    
    public class CargadorImagen : ICargadorImagen
    {
        private IImagenesContext imagenContext;

        public CargadorImagen(IImagenesContext _imagenContext)
        {
            imagenContext = _imagenContext;
        }

        public void CambiarFormato(ImagenDTO _imagenDTO)
        {
            imagenContext.CambiarFormato(_imagenDTO);
        }

        public void Guardar()
        {
            imagenContext.Ejecutar();
        }
    }
}
