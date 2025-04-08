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
    public class CD_MenuSistema
    {
        public List<DB_MENU> ListarMenu()
        {
            List<DB_MENU> lista = new List<DB_MENU>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT COD_OPCION, DES_OPCION, FLG_EST_OPC, FEC_ABM FROM DB_MENU";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DB_MENU()
                            {
                                COD_OPCION = reader["COD_OPCION"].ToString(),
                                DES_OPCION = reader["DES_OPCION"].ToString(),
                                FLG_EST_OPC = Convert.ToBoolean(reader["FLG_EST_OPC"]),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Puedes registrar el error aquí si lo deseas
                    Console.WriteLine("Error al listar menú: " + ex.Message);
                }
            }

            return lista;
        }

        public bool Insertar(DB_MENU menu)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO DB_MENU (COD_OPCION, DES_OPCION, FLG_EST_OPC, FEC_ABM) VALUES (@COD_OPCION, @DES_OPCION, @FLG_EST_OPC, @FEC_ABM)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_OPCION", menu.COD_OPCION);
                    cmd.Parameters.AddWithValue("@DES_OPCION", menu.DES_OPCION);
                    cmd.Parameters.AddWithValue("@FLG_EST_OPC", menu.FLG_EST_OPC);
                    cmd.Parameters.AddWithValue("@FEC_ABM", menu.FEC_ABM);

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


        public bool Actualizar(DB_MENU menu)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "UPDATE DB_MENU SET DES_OPCION = @DES_OPCION, FLG_EST_OPC = @FLG_EST_OPC, FEC_ABM = @FEC_ABM WHERE COD_OPCION = @COD_OPCION";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_OPCION", menu.COD_OPCION);
                    cmd.Parameters.AddWithValue("@DES_OPCION", menu.DES_OPCION);
                    cmd.Parameters.AddWithValue("@FLG_EST_OPC", menu.FLG_EST_OPC);
                    cmd.Parameters.AddWithValue("@FEC_ABM", menu.FEC_ABM);

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


        public bool Eliminar(string codOpcion)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM DB_MENU WHERE COD_OPCION = @COD_OPCION";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_OPCION", codOpcion);

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

        








    }
}
