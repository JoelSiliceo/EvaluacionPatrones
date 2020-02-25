using Adapter.Entidad;
using System.Collections.Generic;

namespace Patrones.Adaptador
{
    public interface IObtenedorSucursales
    {
        List<Sucursal> ObtenerSucursales();
    }
}
