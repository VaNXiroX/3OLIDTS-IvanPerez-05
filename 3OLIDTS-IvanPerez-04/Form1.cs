using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MySql.Data.MySqlClient;

namespace _3OLIDTS_IvanPerez_04
{
   
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }

        private bool EsEntervalido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsDecimalvalido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnterovalidode10digitos(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado)&& valor.Length ==10;
        }
       
        private bool EsTextovalido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telefono = tbTelefono.Text;



            if (EsEntervalido(edad) && EsDecimalvalido(estatura) && EsEnterovalidode10digitos(telefono) && EsTextovalido(nombres) && EsTextovalido(apellidos))
            {
                string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono. {telefono}\r\nEstatura: {estatura}cm\r\nedad: {edad} años\r\n";


                string rutaArchivo = "C:\\Users\\pedri\\OneDrive\\Documentos\\DATOS.txt";
                bool archivoExiste = File.Exists(rutaArchivo);
                if (archivoExiste == false)
                {
                    File.WriteAllText(rutaArchivo, datos);
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    {

                        if (archivoExiste)
                        {
                            writer.WriteLine();

                        }
                        writer.WriteLine(datos);

                    }

                }
                MessageBox.Show("datos guardados con exito:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("por favor,ingrese datos validos en los campos.", "error,", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            string genero = "  ";

            if (Hombre.Checked)
            {
                genero = "hombre";

            }
            else if (Mujer.Checked)
            {
                genero = "Mujer";
            }
            else if (Helicoptero_Apache.Checked)
            {
                genero = "helicoptero apache";


            }
         

        }


        private void button2_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            Hombre.Checked = false;
            Mujer.Checked = false;
        }

      

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        internal class ConexionBD
        {
            private string connectionString;

            public ConexionBD()
            {
                connectionString = "server= PROMAVANZADA;" +
                                    "database= world;" +
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

            public void InsertarRegistro(string nombres, string apellidos, string telefono, int edad, decimal estatura, string genero)
            {
                MySqlConnection connection = GetConnection();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string insertQuery = "INSERT INTO registros (nombres, apellidos, edad, estatura, telefono, genero)" +
                                     "VALUES (@Nombre, @Apellidos, @Edad, @Estatura, @Telefono, @Genero)";

                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", nombres);
                            command.Parameters.AddWithValue("@Apellidos", apellidos);
                            command.Parameters.AddWithValue("@Telefono", telefono);
                            command.Parameters.AddWithValue("@Edad", edad);
                            command.Parameters.AddWithValue("@Estatura", estatura);
                            command.Parameters.AddWithValue("@Genero", genero);

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
}
