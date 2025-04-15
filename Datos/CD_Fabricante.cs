using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_Fabricante
    {
        public List<DB_FABRICANTE> Listar()
        {
            List<DB_FABRICANTE> lista = new List<DB_FABRICANTE>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM DB_FABRICANTE";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DB_FABRICANTE()
                            {
                                COD_FABRICANTE = reader["COD_FABRICANTE"].ToString(),
                                COD_PER = reader["COD_PER"].ToString(),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar fabricantes: " + ex.Message);
                }
            }

            return lista;
        }

        public bool Insertar(DB_FABRICANTE fab)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO DB_FABRICANTE 
                                     (COD_FABRICANTE, COD_PER, FEC_ABM)
                                     VALUES (@COD_FABRICANTE, @COD_PER, @FEC_ABM)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_FABRICANTE", fab.COD_FABRICANTE);
                    cmd.Parameters.AddWithValue("@COD_PER", fab.COD_PER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", fab.FEC_ABM);
                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar fabricante: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Eliminar(string codFabricante)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM DB_FABRICANTE WHERE COD_FABRICANTE = @COD_FABRICANTE";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_FABRICANTE", codFabricante);
                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar fabricante: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
