﻿using CommonLayer.Entidades;
using DataAccessLayer;
using DataAccessLayer.ConeccionBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.servicios
{
    
    public class MueblesServicios
    {
        private MueblesBD _mueblesBD;
        public MueblesServicios()
        {
            _mueblesBD = new MueblesBD();
        }

        public void GuardarElectricos(EntidadesMuebles entidadesMuebles)
        {
            _mueblesBD.InsertarMuebles(entidadesMuebles);
        }

        public void ModificarElectricos(EntidadesMuebles entidadesMuebles)
        {
            _mueblesBD.ActualizarMuebles(entidadesMuebles);
        }

    }

    
}
