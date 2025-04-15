using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_Articulo
    {
        private CD_Articulo objcd_articulo = new CD_Articulo();

        public List<DB_ARTICULO> Listar()
        {
            return objcd_articulo.Listar();
        }

        public bool Insertar(DB_ARTICULO articulo)
        {
            return objcd_articulo.Insertar(articulo);
        }

    }    
}
