using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ObtenerJson : IObtenerJson
    {
        public string ObtenJson()
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append("[{ \"id\":" + 10 + " ,\"Desc\":\"Sucursal10\",\"Ventas\": " + 100 + " },");
            resultado.Append("{ \"id\":" + 11 + " ,\"Desc\":\"Sucursal10\",\"Ventas\": " + 101 + " },");
            resultado.Append("{ \"id\":" + 12 + " ,\"Desc\":\"Sucursal10\",\"Ventas\": " + 102 + " },");
            resultado.Append("{ \"id\":" + 13 + " ,\"Desc\":\"Sucursal10\",\"Ventas\": " + 103 + " },");
            resultado.Append("{ \"id\":" + 14 + " ,\"Desc\":\"Sucursal10\",\"Ventas\": " + 104 + " },");
            resultado.Append("{ \"id\":" + 15 + " ,\"Desc\":\"Sucursal10\",\"Ventas\": " + 105 + " },");
            resultado.Append("{ \"id\":" + 16 + " ,\"Desc\":\"Sucursal10\",\"Ventas\": " + 106 + " },");
            resultado.Append("{ \"id\":" + 17 + " ,\"Desc\":\"Sucursal10\",\"Ventas\": " + 107 + " }]");

            return resultado.ToString();            
        }
    }
}
