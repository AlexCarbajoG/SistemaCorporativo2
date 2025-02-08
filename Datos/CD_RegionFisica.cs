using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CD_RegionFisica
    {
        public List<DB_REG_FIS> Listar()
        {
            List<DB_REG_FIS> lista = new List<DB_REG_FIS>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT COD_REG, DES_REG, COD_USER, FEC_ABM FROM DB_REG_FIS";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DB_REG_FIS()
                            {
                                COD_REG = Convert.ToInt16(reader["COD_REG"]),
                                DES_REG = reader["DES_REG"].ToString(),
                                COD_USER = reader["COD_USER"].ToString(),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Puedes manejar el error aquí (por ejemplo, loggear el error)
                }
            }
            return lista;
        }


        public bool Insertar(DB_REG_FIS region)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO DB_REG_FIS (COD_REG, DES_REG, COD_USER, FEC_ABM) VALUES (@COD_REG, @DES_REG, @COD_USER, @FEC_ABM)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_REG", region.COD_REG);
                    cmd.Parameters.AddWithValue("@DES_REG", region.DES_REG);
                    cmd.Parameters.AddWithValue("@COD_USER", region.COD_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", region.FEC_ABM);

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


        public bool Actualizar(DB_REG_FIS region)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "UPDATE DB_REG_FIS SET DES_REG = @DES_REG, COD_USER = @COD_USER, FEC_ABM = @FEC_ABM WHERE COD_REG = @COD_REG";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_REG", region.COD_REG);
                    cmd.Parameters.AddWithValue("@DES_REG", region.DES_REG);
                    cmd.Parameters.AddWithValue("@COD_USER", region.COD_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", region.FEC_ABM);

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

        public bool Eliminar(short codRegion)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM DB_REG_FIS WHERE COD_REG = @COD_REG";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_REG", codRegion);

                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0; // Retorna true si se eliminó un registro
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar: " + ex.Message);
                    return false;
                }
            }
        }




    }
}
