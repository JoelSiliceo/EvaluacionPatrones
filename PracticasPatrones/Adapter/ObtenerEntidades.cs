using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Entidad;

namespace Adapter
{
    public class ObtenerEntidades : IObtenerEntidades
    {
        public List<Sucursal> ObtenEntidades()
        {
            List<Sucursal> sucursales = new List<Sucursal>();

            sucursales.Add(GenerarSucursal(1, "Sucursal1", 10));
            sucursales.Add(GenerarSucursal(2, "Sucursal2", 13));
            sucursales.Add(GenerarSucursal(3, "Sucursal3", 20));
            sucursales.Add(GenerarSucursal(4, "Sucursal4", 32));
            sucursales.Add(GenerarSucursal(5, "Sucursal5", 14));

            return sucursales;
        }

        private Sucursal GenerarSucursal(int _idSucursal, String _nombre, int _totalVentas)
        {
            Sucursal sucursal = new Sucursal();

            sucursal.IdSucursal = _idSucursal;
            sucursal.Nombre = _nombre;
            sucursal.TotalVentas = _totalVentas;

            return sucursal;
        }
    }
}
