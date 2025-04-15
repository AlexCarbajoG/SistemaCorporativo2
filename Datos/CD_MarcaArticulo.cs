using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_MarcaArticulo
    {
        public List<DB_MAR_ART> Listar()
        {
            List<DB_MAR_ART> lista = new List<DB_MAR_ART>();
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM DB_MAR_ART";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DB_MAR_ART()
                            {
                                COD_MAR = reader["COD_MAR"].ToString(),
                                DES_MAR = reader["DES_MAR"].ToString(),
                                COD_USER = reader["COD_USER"].ToString(),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar marcas: " + ex.Message);
                }
            }
            return lista;
        }

        public bool Insertar(DB_MAR_ART marca)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO DB_MAR_ART 
                                     (COD_MAR, DES_MAR, COD_USER, FEC_ABM)
                                     VALUES 
                                     (@COD_MAR, @DES_MAR, @COD_USER, @FEC_ABM)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_MAR", marca.COD_MAR);
                    cmd.Parameters.AddWithValue("@DES_MAR", marca.DES_MAR);
                    cmd.Parameters.AddWithValue("@COD_USER", marca.COD_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", marca.FEC_ABM);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar marca: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Eliminar(string codMarca)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM DB_MAR_ART WHERE COD_MAR = @COD_MAR";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_MAR", codMarca);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar marca: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
