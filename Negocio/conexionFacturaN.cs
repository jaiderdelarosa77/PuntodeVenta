﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class conexionFacturaN
    {
        conexionFactura cn=new conexionFactura();
        public string consultaFactura()
        {
            return cn.consultaFactura();
        }
    }
}