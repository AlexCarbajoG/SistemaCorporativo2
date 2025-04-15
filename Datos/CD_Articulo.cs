using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_Articulo
    {
        public List<DB_ARTICULO> Listar()
        {
            List<DB_ARTICULO> lista = new List<DB_ARTICULO>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT * FROM DB_ARTICULO";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new DB_ARTICULO()
                        {
                            COD_ART = dr["COD_ART"].ToString(),
                            COD_UNICO = dr["COD_UNICO"].ToString(),
                            COD_PADRE = dr["COD_PADRE"].ToString(),
                            DES_ART = dr["DES_ART"].ToString(),
                            COD_FABRICANTE = dr["COD_FABRICANTE"].ToString(),
                            CAR_UND_VTAP = dr["CAR_UND_VTAP"].ToString(),
                            CAR_UND_VTAS = dr["CAR_UND_VTAS"].ToString(),
                            VAL_NCOMP_VTAS = Convert.ToInt16(dr["VAL_NCOMP_VTAS"]),
                            CAR_UND_COMPACK = Convert.ToDecimal(dr["CAR_UND_COMPACK"]),
                            COD_CAT = dr["COD_CAT"].ToString(),
                            COD_LIN = dr["COD_LIN"].ToString(),
                            COD_MAR = dr["COD_MAR"].ToString(),
                            COD_PRV = dr["COD_PRV"].ToString(),
                            VAL_TAS_IVA = Convert.ToDecimal(dr["VAL_TAS_IVA"]),
                            VAL_PUM_UMO = Convert.ToDecimal(dr["VAL_PUM_UMO"]),
                            VAL_CUN_UMO = Convert.ToDecimal(dr["VAL_CUN_UMO"]),
                            VAL_SSG_ESP = Convert.ToDecimal(dr["VAL_SSG_ESP"]),
                            VAL_STK_EXP = Convert.ToDecimal(dr["VAL_STK_EXP"]),
                            VAL_VTA_MIN = Convert.ToDecimal(dr["VAL_VTA_MIN"]),
                            FLG_ORIGEN = Convert.ToBoolean(dr["FLG_ORIGEN"]),
                            FLG_VTA_LIBRE = Convert.ToBoolean(dr["FLG_VTA_LIBRE"]),
                            FLG_ART_CTR = Convert.ToBoolean(dr["FLG_ART_CTR"]),
                            FLG_ART_FRA = Convert.ToBoolean(dr["FLG_ART_FRA"]),
                            FLG_CAD_FRIO = Convert.ToBoolean(dr["FLG_CAD_FRIO"]),
                            FLG_ART_INA = Convert.ToBoolean(dr["FLG_ART_INA"]),
                            FLG_INH_VTA = Convert.ToBoolean(dr["FLG_INH_VTA"]),
                            FLG_INH_COM = Convert.ToBoolean(dr["FLG_INH_COM"]),
                            CAR_ADICIONAL = dr["CAR_ADICIONAL"].ToString(),
                            COD_USER = dr["COD_USER"].ToString(),
                            FEC_ABM = Convert.ToDateTime(dr["FEC_ABM"])
                        });
                    }
                }
            }
            return lista;
        }

        public bool Insertar(DB_ARTICULO art)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO DB_ARTICULO (
                        COD_ART, COD_UNICO, COD_PADRE, DES_ART, COD_FABRICANTE,
                        CAR_UND_VTAP, CAR_UND_VTAS, VAL_NCOMP_VTAS, CAR_UND_COMPACK,
                        COD_CAT, COD_LIN, COD_MAR, COD_PRV, VAL_TAS_IVA, VAL_PUM_UMO,
                        VAL_CUN_UMO, VAL_SSG_ESP, VAL_STK_EXP, VAL_VTA_MIN, FLG_ORIGEN,
                        FLG_VTA_LIBRE, FLG_ART_CTR, FLG_ART_FRA, FLG_CAD_FRIO, FLG_ART_INA,
                        FLG_INH_VTA, FLG_INH_COM, CAR_ADICIONAL, COD_USER, FEC_ABM)
                    VALUES (
                        @COD_ART, @COD_UNICO, @COD_PADRE, @DES_ART, @COD_FABRICANTE,
                        @CAR_UND_VTAP, @CAR_UND_VTAS, @VAL_NCOMP_VTAS, @CAR_UND_COMPACK,
                        @COD_CAT, @COD_LIN, @COD_MAR, @COD_PRV, @VAL_TAS_IVA, @VAL_PUM_UMO,
                        @VAL_CUN_UMO, @VAL_SSG_ESP, @VAL_STK_EXP, @VAL_VTA_MIN, @FLG_ORIGEN,
                        @FLG_VTA_LIBRE, @FLG_ART_CTR, @FLG_ART_FRA, @FLG_CAD_FRIO, @FLG_ART_INA,
                        @FLG_INH_VTA, @FLG_INH_COM, @CAR_ADICIONAL, @COD_USER, @FEC_ABM)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_ART", art.COD_ART);
                    cmd.Parameters.AddWithValue("@COD_UNICO", art.COD_UNICO);
                    cmd.Parameters.AddWithValue("@COD_PADRE", art.COD_PADRE);
                    cmd.Parameters.AddWithValue("@DES_ART", art.DES_ART);
                    cmd.Parameters.AddWithValue("@COD_FABRICANTE", art.COD_FABRICANTE);
                    cmd.Parameters.AddWithValue("@CAR_UND_VTAP", art.CAR_UND_VTAP);
                    cmd.Parameters.AddWithValue("@CAR_UND_VTAS", art.CAR_UND_VTAS);
                    cmd.Parameters.AddWithValue("@VAL_NCOMP_VTAS", art.VAL_NCOMP_VTAS);
                    cmd.Parameters.AddWithValue("@CAR_UND_COMPACK", art.CAR_UND_COMPACK);
                    cmd.Parameters.AddWithValue("@COD_CAT", art.COD_CAT);
                    cmd.Parameters.AddWithValue("@COD_LIN", art.COD_LIN);
                    cmd.Parameters.AddWithValue("@COD_MAR", art.COD_MAR);
                    cmd.Parameters.AddWithValue("@COD_PRV", art.COD_PRV);
                    cmd.Parameters.AddWithValue("@VAL_TAS_IVA", art.VAL_TAS_IVA);
                    cmd.Parameters.AddWithValue("@VAL_PUM_UMO", art.VAL_PUM_UMO);
                    cmd.Parameters.AddWithValue("@VAL_CUN_UMO", art.VAL_CUN_UMO);
                    cmd.Parameters.AddWithValue("@VAL_SSG_ESP", art.VAL_SSG_ESP);
                    cmd.Parameters.AddWithValue("@VAL_STK_EXP", art.VAL_STK_EXP);
                    cmd.Parameters.AddWithValue("@VAL_VTA_MIN", art.VAL_VTA_MIN);
                    cmd.Parameters.AddWithValue("@FLG_ORIGEN", art.FLG_ORIGEN);
                    cmd.Parameters.AddWithValue("@FLG_VTA_LIBRE", art.FLG_VTA_LIBRE);
                    cmd.Parameters.AddWithValue("@FLG_ART_CTR", art.FLG_ART_CTR);
                    cmd.Parameters.AddWithValue("@FLG_ART_FRA", art.FLG_ART_FRA);
                    cmd.Parameters.AddWithValue("@FLG_CAD_FRIO", art.FLG_CAD_FRIO);
                    cmd.Parameters.AddWithValue("@FLG_ART_INA", art.FLG_ART_INA);
                    cmd.Parameters.AddWithValue("@FLG_INH_VTA", art.FLG_INH_VTA);
                    cmd.Parameters.AddWithValue("@FLG_INH_COM", art.FLG_INH_COM);
                    cmd.Parameters.AddWithValue("@CAR_ADICIONAL", art.CAR_ADICIONAL);
                    cmd.Parameters.AddWithValue("@COD_USER", art.COD_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", art.FEC_ABM);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar artículo: " + ex.Message);
                    return false;
                }
            }
        }
    }






}

