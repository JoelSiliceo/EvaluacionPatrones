using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entidades
{
    public class ImagenDTO
    {
        public String Archivo { get; set; }

        public Imagen.Formato Formato { get; set; }
    }
}
