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
    public class CD_Locacion
    {
        public List<DB_LOCACION> Listar()
        {
            List<DB_LOCACION> lista = new List<DB_LOCACION>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM DB_LOCACION";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DB_LOCACION()
                            {
                                FLG_DEP_CEN = Convert.ToBoolean(reader["FLG_DEP_CEN"]),
                                COD_LOC = reader["COD_LOC"].ToString(),
                                DES_LOC = reader["DES_LOC"].ToString(),
                                FEC_CREA = Convert.ToDateTime(reader["FEC_CREA"]),
                                DES_NOM_ENC = reader["DES_NOM_ENC"].ToString(),
                                FLG_LOC_VIR = Convert.ToBoolean(reader["FLG_LOC_VIR"]),
                                COD_PAIS = reader["COD_PAIS"].ToString(),
                                COD_DPTO = Convert.ToInt16(reader["COD_DPTO"]),
                                COD_CIU = Convert.ToInt16(reader["COD_CIU"]),
                                COD_BARR = Convert.ToInt16(reader["COD_BARR"]),
                                DES_DIR_LOC = reader["DES_DIR_LOC"].ToString(),
                                VAL_ZLOC_ALT = Convert.ToDecimal(reader["VAL_ZLOC_ALT"]),
                                VAL_ZLOC_SUP = Convert.ToDecimal(reader["VAL_ZLOC_SUP"]),
                                VAL_COB_ESP = Convert.ToInt16(reader["VAL_COB_ESP"]),
                                COD_USER = reader["COD_USER"].ToString(),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar locaciones: " + ex.Message);
                }
            }

            return lista;
        }

        public bool Insertar(DB_LOCACION loc)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO DB_LOCACION 
                    (FLG_DEP_CEN, COD_LOC, DES_LOC, FEC_CREA, DES_NOM_ENC, FLG_LOC_VIR, 
                     COD_PAIS, COD_DPTO, COD_CIU, COD_BARR, DES_DIR_LOC, VAL_ZLOC_ALT, VAL_ZLOC_SUP, 
                     VAL_COB_ESP, COD_USER, FEC_ABM)
                     VALUES 
                    (@FLG_DEP_CEN, @COD_LOC, @DES_LOC, @FEC_CREA, @DES_NOM_ENC, @FLG_LOC_VIR, 
                     @COD_PAIS, @COD_DPTO, @COD_CIU, @COD_BARR, @DES_DIR_LOC, @VAL_ZLOC_ALT, @VAL_ZLOC_SUP, 
                     @VAL_COB_ESP, @COD_USER, @FEC_ABM)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FLG_DEP_CEN", loc.FLG_DEP_CEN);
                    cmd.Parameters.AddWithValue("@COD_LOC", loc.COD_LOC);
                    cmd.Parameters.AddWithValue("@DES_LOC", loc.DES_LOC);
                    cmd.Parameters.AddWithValue("@FEC_CREA", loc.FEC_CREA);
                    cmd.Parameters.AddWithValue("@DES_NOM_ENC", loc.DES_NOM_ENC);
                    cmd.Parameters.AddWithValue("@FLG_LOC_VIR", loc.FLG_LOC_VIR);
                    cmd.Parameters.AddWithValue("@COD_PAIS", loc.COD_PAIS);
                    cmd.Parameters.AddWithValue("@COD_DPTO", loc.COD_DPTO);
                    cmd.Parameters.AddWithValue("@COD_CIU", loc.COD_CIU);
                    cmd.Parameters.AddWithValue("@COD_BARR", loc.COD_BARR);
                    cmd.Parameters.AddWithValue("@DES_DIR_LOC", loc.DES_DIR_LOC);
                    cmd.Parameters.AddWithValue("@VAL_ZLOC_ALT", loc.VAL_ZLOC_ALT);
                    cmd.Parameters.AddWithValue("@VAL_ZLOC_SUP", loc.VAL_ZLOC_SUP);
                    cmd.Parameters.AddWithValue("@VAL_COB_ESP", loc.VAL_COB_ESP);
                    cmd.Parameters.AddWithValue("@COD_USER", loc.COD_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", loc.FEC_ABM);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar locación: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Actualizar(DB_LOCACION loc)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"UPDATE DB_LOCACION SET 
                        FLG_DEP_CEN = @FLG_DEP_CEN,
                        DES_LOC = @DES_LOC,
                        FEC_CREA = @FEC_CREA,
                        DES_NOM_ENC = @DES_NOM_ENC,
                        FLG_LOC_VIR = @FLG_LOC_VIR,
                        COD_PAIS = @COD_PAIS,
                        COD_DPTO = @COD_DPTO,
                        COD_CIU = @COD_CIU,
                        COD_BARR = @COD_BARR,
                        DES_DIR_LOC = @DES_DIR_LOC,
                        VAL_ZLOC_ALT = @VAL_ZLOC_ALT,
                        VAL_ZLOC_SUP = @VAL_ZLOC_SUP,
                        VAL_COB_ESP = @VAL_COB_ESP,
                        COD_USER = @COD_USER,
                        FEC_ABM = @FEC_ABM
                    WHERE COD_LOC = @COD_LOC";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FLG_DEP_CEN", loc.FLG_DEP_CEN);
                    cmd.Parameters.AddWithValue("@COD_LOC", loc.COD_LOC);
                    cmd.Parameters.AddWithValue("@DES_LOC", loc.DES_LOC);
                    cmd.Parameters.AddWithValue("@FEC_CREA", loc.FEC_CREA);
                    cmd.Parameters.AddWithValue("@DES_NOM_ENC", loc.DES_NOM_ENC);
                    cmd.Parameters.AddWithValue("@FLG_LOC_VIR", loc.FLG_LOC_VIR);
                    cmd.Parameters.AddWithValue("@COD_PAIS", loc.COD_PAIS);
                    cmd.Parameters.AddWithValue("@COD_DPTO", loc.COD_DPTO);
                    cmd.Parameters.AddWithValue("@COD_CIU", loc.COD_CIU);
                    cmd.Parameters.AddWithValue("@COD_BARR", loc.COD_BARR);
                    cmd.Parameters.AddWithValue("@DES_DIR_LOC", loc.DES_DIR_LOC);
                    cmd.Parameters.AddWithValue("@VAL_ZLOC_ALT", loc.VAL_ZLOC_ALT);
                    cmd.Parameters.AddWithValue("@VAL_ZLOC_SUP", loc.VAL_ZLOC_SUP);
                    cmd.Parameters.AddWithValue("@VAL_COB_ESP", loc.VAL_COB_ESP);
                    cmd.Parameters.AddWithValue("@COD_USER", loc.COD_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", loc.FEC_ABM);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar locación: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Eliminar(string codLoc)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM DB_LOCACION WHERE COD_LOC = @COD_LOC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_LOC", codLoc);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar locación: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
