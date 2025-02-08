using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;

namespace Negocio
{
    public class N_RegionFisica
    {
        private CD_RegionFisica objcd_regionfisica = new CD_RegionFisica();

        public List<DB_REG_FIS> Listar()
        {
            return objcd_regionfisica.Listar();
        }


        public bool Insertar(DB_REG_FIS region)
        {
            return objcd_regionfisica.Insertar(region);
        }

        public bool Actualizar(DB_REG_FIS region)
        {
            return objcd_regionfisica.Actualizar(region);
        }

        public bool Eliminar(short codRegion)
        {
            return objcd_regionfisica.Eliminar(codRegion);
        }


    }
}
