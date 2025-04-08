using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_Acceso
    {
        private CD_Acceso accesoDatos = new CD_Acceso();
        public List<DB_ACCESO> ListarAcceso()
        {
            return accesoDatos.ListarAcceso();
        }

        public bool Insertar(DB_ACCESO acceso)
        {
            return accesoDatos.Insertar(acceso);
        }






    }
}
