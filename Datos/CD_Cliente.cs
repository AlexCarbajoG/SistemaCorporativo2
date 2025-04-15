using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_Cliente
    {
        public List<DB_CLIENTE> Listar()
        {
            List<DB_CLIENTE> lista = new List<DB_CLIENTE>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT * FROM DB_CLIENTE";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new DB_CLIENTE()
                        {
                            COD_CLI = reader["COD_CLI"].ToString(),
                            COD_PER = reader["COD_PER"].ToString(),
                            COD_GRP_EMP = reader["COD_GRP_EMP"].ToString(),
                            COD_VEN = reader["COD_VEN"].ToString(),
                            COD_SEG = reader["COD_SEG"].ToString(),
                            COD_SSEG = reader["COD_SSEG"].ToString(),
                            FLG_INH_MOV = Convert.ToBoolean(reader["FLG_INH_MOV"]),
                            FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                        });
                    }
                }
            }

            return lista;
        }

        public bool Insertar(DB_CLIENTE cliente)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"INSERT INTO DB_CLIENTE 
                                (COD_CLI, COD_PER, COD_GRP_EMP, COD_VEN, COD_SEG, COD_SSEG, FLG_INH_MOV, FEC_ABM)
                                VALUES (@COD_CLI, @COD_PER, @COD_GRP_EMP, @COD_VEN, @COD_SEG, @COD_SSEG, @FLG_INH_MOV, @FEC_ABM)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@COD_CLI", cliente.COD_CLI);
                cmd.Parameters.AddWithValue("@COD_PER", cliente.COD_PER);
                cmd.Parameters.AddWithValue("@COD_GRP_EMP", cliente.COD_GRP_EMP ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@COD_VEN", cliente.COD_VEN);
                cmd.Parameters.AddWithValue("@COD_SEG", cliente.COD_SEG);
                cmd.Parameters.AddWithValue("@COD_SSEG", cliente.COD_SSEG);
                cmd.Parameters.AddWithValue("@FLG_INH_MOV", cliente.FLG_INH_MOV);
                cmd.Parameters.AddWithValue("@FEC_ABM", cliente.FEC_ABM);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
