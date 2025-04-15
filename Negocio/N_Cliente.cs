using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_Cliente
    {
        private CD_Cliente objcd_cliente = new CD_Cliente();

        public List<DB_CLIENTE> Listar()
        {
            return objcd_cliente.Listar();
        }

        public bool Insertar(DB_CLIENTE cliente)
        {
            return objcd_cliente.Insertar(cliente);
        }
    }
}
