using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laboratorio_14
{
    public partial class formproductos : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=productos;Trusted_Connection=True;";
        bool nuevo;

        public formproductos()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void formproductos_Load(object sender, EventArgs e)
        {
            // Inicialización adicional si es necesario
        }

        private void InicializarControles()
        {
            tsbnuevo.Enabled = true;
            tsbguardar.Enabled = false;
            tsbcancelar.Enabled = false;
            tsbeliminar.Enabled = false;
            txtid.Enabled = false;
            tsbbuscar.Enabled = true;
            txtnombre.Enabled = false;
            txtprecio.Enabled = false;
            txtstock.Enabled = false;
        }

        private void GuardarProducto()
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtprecio.Text) ||
                string.IsNullOrWhiteSpace(txtstock.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sql;
                SqlCommand comando;

                if (string.IsNullOrEmpty(txtid.Text))
                {
                    sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@nombre, @precio, @stock); SELECT SCOPE_IDENTITY();";
                }
                else
                {
                    sql = "UPDATE LAPTOPS SET NOMBRE = @nombre, PRECIO = @precio, STOCK = @stock WHERE ID = @id";
                }

                comando = new SqlCommand(sql, con);
                comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@precio", txtprecio.Text);
                comando.Parameters.AddWithValue("@stock", txtstock.Text);

                if (!string.IsNullOrEmpty(txtid.Text))
                {
                    comando.Parameters.AddWithValue("@id", txtid.Text);
                }

                try
                {
                    if (string.IsNullOrEmpty(txtid.Text))
                    {
                        var newId = comando.ExecuteScalar(); // Obtener el nuevo ID
                        MessageBox.Show($"Registro guardado correctamente con ID: {newId}");
                    }
                    else
                    {
                        int i = comando.ExecuteNonQuery();
                        MessageBox.Show(i > 0 ? "Registro actualizado correctamente" : "Error al actualizar el registro");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            InicializarControles();
        }

        private void tsbnuevo_Click(object sender, EventArgs e)
        {
            tsbnuevo.Enabled = false;
            tsbguardar.Enabled = true;
            tsbcancelar.Enabled = true;
            tsbeliminar.Enabled = false;
            txtid.Enabled = false;
            tsbbuscar.Enabled = false;
            txtnombre.Enabled = true;
            txtprecio.Enabled = true;
            txtstock.Enabled = true;
            txtnombre.Focus();
            nuevo = true;
        }

        private void tsbcancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
            txtid.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            tsbid.Text = ""; // Limpiar tsbid también

            // Habilitar txtid para que se pueda ingresar un ID
            txtid.Enabled = true;
        }

        private void tsbeliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para eliminar el registro.");
                return;
            }

            // Verificar que el ID sea un número entero
            if (!int.TryParse(txtid.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            string sql = "DELETE FROM LAPTOPS WHERE ID = @id";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente!");
                        tsbcancelar_Click(sender, e); // Limpiar campos después de eliminar
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tsbbuscar_Click(object sender, EventArgs e)
        {
            // Verificar que el ID en tsbid sea un número entero
            if (!int.TryParse(tsbid.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            string sql = "SELECT * FROM LAPTOPS WHERE ID = @id";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@id", id);
                con.Open();
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tsbnuevo.Enabled = false;
                            tsbguardar.Enabled = true;
                            tsbcancelar.Enabled = true;
                            tsbeliminar.Enabled = true;
                            txtid.Text = id.ToString(); // Asigna el ID buscado a txtid
                            txtnombre.Text = reader["NOMBRE"].ToString();
                            txtprecio.Text = reader["PRECIO"].ToString();
                            txtstock.Text = reader["STOCK"].ToString();
                            nuevo = false;

                            // Habilita el campo txtid
                            txtid.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("NINGÚN REGISTRO ENCONTRADO con el Id ingresado");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbguardar_Click_1(object sender, EventArgs e)
        {
            GuardarProducto();
        }
    }
}
