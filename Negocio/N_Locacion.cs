using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_Locacion
    {
        private CD_Locacion objcd_locacion = new CD_Locacion();

        public List<DB_LOCACION> Listar()
        {
            return objcd_locacion.Listar();
        }

        public bool Insertar(DB_LOCACION loc)
        {
            return objcd_locacion.Insertar(loc);
        }

        public bool Actualizar(DB_LOCACION loc)
        {
            return objcd_locacion.Actualizar(loc);
        }

        public bool Eliminar(string codLoc)
        {
            return objcd_locacion.Eliminar(codLoc);
        }
    }
}
