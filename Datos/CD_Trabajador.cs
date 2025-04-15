using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_Trabajador
    {
        public List<DB_TRABAJADOR> Listar()
        {
            List<DB_TRABAJADOR> lista = new List<DB_TRABAJADOR>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT * FROM DB_TRABAJADOR";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new DB_TRABAJADOR
                        {
                            COD_TRA = reader["COD_TRA"].ToString(),
                            COD_PER = reader["COD_PER"].ToString(),
                            FLG_INH_MOV = Convert.ToBoolean(reader["FLG_INH_MOV"]),
                            FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                        });
                    }
                }
            }

            return lista;
        }

        public bool Insertar(DB_TRABAJADOR trabajador)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"INSERT INTO DB_TRABAJADOR (COD_TRA, COD_PER, FLG_INH_MOV, FEC_ABM)
                                 VALUES (@COD_TRA, @COD_PER, @FLG_INH_MOV, @FEC_ABM)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@COD_TRA", trabajador.COD_TRA);
                cmd.Parameters.AddWithValue("@COD_PER", trabajador.COD_PER);
                cmd.Parameters.AddWithValue("@FLG_INH_MOV", trabajador.FLG_INH_MOV);
                cmd.Parameters.AddWithValue("@FEC_ABM", trabajador.FEC_ABM);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool Actualizar(DB_TRABAJADOR trabajador)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"UPDATE DB_TRABAJADOR 
                                 SET COD_PER = @COD_PER, FLG_INH_MOV = @FLG_INH_MOV, FEC_ABM = @FEC_ABM 
                                 WHERE COD_TRA = @COD_TRA";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@COD_TRA", trabajador.COD_TRA);
                cmd.Parameters.AddWithValue("@COD_PER", trabajador.COD_PER);
                cmd.Parameters.AddWithValue("@FLG_INH_MOV", trabajador.FLG_INH_MOV);
                cmd.Parameters.AddWithValue("@FEC_ABM", trabajador.FEC_ABM);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool Eliminar(string codTra)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "DELETE FROM DB_TRABAJADOR WHERE COD_TRA = @COD_TRA";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@COD_TRA", codTra);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
    }

}
