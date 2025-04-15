using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_Trabajador
    {
        private CD_Trabajador objcd_trabajador = new CD_Trabajador();

        public List<DB_TRABAJADOR> Listar()
        {
            return objcd_trabajador.Listar();
        }

        public bool Insertar(DB_TRABAJADOR trabajador)
        {
            return objcd_trabajador.Insertar(trabajador);
        }

        public bool Actualizar(DB_TRABAJADOR trabajador)
        {
            return objcd_trabajador.Actualizar(trabajador);
        }

        public bool Eliminar(string codTra)
        {
            return objcd_trabajador.Eliminar(codTra);
        }
    }
}
