using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3OLIDTS_IvanPerez_04
{
    internal class ConexionBD
    {
       
        
            private string connectionString;

            public ConexionBD()
            {
            connectionString = "server= localhost;" +
                                "database= new_schema1;" +
                                "uid=root;" +
                                "pwd=1234;";
        }

            public MySqlConnection GetConnection()
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexion establecida");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
                return connection;
            }

            public void InsertarRegistro(string nombres, string apellidos, string telefono, string edad, string estatura, string genero)
            {
                MySqlConnection connection = GetConnection();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string insertQuery = "INSERT INTO registros (nombres, apellidos, telefono , edad, estatura, genero)" +
                                     "VALUES (@nombres, @apellidos,@telefono , @edad,@estatura , @genero)";

                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@nombres", nombres);
                            command.Parameters.AddWithValue("@apellidos", apellidos);   
                            command.Parameters.AddWithValue("@telefono", telefono);
                            command.Parameters.AddWithValue("@edad", edad);
                            command.Parameters.AddWithValue("@estatura", estatura);
                            command.Parameters.AddWithValue("@genero", genero);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Registro Exitoso");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al insertar registro: " + ex.Message);
                    }
                    finally
                    {
                        CloseConnection(connection);
                    }
                }
            }

            public void CloseConnection(MySqlConnection connection)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    MessageBox.Show("Conexion Cerrada");
                }
            }
        }
    }

