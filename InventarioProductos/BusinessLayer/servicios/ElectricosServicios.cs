using CommonLayer.Entidades;
using DataAccessLayer.ConeccionBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.servicios
{
    public class ElectricosServicios
    {
        private ElectricosBD _electricosBD;

        public ElectricosServicios()
        {
            _electricosBD = new ElectricosBD();
        }

        public void GuardarElectricos(EntidadesElectricos entidadesElectricos)
        {
            _electricosBD.InsertarElectricos(entidadesElectricos);
        }

        public void ModificarElectricos(EntidadesElectricos entidadesElectricos)
        {
            _electricosBD.ActualizarElectricos(entidadesElectricos);
        }
    }
}
