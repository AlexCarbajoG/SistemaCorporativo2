using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_FamiliaArticulo
    {
        public List<DB_FMA_ART> Listar()
        {
            List<DB_FMA_ART> lista = new List<DB_FMA_ART>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT * FROM DB_FMA_ART";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new DB_FMA_ART
                    {
                        COD_CAT = dr["COD_CAT"].ToString(),
                        DES_CAT = dr["DES_CAT"].ToString(),
                        COD_LIN = dr["COD_LIN"].ToString(),
                        DES_LIN = dr["DES_LIN"].ToString(),
                        COD_USER = dr["COD_USER"].ToString(),
                        FEC_ABM = Convert.ToDateTime(dr["FEC_ABM"])
                    });
                }
            }

            return lista;
        }

        public bool Insertar(DB_FMA_ART fam)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"INSERT INTO DB_FMA_ART 
                        (COD_CAT, DES_CAT, COD_LIN, DES_LIN, COD_USER, FEC_ABM)
                        VALUES (@COD_CAT, @DES_CAT, @COD_LIN, @DES_LIN, @COD_USER, @FEC_ABM)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@COD_CAT", fam.COD_CAT);
                cmd.Parameters.AddWithValue("@DES_CAT", fam.DES_CAT);
                cmd.Parameters.AddWithValue("@COD_LIN", fam.COD_LIN);
                cmd.Parameters.AddWithValue("@DES_LIN", fam.DES_LIN);
                cmd.Parameters.AddWithValue("@COD_USER", fam.COD_USER);
                cmd.Parameters.AddWithValue("@FEC_ABM", fam.FEC_ABM);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
