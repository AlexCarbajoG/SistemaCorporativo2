using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_Persona
    {
        private CD_Persona objcd_persona = new CD_Persona();

        public List<DB_PERSONA> Listar()
        {
            return objcd_persona.Listar();
        }

        public bool Insertar(DB_PERSONA persona)
        {
            return objcd_persona.Insertar(persona);
        }

        public bool Actualizar(DB_PERSONA persona)
        {
            return objcd_persona.Actualizar(persona);
        }

        public bool Eliminar(string codPer)
        {
            return objcd_persona.Eliminar(codPer);
        }
    }
}
