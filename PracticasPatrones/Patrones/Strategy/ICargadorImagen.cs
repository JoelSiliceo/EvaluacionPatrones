using Strategy.Entidades;

namespace Patrones.Strategy
{
    public interface ICargadorImagen
    {
        void CambiarFormato(ImagenDTO _imagenDTO);

        void Guardar();
    }
}
