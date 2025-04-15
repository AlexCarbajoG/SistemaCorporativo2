using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_PedidoDetalle
    {
        public List<HB_PED_DET> Listar()
        {
            List<HB_PED_DET> lista = new List<HB_PED_DET>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT * FROM HB_PED_DET";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new HB_PED_DET()
                        {
                            DOC_NRO_PED = dr["DOC_NRO_PED"].ToString(),
                            NRO_LINEA = Convert.ToInt16(dr["NRO_LINEA"]),
                            COD_ART = dr["COD_ART"].ToString(),
                            FEC_ENT_MER = Convert.ToDateTime(dr["FEC_ENT_MER"]),
                            VAL_VTA_UND = Convert.ToDecimal(dr["VAL_VTA_UND"]),
                            VAL_BONV_UND = Convert.ToDecimal(dr["VAL_BONV_UND"]),
                            VAL_MON_UMO = Convert.ToDecimal(dr["VAL_MON_UMO"]),
                            VAL_CVT_UMO = Convert.ToDecimal(dr["VAL_CVT_UMO"]),
                            VAL_IVA_UMO = Convert.ToDecimal(dr["VAL_IVA_UMO"]),
                            VAL_ENT_UND = Convert.ToDecimal(dr["VAL_ENT_UND"]),
                            VAL_SAL_UND = Convert.ToDecimal(dr["VAL_SAL_UND"]),
                            COD_USER = dr["COD_USER"].ToString(),
                            FEC_ABM = Convert.ToDateTime(dr["FEC_ABM"])
                        });
                    }
                }
            }
            return lista;
        }

        public bool Insertar(HB_PED_DET det)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"INSERT INTO HB_PED_DET (
                                DOC_NRO_PED, NRO_LINEA, COD_ART, FEC_ENT_MER,
                                VAL_VTA_UND, VAL_BONV_UND, VAL_MON_UMO, VAL_CVT_UMO,
                                VAL_IVA_UMO, VAL_ENT_UND, VAL_SAL_UND, COD_USER, FEC_ABM)
                              VALUES (
                                @DOC_NRO_PED, @NRO_LINEA, @COD_ART, @FEC_ENT_MER,
                                @VAL_VTA_UND, @VAL_BONV_UND, @VAL_MON_UMO, @VAL_CVT_UMO,
                                @VAL_IVA_UMO, @VAL_ENT_UND, @VAL_SAL_UND, @COD_USER, @FEC_ABM)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DOC_NRO_PED", det.DOC_NRO_PED);
                cmd.Parameters.AddWithValue("@NRO_LINEA", det.NRO_LINEA);
                cmd.Parameters.AddWithValue("@COD_ART", det.COD_ART);
                cmd.Parameters.AddWithValue("@FEC_ENT_MER", det.FEC_ENT_MER);
                cmd.Parameters.AddWithValue("@VAL_VTA_UND", det.VAL_VTA_UND);
                cmd.Parameters.AddWithValue("@VAL_BONV_UND", det.VAL_BONV_UND);
                cmd.Parameters.AddWithValue("@VAL_MON_UMO", det.VAL_MON_UMO);
                cmd.Parameters.AddWithValue("@VAL_CVT_UMO", det.VAL_CVT_UMO);
                cmd.Parameters.AddWithValue("@VAL_IVA_UMO", det.VAL_IVA_UMO);
                cmd.Parameters.AddWithValue("@VAL_ENT_UND", det.VAL_ENT_UND);
                cmd.Parameters.AddWithValue("@VAL_SAL_UND", det.VAL_SAL_UND);
                cmd.Parameters.AddWithValue("@COD_USER", det.COD_USER);
                cmd.Parameters.AddWithValue("@FEC_ABM", det.FEC_ABM);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
