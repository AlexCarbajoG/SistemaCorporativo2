using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_Proveedor
    {
        private CD_Proveedor objcd = new CD_Proveedor();

        public List<DB_PROVEEDOR> Listar()
        {
            return objcd.Listar();
        }

        public bool Insertar(DB_PROVEEDOR proveedor)
        {
            return objcd.Insertar(proveedor);
        }
    }
}
