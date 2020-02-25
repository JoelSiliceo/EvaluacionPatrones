using System.Collections.Generic;
using Adapter.Entidad;
using Adapter;

namespace Patrones.Adaptador
{
    public class ObtenedorSucursales : IObtenedorSucursales
    {
        private IObtenerEntidades srvObtenerSucursales;

        public ObtenedorSucursales(IObtenerEntidades _srvObtenerSucursales)
        {
            this.srvObtenerSucursales = _srvObtenerSucursales;
        }
        
        public List<Sucursal> ObtenerSucursales()
        {
            return srvObtenerSucursales.ObtenEntidades();
          
        }
    }
}
