﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_PA
{
    internal class ClienteRegular : Clientes
    {
        public ClienteRegular(string nombre, string correo, string telefono, string tipo) : base(nombre, correo, telefono, tipo)
        {
        }
    }
}
