using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_SegmentosComerciales
    {
        public List<DB_SEG_COM> Listar()
        {
            List<DB_SEG_COM> lista = new List<DB_SEG_COM>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT * FROM DB_SEG_COM";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new DB_SEG_COM()
                        {
                            COD_SEG = reader["COD_SEG"].ToString(),
                            DES_SEG = reader["DES_SEG"].ToString(),
                            COD_SSEG = reader["COD_SSEG"].ToString(),
                            DES_SSEG = reader["DES_SSEG"].ToString(),
                            COD_USER = reader["COD_USER"].ToString(),
                            FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                        });
                    }
                }
            }

            return lista;
        }

        public bool Insertar(DB_SEG_COM segmento)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"INSERT INTO DB_SEG_COM 
                                (COD_SEG, DES_SEG, COD_SSEG, DES_SSEG, COD_USER, FEC_ABM)
                                 VALUES 
                                (@COD_SEG, @DES_SEG, @COD_SSEG, @DES_SSEG, @COD_USER, @FEC_ABM)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@COD_SEG", segmento.COD_SEG);
                cmd.Parameters.AddWithValue("@DES_SEG", segmento.DES_SEG);
                cmd.Parameters.AddWithValue("@COD_SSEG", segmento.COD_SSEG);
                cmd.Parameters.AddWithValue("@DES_SSEG", segmento.DES_SSEG);
                cmd.Parameters.AddWithValue("@COD_USER", segmento.COD_USER);
                cmd.Parameters.AddWithValue("@FEC_ABM", segmento.FEC_ABM);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool Actualizar(DB_SEG_COM segmento)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"UPDATE DB_SEG_COM SET 
                                 DES_SEG = @DES_SEG,
                                 DES_SSEG = @DES_SSEG,
                                 COD_USER = @COD_USER,
                                 FEC_ABM = @FEC_ABM
                                 WHERE COD_SEG = @COD_SEG AND COD_SSEG = @COD_SSEG";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@COD_SEG", segmento.COD_SEG);
                cmd.Parameters.AddWithValue("@DES_SEG", segmento.DES_SEG);
                cmd.Parameters.AddWithValue("@COD_SSEG", segmento.COD_SSEG);
                cmd.Parameters.AddWithValue("@DES_SSEG", segmento.DES_SSEG);
                cmd.Parameters.AddWithValue("@COD_USER", segmento.COD_USER);
                cmd.Parameters.AddWithValue("@FEC_ABM", segmento.FEC_ABM);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool Eliminar(string codSeg, string codSseg)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "DELETE FROM DB_SEG_COM WHERE COD_SEG = @COD_SEG AND COD_SSEG = @COD_SSEG";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@COD_SEG", codSeg);
                cmd.Parameters.AddWithValue("@COD_SSEG", codSseg);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
    }
}
