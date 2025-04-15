using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_Vendedor
    {
        private CD_Vendedor objcd_vendedor = new CD_Vendedor();

        public List<DB_VENDEDOR> Listar()
        {
            return objcd_vendedor.Listar();
        }

        public bool Insertar(DB_VENDEDOR vendedor)
        {
            return objcd_vendedor.Insertar(vendedor);
        }

        public bool Actualizar(DB_VENDEDOR vendedor)
        {
            return objcd_vendedor.Actualizar(vendedor);
        }

        public bool Eliminar(string codVendedor)
        {
            return objcd_vendedor.Eliminar(codVendedor);
        }
    }
}
