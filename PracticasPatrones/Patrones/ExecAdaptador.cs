using Adapter;
using Adapter.Entidad;
using System;
using System.Collections.Generic;

namespace Patrones
{
    public class ExecAdaptador
    {
        public static void Exec(string[] args)
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            IObtenerJson obtenerJson = new ObtenerJson();
            IObtenerEntidades srvEntidades = new AdaptadorEntidades(obtenerJson);
            //IObtenerEntidades srvEntidades = new ObtenerEntidades();
            Adaptador.IObtenedorSucursales srvEnt = new Adaptador.ObtenedorSucursales(srvEntidades);
            Console.WriteLine("Obtener Solicitudes");

            sucursales = srvEnt.ObtenerSucursales();

            ImprimirSucursales(sucursales);

            Console.ReadLine();
        }

        private static void ImprimirSucursales(List<Sucursal> sucursales)
        {
            foreach (Sucursal sucursal in sucursales)
            {
                Console.WriteLine(String.Format ("Id: {0}  Nombre: {1}  Ventas: {2}", sucursal.IdSucursal, sucursal.Nombre, sucursal.TotalVentas));
            }
        }
    }
}
