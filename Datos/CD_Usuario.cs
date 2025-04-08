using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class CD_Usuario
    {
        public List<DB_USUARIO> Listar()
        {
            List<DB_USUARIO> lista = new List<DB_USUARIO>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
                try
                {
                    string query = "select  COD_USER,DES_USER,EMAIL_USER,CLAVE_USER,FLG_EST_USER,FEC_ABM from DB_USUARIO";

                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader()) {

                        while (reader.Read()) {
                            lista.Add(new DB_USUARIO()
                            {
                               COD_USER = reader["COD_USER"].ToString(),
                               DES_USER = reader["DES_USER"].ToString(),
                               EMAIL_USER = reader["EMAIL_USER"].ToString(),
                               CLAVE_USER = reader["CLAVE_USER"].ToString(),
                               FLG_EST_USER = Convert.ToBoolean(reader["FLG_EST_USER"]),
                               FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])

                            });
                        }

                    }

                }
                catch (Exception ex) { 
                }

            return lista;
        }


        public DB_USUARIO ObtenerPrimerUsuario()
        {
            DB_USUARIO usuario = null;
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT TOP 1 COD_USER, DES_USER FROM DB_USUARIO ORDER BY FEC_ABM DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new DB_USUARIO()
                            {
                                COD_USER = reader["COD_USER"].ToString(),
                                DES_USER = reader["DES_USER"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {   
                }
            }
            return usuario;
        }

        public bool Insertar(DB_USUARIO usuario)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO DB_USUARIO (COD_USER, DES_USER, EMAIL_USER, CLAVE_USER, FLG_EST_USER, FEC_ABM) VALUES (@COD_USER, @DES_USER, @EMAIL_USER, @CLAVE_USER, @FLG_EST_USER, @FEC_ABM)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_USER", usuario.COD_USER);
                    cmd.Parameters.AddWithValue("@DES_USER", usuario.DES_USER);
                    cmd.Parameters.AddWithValue("@EMAIL_USER", usuario.EMAIL_USER);
                    cmd.Parameters.AddWithValue("@CLAVE_USER", usuario.CLAVE_USER);
                    cmd.Parameters.AddWithValue("@FLG_EST_USER", usuario.FLG_EST_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", usuario.FEC_ABM);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar usuario: " + ex.Message);
                    return false;
                }
            }
        }


        public bool Actualizar(DB_USUARIO usuario)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "UPDATE DB_USUARIO SET DES_USER = @DES_USER, EMAIL_USER = @EMAIL_USER, CLAVE_USER = @CLAVE_USER, FLG_EST_USER = @FLG_EST_USER, FEC_ABM = @FEC_ABM WHERE COD_USER = @COD_USER";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_USER", usuario.COD_USER);
                    cmd.Parameters.AddWithValue("@DES_USER", usuario.DES_USER);
                    cmd.Parameters.AddWithValue("@EMAIL_USER", usuario.EMAIL_USER);
                    cmd.Parameters.AddWithValue("@CLAVE_USER", usuario.CLAVE_USER);
                    cmd.Parameters.AddWithValue("@FLG_EST_USER", usuario.FLG_EST_USER);
                    cmd.Parameters.AddWithValue("@FEC_ABM", usuario.FEC_ABM);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar usuario: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Eliminar(string codUser)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM DB_USUARIO WHERE COD_USER = @COD_USER";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@COD_USER", codUser);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar usuario: " + ex.Message);
                    return false;
                }
            }
        }





















    }





}
