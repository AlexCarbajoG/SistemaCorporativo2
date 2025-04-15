using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_Persona
    {
        public List<DB_PERSONA> Listar()
        {
            List<DB_PERSONA> lista = new List<DB_PERSONA>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT * FROM DB_PERSONA";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new DB_PERSONA()
                        {
                            COD_PER = reader["COD_PER"].ToString(),
                            DES_PER = reader["DES_PER"].ToString(),
                            FLG_PER_JUR = Convert.ToBoolean(reader["FLG_PER_JUR"]),
                            FLG_SEX_PER = Convert.ToBoolean(reader["FLG_SEX_PER"]),
                            COD_PAIS = reader["COD_PAIS"].ToString(),
                            COD_DPTO = Convert.ToInt16(reader["COD_DPTO"]),
                            COD_CIU = Convert.ToInt16(reader["COD_CIU"]),
                            COD_BARR = Convert.ToInt16(reader["COD_BARR"]),
                            DES_DIR = reader["DES_DIR"].ToString(),
                            NRO_RUC = reader["NRO_RUC"].ToString(),
                            EMAIL_EMP = reader["EMAIL_EMP"].ToString(),
                            EMP_TELF1 = reader["EMP_TELF1"].ToString(),
                            EMP_TELF2 = reader["EMP_TELF2"].ToString(),
                            WWW_URL = reader["WWW_URL"].ToString(),
                            COD_USER = reader["COD_USER"].ToString(),
                            FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                        });
                    }
                }
            }

            return lista;
        }

        public bool Insertar(DB_PERSONA persona)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"INSERT INTO DB_PERSONA
                (COD_PER, DES_PER, FLG_PER_JUR, FLG_SEX_PER, COD_PAIS, COD_DPTO, COD_CIU, COD_BARR,
                 DES_DIR, NRO_RUC, EMAIL_EMP, EMP_TELF1, EMP_TELF2, WWW_URL, COD_USER, FEC_ABM)
                VALUES
                (@COD_PER, @DES_PER, @FLG_PER_JUR, @FLG_SEX_PER, @COD_PAIS, @COD_DPTO, @COD_CIU, @COD_BARR,
                 @DES_DIR, @NRO_RUC, @EMAIL_EMP, @EMP_TELF1, @EMP_TELF2, @WWW_URL, @COD_USER, @FEC_ABM)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@COD_PER", persona.COD_PER);
                cmd.Parameters.AddWithValue("@DES_PER", persona.DES_PER);
                cmd.Parameters.AddWithValue("@FLG_PER_JUR", persona.FLG_PER_JUR);
                cmd.Parameters.AddWithValue("@FLG_SEX_PER", persona.FLG_SEX_PER);
                cmd.Parameters.AddWithValue("@COD_PAIS", persona.COD_PAIS);
                cmd.Parameters.AddWithValue("@COD_DPTO", persona.COD_DPTO);
                cmd.Parameters.AddWithValue("@COD_CIU", persona.COD_CIU);
                cmd.Parameters.AddWithValue("@COD_BARR", persona.COD_BARR);
                cmd.Parameters.AddWithValue("@DES_DIR", persona.DES_DIR);
                cmd.Parameters.AddWithValue("@NRO_RUC", persona.NRO_RUC);
                cmd.Parameters.AddWithValue("@EMAIL_EMP", persona.EMAIL_EMP);
                cmd.Parameters.AddWithValue("@EMP_TELF1", persona.EMP_TELF1);
                cmd.Parameters.AddWithValue("@EMP_TELF2", persona.EMP_TELF2);
                cmd.Parameters.AddWithValue("@WWW_URL", persona.WWW_URL);
                cmd.Parameters.AddWithValue("@COD_USER", persona.COD_USER);
                cmd.Parameters.AddWithValue("@FEC_ABM", persona.FEC_ABM);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool Actualizar(DB_PERSONA persona)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"UPDATE DB_PERSONA SET 
                 DES_PER = @DES_PER, FLG_PER_JUR = @FLG_PER_JUR, FLG_SEX_PER = @FLG_SEX_PER,
                 COD_PAIS = @COD_PAIS, COD_DPTO = @COD_DPTO, COD_CIU = @COD_CIU, COD_BARR = @COD_BARR,
                 DES_DIR = @DES_DIR, NRO_RUC = @NRO_RUC, EMAIL_EMP = @EMAIL_EMP,
                 EMP_TELF1 = @EMP_TELF1, EMP_TELF2 = @EMP_TELF2, WWW_URL = @WWW_URL,
                 COD_USER = @COD_USER, FEC_ABM = @FEC_ABM
                 WHERE COD_PER = @COD_PER";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@COD_PER", persona.COD_PER);
                cmd.Parameters.AddWithValue("@DES_PER", persona.DES_PER);
                cmd.Parameters.AddWithValue("@FLG_PER_JUR", persona.FLG_PER_JUR);
                cmd.Parameters.AddWithValue("@FLG_SEX_PER", persona.FLG_SEX_PER);
                cmd.Parameters.AddWithValue("@COD_PAIS", persona.COD_PAIS);
                cmd.Parameters.AddWithValue("@COD_DPTO", persona.COD_DPTO);
                cmd.Parameters.AddWithValue("@COD_CIU", persona.COD_CIU);
                cmd.Parameters.AddWithValue("@COD_BARR", persona.COD_BARR);
                cmd.Parameters.AddWithValue("@DES_DIR", persona.DES_DIR);
                cmd.Parameters.AddWithValue("@NRO_RUC", persona.NRO_RUC);
                cmd.Parameters.AddWithValue("@EMAIL_EMP", persona.EMAIL_EMP);
                cmd.Parameters.AddWithValue("@EMP_TELF1", persona.EMP_TELF1);
                cmd.Parameters.AddWithValue("@EMP_TELF2", persona.EMP_TELF2);
                cmd.Parameters.AddWithValue("@WWW_URL", persona.WWW_URL);
                cmd.Parameters.AddWithValue("@COD_USER", persona.COD_USER);
                cmd.Parameters.AddWithValue("@FEC_ABM", persona.FEC_ABM);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool Eliminar(string codPer)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "DELETE FROM DB_PERSONA WHERE COD_PER = @COD_PER";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@COD_PER", codPer);

                con.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
    }
}
