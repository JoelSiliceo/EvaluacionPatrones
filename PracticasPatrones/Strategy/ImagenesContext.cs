
using Strategy.Entidades;

namespace Strategy
{
    public class ImagenesContext : IImagenesContext
    {
        private ImagenBase formatoImagenes;


        public void CambiarFormato(ImagenDTO _imagenDTO)
        {
            this.GenerarFormatoImagenes(_imagenDTO);
        }

        public void Ejecutar()
        {
            this.formatoImagenes.Guardar();
        }

        protected void GenerarFormatoImagenes(ImagenDTO _imagenDTO)
        {
            switch (_imagenDTO.Formato)
            {
                case Imagen.Formato.BMP:
                    this.formatoImagenes = new ImagenBMP(_imagenDTO);
                    return;
                case Imagen.Formato.GIF:
                    this.formatoImagenes = new ImagenGIF(_imagenDTO);
                    return;
                case Imagen.Formato.JPG:
                    this.formatoImagenes = new ImagenJPG(_imagenDTO);
                    return;
            }

            throw new System.Exception("No se pudo generar instancia de Imagen");
        }
    }
}
