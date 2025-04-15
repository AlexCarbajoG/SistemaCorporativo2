using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CD_Vendedor
    {
        public List<DB_VENDEDOR> Listar()
        {
            List<DB_VENDEDOR> lista = new List<DB_VENDEDOR>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM DB_VENDEDOR";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DB_VENDEDOR()
                            {
                                COD_VEN = reader["COD_VEN"].ToString(),
                                COD_TRA = reader["COD_TRA"].ToString(),
                                FLG_INH_MOV = Convert.ToBoolean(reader["FLG_INH_MOV"]),
                                FEC_ABM = Convert.ToDateTime(reader["FEC_ABM"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al listar vendedores: " + ex.Message);
                }
            }

            return lista;
        }

        public bool Insertar(DB_VENDEDOR vendedor)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO DB_VENDEDOR 
                                    (COD_VEN, COD_TRA, FLG_INH_MOV, FEC_ABM)
                                     VALUES (@COD_VEN, @COD_TRA, @FLG_INH_MOV, @FEC_ABM)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@COD_VEN", vendedor.COD_VEN);
                    cmd.Parameters.AddWithValue("@COD_TRA", vendedor.COD_TRA);
                    cmd.Parameters.AddWithValue("@FLG_INH_MOV", vendedor.FLG_INH_MOV);
                    cmd.Parameters.AddWithValue("@FEC_ABM", vendedor.FEC_ABM);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar vendedor: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Actualizar(DB_VENDEDOR vendedor)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"UPDATE DB_VENDEDOR 
                                     SET COD_TRA = @COD_TRA, FLG_INH_MOV = @FLG_INH_MOV, FEC_ABM = @FEC_ABM 
                                     WHERE COD_VEN = @COD_VEN";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@COD_VEN", vendedor.COD_VEN);
                    cmd.Parameters.AddWithValue("@COD_TRA", vendedor.COD_TRA);
                    cmd.Parameters.AddWithValue("@FLG_INH_MOV", vendedor.FLG_INH_MOV);
                    cmd.Parameters.AddWithValue("@FEC_ABM", vendedor.FEC_ABM);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar vendedor: " + ex.Message);
                    return false;
                }
            }
        }

        public bool Eliminar(string codVendedor)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM DB_VENDEDOR WHERE COD_VEN = @COD_VEN";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@COD_VEN", codVendedor);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar vendedor: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
