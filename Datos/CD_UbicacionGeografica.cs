using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_UbicacionGeografica
    {
        public List<DB_UBI_GEO> Listar()
        {
            List<DB_UBI_GEO> lista = new List<DB_UBI_GEO>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM DB_UBI_GEO";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DB_UBI_GEO()
                            {
                                COD_PAIS = reader["COD_PAIS"].ToString(),
                                DES_PAIS = reader["DES_PAIS"].ToString(),
                                COD_DPTO = Convert.ToInt16(reader["COD_DPTO"]),
                                DES_DPTO = reader["DES_DPTO"].ToString(),
                                COD_CIU = Convert.ToInt16(reader["COD_CIU"]),
                                DES_CIU = reader["DES_CIU"].ToString(),
                                COD_BARR = Convert.ToInt16(reader["COD_BARR"]),
                                DES_BARR = reader["DES_BARR"].ToString(),
                                CAR_IDIOMA = reader["CAR_IDIOMA"].ToString(),
                                DES_CON = reader["DES_CON"].ToString(),
                                COD_REG = Convert.ToInt16(reader["COD_REG"]),
                                UBI_LATITUD = reader["UBI_LATITUD"].ToString(),
                                UBI_LONGITUD = reader["UBI_LONGITUD"].ToString(),
                                COD_USER = reader["COD_USER"].ToString(),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar: " + ex.Message);
                }
            }

            return lista;
        }

        public bool Insertar(DB_UBI_GEO ubi)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO DB_UBI_GEO
                    (COD_PAIS, DES_PAIS, COD_DPTO, DES_DPTO, COD_CIU, DES_CIU, COD_BARR, DES_BARR,
                     CAR_IDIOMA, DES_CON, COD_REG, UBI_LATITUD, UBI_LONGITUD, COD_USER, FEC_ABM)
                    VALUES
                    (@COD_PAIS, @DES_PAIS, @COD_DPTO, @DES_DPTO, @COD_CIU, @DES_CIU, @COD_BARR, @DES_BARR,
                     @CAR_IDIOMA, @DES_CON, @COD_REG, @UBI_LATITUD, @UBI_LONGITUD, @COD_USER, @FEC_ABM)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@COD_PAIS", ubi.COD_PAIS);
                    cmd.Parameters.AddWithValue("@DES_PAIS", ubi.DES_PAIS);
                    cmd.Parameters.AddWithValue("@COD_DPTO", ubi.COD_DPTO);
                    cmd.Parameters.AddWithValue("@DES_DPTO", ubi.DES_DPTO);
                    cmd.Parameters.AddWithValue("@COD_CIU", ubi.COD_CIU);
                    cmd.Parameters.AddWithValue("@DES_CIU", ubi.DES_CIU);
                    cmd.Parameters.AddWithValue("@COD_BARR", ubi.COD_BARR);
                    cmd.Parameters.AddWithValue("@DES_BARR", ubi.DES_BARR);
                    cmd.Parameters.AddWithValue("@CAR_IDIOMA", ubi.CAR_IDIOMA);
                    cmd.Parameters.AddWithValue("@DES_CON", ubi.DES_CON);
                    cmd.Parameters.AddWithValue("@COD_REG", ubi.COD_REG);
                    cmd.Parameters.AddWithValue("@UBI_LATITUD", ubi.UBI_LATITUD);
                    cmd.Parameters.AddWithValue("@UBI_LONGITUD", ubi.UBI_LONGITUD);
                    cmd.Parameters.AddWithValue("@COD_USER", ubi.COD_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", ubi.FEC_ABM);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Actualizar(DB_UBI_GEO ubi)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"UPDATE DB_UBI_GEO SET 
                        DES_PAIS = @DES_PAIS, DES_DPTO = @DES_DPTO, DES_CIU = @DES_CIU, 
                        DES_BARR = @DES_BARR, CAR_IDIOMA = @CAR_IDIOMA, DES_CON = @DES_CON, 
                        COD_REG = @COD_REG, UBI_LATITUD = @UBI_LATITUD, UBI_LONGITUD = @UBI_LONGITUD, 
                        COD_USER = @COD_USER, FEC_ABM = @FEC_ABM
                        WHERE COD_PAIS = @COD_PAIS AND COD_DPTO = @COD_DPTO AND COD_CIU = @COD_CIU AND COD_BARR = @COD_BARR";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@DES_PAIS", ubi.DES_PAIS);
                    cmd.Parameters.AddWithValue("@DES_DPTO", ubi.DES_DPTO);
                    cmd.Parameters.AddWithValue("@DES_CIU", ubi.DES_CIU);
                    cmd.Parameters.AddWithValue("@DES_BARR", ubi.DES_BARR);
                    cmd.Parameters.AddWithValue("@CAR_IDIOMA", ubi.CAR_IDIOMA);
                    cmd.Parameters.AddWithValue("@DES_CON", ubi.DES_CON);
                    cmd.Parameters.AddWithValue("@COD_REG", ubi.COD_REG);
                    cmd.Parameters.AddWithValue("@UBI_LATITUD", ubi.UBI_LATITUD);
                    cmd.Parameters.AddWithValue("@UBI_LONGITUD", ubi.UBI_LONGITUD);
                    cmd.Parameters.AddWithValue("@COD_USER", ubi.COD_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", ubi.FEC_ABM);

                    cmd.Parameters.AddWithValue("@COD_PAIS", ubi.COD_PAIS);
                    cmd.Parameters.AddWithValue("@COD_DPTO", ubi.COD_DPTO);
                    cmd.Parameters.AddWithValue("@COD_CIU", ubi.COD_CIU);
                    cmd.Parameters.AddWithValue("@COD_BARR", ubi.COD_BARR);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Eliminar(string codPais, short codDpto, short codCiu, short codBarr)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"DELETE FROM DB_UBI_GEO 
                                     WHERE COD_PAIS = @COD_PAIS AND COD_DPTO = @COD_DPTO 
                                     AND COD_CIU = @COD_CIU AND COD_BARR = @COD_BARR";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_PAIS", codPais);
                    cmd.Parameters.AddWithValue("@COD_DPTO", codDpto);
                    cmd.Parameters.AddWithValue("@COD_CIU", codCiu);
                    cmd.Parameters.AddWithValue("@COD_BARR", codBarr);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar: " + ex.Message);
                    return false;
                }
            }
        }

        public DB_USUARIO ObtenerPrimerUsuario()
        {
            DB_USUARIO usuario = null;

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT TOP 1 COD_USER, NOM_USER, PASS_USER, FLG_EST_USU, FEC_ABM FROM DB_USUARIO ORDER BY FEC_ABM ASC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new DB_USUARIO()
                            {
                                COD_USER = reader["COD_USER"].ToString(),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener usuario: " + ex.Message);
                }
            }

            return usuario;
        }


    }
}
