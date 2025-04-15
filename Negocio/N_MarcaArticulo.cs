using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_MarcaArticulo
    {
        private CD_MarcaArticulo objcd = new CD_MarcaArticulo();

        public List<DB_MAR_ART> Listar()
        {
            return objcd.Listar();
        }

        public bool Insertar(DB_MAR_ART marca)
        {
            return objcd.Insertar(marca);
        }

        public bool Eliminar(string codMarca)
        {
            return objcd.Eliminar(codMarca);
        }
    }
}
