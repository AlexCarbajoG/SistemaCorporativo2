using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_UbicacionGeografica
    {
        private CD_UbicacionGeografica objcd_ubigeo = new CD_UbicacionGeografica();

        public List<DB_UBI_GEO> Listar()
        {
            return objcd_ubigeo.Listar();
        }

        public bool Insertar(DB_UBI_GEO ubicacion)
        {
            return objcd_ubigeo.Insertar(ubicacion);
        }

        public bool Actualizar(DB_UBI_GEO ubicacion)
        {
            return objcd_ubigeo.Actualizar(ubicacion);
        }

        public bool Eliminar(string codPais, short codDpto, short codCiu, short codBarr)
        {
            return objcd_ubigeo.Eliminar(codPais, codDpto, codCiu, codBarr);
        }

        public DB_USUARIO ObtenerPrimerUsuario()
        {
            return objcd_ubigeo.ObtenerPrimerUsuario();
        }
    }
}
