using Prueba_Api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Prueba_Api.Data
{
    public class UsuarioDataAccess
    {
        public static bool InsertarUsuario(Usuarios usuario)
        {
            using (SqlConnection sConnection = new SqlConnection(Connection.connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertarUsuarios", sConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@PaisResidencia", usuario.PaisResidencia);
                    cmd.Parameters.AddWithValue("@Contacto", usuario.Contacto);

                    sConnection.Open();
                    cmd.ExecuteNonQuery();
                    sConnection.Close();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }
                finally
                {
                    sConnection.Close();
                }
            }
            
        }

        public static bool UpdateUsuario(Usuarios usuario)
        {
            using (SqlConnection sConnection = new SqlConnection(Connection.connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UpdateUsuarios", sConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@PaisResidencia", usuario.PaisResidencia);
                    cmd.Parameters.AddWithValue("@Contacto", usuario.Contacto);

                    sConnection.Open();
                    cmd.ExecuteNonQuery();
                    sConnection.Close();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }
                finally
                {
                    sConnection.Close();
                }
            }

        }

        public static bool EliminarUsuario(int id)
        {
            using (SqlConnection sConnection = new SqlConnection(Connection.connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DeleteUsuarios", sConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", id);


                    sConnection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    sConnection.Close();
                }
            }
        }


        public static List<Usuarios> GetUsuarios()
        {
            List<Usuarios> ListaUsuarios = new List<Usuarios>();
            using (SqlConnection sConnection = new SqlConnection(Connection.connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetUsuarios", sConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    sConnection.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        
                        while (dr.Read())
                        {
                            ListaUsuarios.Add(new Usuarios()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"].ToString()),
                                Telefono = Convert.ToInt32(dr["Telefono"]),
                                PaisResidencia = dr["PaisResidencia"].ToString(),
                                Contacto = Convert.ToBoolean(dr["Contacto"])
                                
                            });
                        }

                    }



                    return ListaUsuarios;
                }
                catch (Exception ex)
                {
                    return ListaUsuarios;
                }
                finally
                {
                    sConnection.Close();
                }
            }
        }

        public static List<Actividades> GetActividades()
        {
            List<Actividades> ListaActividades = new List<Actividades>();
            using (SqlConnection sConnection = new SqlConnection(Connection.connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetActividades", sConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    sConnection.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            ListaActividades.Add(new Actividades()
                            {
                                IdActividad = Convert.ToInt32(dr["IdActividad"]),
                                Actividad = dr["Actividad"].ToString(),
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                CreatedDate = Convert.ToDateTime(dr["CreatedDate"].ToString())

                            });
                        }

                    }



                    return ListaActividades;
                }
                catch (Exception ex)
                {
                    return ListaActividades;
                }
                finally
                {
                    sConnection.Close();
                }
            }
        }

    }
}
