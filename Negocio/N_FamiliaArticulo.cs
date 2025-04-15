using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_FamiliaArticulo
    {
        private CD_FamiliaArticulo objCD = new CD_FamiliaArticulo();

        public List<DB_FMA_ART> Listar()
        {
            return objCD.Listar();
        }

        public bool Insertar(DB_FMA_ART fam)
        {
            return objCD.Insertar(fam);
        }
    }
}
