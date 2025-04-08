 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;


namespace Negocio
{
    public class N_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<DB_USUARIO> Listar()
        {
            return objcd_usuario.Listar();
        }

        public bool Insertar(DB_USUARIO usuario)
        {
            return objcd_usuario.Insertar(usuario);
        }

        public bool Actualizar(DB_USUARIO usuario)
        {
            return objcd_usuario.Actualizar(usuario);
        }

        public bool Eliminar(string codUsuario)
        {
            return objcd_usuario.Eliminar(codUsuario);
        }


        public DB_USUARIO ObtenerPrimerUsuario()
        {
            return objcd_usuario.ObtenerPrimerUsuario();
        }

    }
}
