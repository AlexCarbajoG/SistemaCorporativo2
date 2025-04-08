using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_Acceso
    {
        public List<DB_ACCESO> ListarAcceso()
        {
            List<DB_ACCESO> lista = new List<DB_ACCESO>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT COD_USER, COD_OPCION, COD_ALM, FLG_EST_ACC, FEC_ABM FROM DB_ACCESO";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DB_ACCESO
                            {
                                COD_USER = reader["COD_USER"].ToString(),
                                COD_OPCION = reader["COD_OPCION"].ToString(),
                                COD_ALM = reader["COD_ALM"].ToString(),
                                FLG_EST_ACC = Convert.ToBoolean(reader["FLG_EST_ACC"]),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar accesos: " + ex.Message);
                }
            }

            return lista;
        }



        public bool Insertar(DB_ACCESO acceso)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    con.Open();

                    // Obtener automáticamente el COD_OPCION asociado al COD_USER (el primero)
                    string queryGetOpcion = "SELECT TOP 1 COD_OPCION FROM DB_MENU WHERE COD_OPCION IN (SELECT COD_OPCION FROM DB_ACCESO WHERE COD_USER = @COD_USER)";
                    using (SqlCommand cmdGetOpcion = new SqlCommand(queryGetOpcion, con))
                    {
                        cmdGetOpcion.Parameters.AddWithValue("@COD_USER", acceso.COD_USER);
                        object result = cmdGetOpcion.ExecuteScalar();
                        if (result == null)
                        {
                            Console.WriteLine("No se encontró COD_OPCION para el usuario.");
                            return false;
                        }
                        acceso.COD_OPCION = result.ToString();
                    }

                    // Validar que COD_OPCION existe en DB_MENU
                    string queryVerificar = "SELECT COUNT(1) FROM DB_MENU WHERE COD_OPCION = @COD_OPCION";
                    using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, con))
                    {
                        cmdVerificar.Parameters.AddWithValue("@COD_OPCION", acceso.COD_OPCION);
                        int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                        if (existe == 0)
                        {
                            return false;
                        }
                    }

                    // Insertar el nuevo acceso
                    string queryInsertar = @"
                INSERT INTO DB_ACCESO (COD_USER, COD_ALM, COD_OPCION, FLG_EST_ACC, FEC_ABM) 
                VALUES (@COD_USER, @COD_ALM, @COD_OPCION, @FLG_EST_ACC, @FEC_ABM)";
                    using (SqlCommand cmdInsertar = new SqlCommand(queryInsertar, con))
                    {
                        cmdInsertar.Parameters.AddWithValue("@COD_USER", acceso.COD_USER);
                        cmdInsertar.Parameters.AddWithValue("@COD_ALM", acceso.COD_ALM);
                        cmdInsertar.Parameters.AddWithValue("@COD_OPCION", acceso.COD_OPCION);
                        cmdInsertar.Parameters.AddWithValue("@FLG_EST_ACC", acceso.FLG_EST_ACC);
                        cmdInsertar.Parameters.AddWithValue("@FEC_ABM", acceso.FEC_ABM);

                        int filasAfectadas = cmdInsertar.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar acceso: " + ex.Message);
                    return false;
                }
            }
        }












    }
}
