﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class DHL : Paqueteria
    {
        public DHL(ITransporte _transporte) : base (_transporte)
        {
            base.nombrePaqueteria = "DHL";
        }
    }
}
