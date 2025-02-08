using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class CD_Usuario
    {
        public List<DB_USUARIO> Listar()
        {
            List<DB_USUARIO> lista = new List<DB_USUARIO>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
                try
                {
                    string query = "select  COD_USER,DES_USER,EMAIL_USER,CLAVE_USER,FLG_EST_USER,FEC_ABM from DB_USUARIO";

                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader()) {

                        while (reader.Read()) {
                            lista.Add(new DB_USUARIO()
                            {
                               COD_USER = reader["COD_USER"].ToString(),
                               DES_USER = reader["DES_USER"].ToString(),
                               EMAIL_USER = reader["EMAIL_USER"].ToString(),
                               CLAVE_USER = reader["CLAVE_USER"].ToString(),
                               FLG_EST_USER = Convert.ToBoolean(reader["FLG_EST_USER"]),
                               FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])

                            });
                        }

                    }

                }
                catch (Exception ex) { 
                }

            return lista;
        }


    }
}
