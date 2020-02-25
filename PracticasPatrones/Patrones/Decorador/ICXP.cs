using Decorador;


namespace Patrones.Decorador
{
    public interface ICXP
    {
        void CambiarOperacion(IOperacion _operacion);

        void Ejecutar();
    }
}
