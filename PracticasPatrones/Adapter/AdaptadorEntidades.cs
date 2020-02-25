using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Entidad;
using Newtonsoft.Json;

namespace Adapter
{
    public class AdaptadorEntidades : IObtenerEntidades 
    {
        private IObtenerJson srvEntidades;

        public AdaptadorEntidades(IObtenerJson _srvEntidades)
        {
            this.srvEntidades = _srvEntidades;
        }

        public List<Sucursal> ObtenEntidades()
        {
            IObtenerEntidades obtenerEntidades = new ObtenerEntidades();
            List<SucursalJson> sucursalJsons = AdaptarSucursales(srvEntidades.ObtenJson());
            List<Sucursal> sucursales = new List<Sucursal>();

            foreach (SucursalJson item in sucursalJsons)
            {
                sucursales.Add(TransformarEntidaes(item));
            }

            return sucursales;
        }

        private List<SucursalJson> AdaptarSucursales(string jsonSucursales)
        {
            List <SucursalJson>  sucursales = new List<SucursalJson>();
            sucursales = JsonConvert.DeserializeObject<List<SucursalJson>>(jsonSucursales);
                        
            return sucursales;
        }

        private Sucursal TransformarEntidaes (SucursalJson sucursalJson)
        {
            Sucursal sucursal = new Sucursal();

            sucursal.IdSucursal = sucursalJson.id;
            sucursal.Nombre = sucursalJson.Desc;
            sucursal.TotalVentas = sucursalJson.Ventas;

            return sucursal;
        }
    }
}
