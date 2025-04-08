using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_MenuSistema
    {
        private CD_MenuSistema objcd_menusistema = new CD_MenuSistema();

        public List<DB_MENU> ListarMenu()
        {
            return objcd_menusistema.ListarMenu();
        }

        public bool Insertar(DB_MENU usuario)
        {
            return objcd_menusistema.Insertar(usuario);
        }

        public bool Actualizar(DB_MENU usuario)
        {
            return objcd_menusistema.Actualizar(usuario);
        }

        public bool Eliminar(string codUsuario)
        {
            return objcd_menusistema.Eliminar(codUsuario);
        }

       

        

    }

}
