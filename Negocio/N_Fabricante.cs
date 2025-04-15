using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_Fabricante
    {
        private CD_Fabricante objcd = new CD_Fabricante();

        public List<DB_FABRICANTE> Listar()
        {
            return objcd.Listar();
        }

        public bool Insertar(DB_FABRICANTE fab)
        {
            return objcd.Insertar(fab);
        }

        public bool Eliminar(string codFabricante)
        {
            return objcd.Eliminar(codFabricante);
        }
    }
}
