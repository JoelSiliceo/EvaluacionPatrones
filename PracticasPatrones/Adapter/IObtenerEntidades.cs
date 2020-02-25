using Adapter.Entidad;
using System.Collections.Generic;

namespace Adapter
{
    public interface IObtenerEntidades
    {
        List<Sucursal> ObtenEntidades();
    }
}
