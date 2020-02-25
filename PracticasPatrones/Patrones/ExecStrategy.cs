using Patrones.Strategy;
using Strategy;
using Strategy.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    public class ExecStrategy
    {
        public static void Exec(string[] args)
        {
            ImagenDTO _imagenDTO = new ImagenDTO();
            IImagenesContext _imagenesContext = new ImagenesContext();
            ICargadorImagen cargadorImagen = new CargadorImagen(_imagenesContext);

            int opcion = 0;

            while (opcion < 4)
            {
                Console.Clear();
                Console.WriteLine("1. BMP");
                Console.WriteLine("2. GIF");
                Console.WriteLine("3. JPG");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                if (opcion < 4)
                {
                    Console.WriteLine("Nombre del Archivo");
                    _imagenDTO.Archivo = Console.ReadLine();
                    _imagenDTO.Formato = (Imagen.Formato)opcion;

                    cargadorImagen.CambiarFormato(_imagenDTO);
                    cargadorImagen.Guardar();

                    Console.ReadLine();
                }
            }
        }
    }
}
