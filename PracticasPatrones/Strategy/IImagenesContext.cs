using Strategy.Entidades;


namespace Strategy
{
    public interface IImagenesContext
    {
        void CambiarFormato(ImagenDTO _imagenDTO);

        void Ejecutar();
    }
}
