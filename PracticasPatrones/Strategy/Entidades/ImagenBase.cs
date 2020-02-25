using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entidades
{
    public abstract class ImagenBase
    {
        protected ImagenDTO imagenDTO;

        public ImagenBase(ImagenDTO _imagenDTO)
        {
            this.imagenDTO = _imagenDTO;
        }

        public virtual void Guardar()
        {
            Console.WriteLine("Se ha guardado la imagen {0}.{1}", imagenDTO.Archivo, imagenDTO.Formato.ToString());
        }
    }
}
