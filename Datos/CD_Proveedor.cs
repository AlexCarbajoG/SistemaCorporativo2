using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_Proveedor
    {
        public List<DB_PROVEEDOR> Listar()
        {
            List<DB_PROVEEDOR> lista = new List<DB_PROVEEDOR>();
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT * FROM DB_PROVEEDOR";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new DB_PROVEEDOR()
                        {
                            COD_PRV = dr["COD_PRV"].ToString(),
                            COD_PER = dr["COD_PER"].ToString(),
                            FLG_INH_MOV = Convert.ToBoolean(dr["FLG_INH_MOV"]),
                            VAL_TIE_ATC = Convert.ToInt16(dr["VAL_TIE_ATC"]),
                            VAL_CMN_UMO = Convert.ToDecimal(dr["VAL_CMN_UMO"]),
                            COD_USER = dr["COD_USER"].ToString(),
                            FEC_ABM = Convert.ToDateTime(dr["FEC_ABM"])
                        });
                    }
                }
            }
            return lista;
        }

        public bool Insertar(DB_PROVEEDOR prov)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"INSERT INTO DB_PROVEEDOR (COD_PRV, COD_PER, FLG_INH_MOV, VAL_TIE_ATC, VAL_CMN_UMO, COD_USER, FEC_ABM)
                                 VALUES (@COD_PRV, @COD_PER, @FLG_INH_MOV, @VAL_TIE_ATC, @VAL_CMN_UMO, @COD_USER, @FEC_ABM)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@COD_PRV", prov.COD_PRV);
                cmd.Parameters.AddWithValue("@COD_PER", prov.COD_PER);
                cmd.Parameters.AddWithValue("@FLG_INH_MOV", prov.FLG_INH_MOV);
                cmd.Parameters.AddWithValue("@VAL_TIE_ATC", prov.VAL_TIE_ATC);
                cmd.Parameters.AddWithValue("@VAL_CMN_UMO", prov.VAL_CMN_UMO);
                cmd.Parameters.AddWithValue("@COD_USER", prov.COD_USER);
                cmd.Parameters.AddWithValue("@FEC_ABM", prov.FEC_ABM);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
