using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_PedidoCabecera
    {
        private CD_PedidoCabecera objDatos = new CD_PedidoCabecera();


        public List<HB_PED_CAB> Listar()
        {
            return objDatos.Listar();
        }

        public bool Insertar(HB_PED_CAB cabecera)
        {
            return objDatos.Insertar(cabecera);
        }
    }

}
