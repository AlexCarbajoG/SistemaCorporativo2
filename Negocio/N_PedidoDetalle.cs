using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_PedidoDetalle
    {
        private CD_PedidoDetalle objDatos = new CD_PedidoDetalle();

        public List<HB_PED_DET> Listar()
        {
            return objDatos.Listar();
        }

        public bool Insertar(HB_PED_DET detalle)
        {
            return objDatos.Insertar(detalle);
        }
    }
}
