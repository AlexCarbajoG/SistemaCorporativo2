using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_PedidoCabecera
    {
        public List<HB_PED_CAB> Listar()
        {
            List<HB_PED_CAB> lista = new List<HB_PED_CAB>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM HB_PED_CAB";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new HB_PED_CAB
                            {
                                COD_LOC = reader["COD_LOC"].ToString(),
                                DOC_NRO_PED = reader["DOC_NRO_PED"].ToString(),
                                COD_CLI = reader["COD_CLI"].ToString(),
                                FEC_MOV = Convert.ToDateTime(reader["FEC_MOV"]),
                                COD_VEN = reader["COD_VEN"].ToString(),
                                NRO_RUC = reader["NRO_RUC"].ToString(),
                                DOC_REF = reader["DOC_REF"].ToString(),
                                TXT_OBSERVACION = reader["TXT_OBSERVACION"].ToString(),
                                FLG_EST_PED = Convert.ToBoolean(reader["FLG_EST_PED"]),
                                COD_USER = reader["COD_USER"].ToString(),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar pedidos cabecera: " + ex.Message);
                }
            }

            return lista;
        }


        public bool Insertar(HB_PED_CAB cabecera)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO HB_PED_CAB (
                        COD_LOC, DOC_NRO_PED, COD_CLI, FEC_MOV, COD_VEN, NRO_RUC, DOC_REF, TXT_OBSERVACION, 
                        FLG_EST_PED, COD_USER, FEC_ABM)
                        VALUES (
                        @COD_LOC, @DOC_NRO_PED, @COD_CLI, @FEC_MOV, @COD_VEN, @NRO_RUC, @DOC_REF, @TXT_OBSERVACION,
                        @FLG_EST_PED, @COD_USER, @FEC_ABM)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_LOC", cabecera.COD_LOC);
                    cmd.Parameters.AddWithValue("@DOC_NRO_PED", cabecera.DOC_NRO_PED);
                    cmd.Parameters.AddWithValue("@COD_CLI", cabecera.COD_CLI);
                    cmd.Parameters.AddWithValue("@FEC_MOV", cabecera.FEC_MOV);
                    cmd.Parameters.AddWithValue("@COD_VEN", cabecera.COD_VEN);
                    cmd.Parameters.AddWithValue("@NRO_RUC", cabecera.NRO_RUC);
                    cmd.Parameters.AddWithValue("@DOC_REF", cabecera.DOC_REF);
                    cmd.Parameters.AddWithValue("@TXT_OBSERVACION", cabecera.TXT_OBSERVACION);
                    cmd.Parameters.AddWithValue("@FLG_EST_PED", cabecera.FLG_EST_PED);
                    cmd.Parameters.AddWithValue("@COD_USER", cabecera.COD_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", cabecera.FEC_ABM);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar cabecera del pedido: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
