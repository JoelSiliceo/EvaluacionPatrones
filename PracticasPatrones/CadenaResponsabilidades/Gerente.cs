﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaResponsabilidades
{
    public class Gerente : Puesto
    {
        public Gerente()
        {
            base.descripcion = "Gerente";
            base.montoMaximo = 1000;
        }
    }
}
