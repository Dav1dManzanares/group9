﻿using CommonLayer.Entidades;
using DataAccessLayer.ConeccionBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.servicios
{
    public class AlimentosServicios
    {
        private AlimentosBD _alimentosBD;
        public AlimentosServicios()
        {
            _alimentosBD = new AlimentosBD();
        }

        public void GuardarElectricos(EntidadesAlimentos entidadesAlimentos)
        {
            _alimentosBD.InsertarAlimentos(entidadesAlimentos);
        }

        public void ModificarElectricos(EntidadesAlimentos entidadesAlimentos)
        {
            _alimentosBD.ActualizarAlimento(entidadesAlimentos);
        }
    }
}
