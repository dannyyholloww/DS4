using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

                    string query = "SELECT ProductName FROM [dbo].[Products]";
                    SqlCommand command = new SqlCommand(query, conexion);

                    SqlDataReader reader = command.ExecuteReader();

                    listBox1.Items.Clear();

                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["ProductName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                        MessageBox.Show("Se cerró la conexión.");
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
