using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class DatabaseHelper
{
    private string connectionString = "Server=DESKTOP-V42SQS6\\SQLEXPRESS;Database=BaseBibliografica;Trusted_Connection=True;";

    public List<Articulo> ObtenerArticulos()
    {
        var articulos = new List<Articulo>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Articulos";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                articulos.Add(new Articulo
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Titulo = reader["Titulo"].ToString(),
                    PalabrasClave = reader["PalabrasClave"].ToString(),
                    FechaPublicacion = Convert.ToDateTime(reader["FechaPublicacion"]),
                    IdAutor = Convert.ToInt32(reader["IdAutor"]),
                    IdCentro = Convert.ToInt32(reader["IdCentro"]),
                    IdRevista = Convert.ToInt32(reader["IdRevista"])
                });
            }
        }
        return articulos;
    }

    public void InsertarArticulo(Articulo articulo)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Articulos (Titulo, PalabrasClave, FechaPublicacion, IdAutor, IdCentro, IdRevista) VALUES (@Titulo, @PalabrasClave, @FechaPublicacion, @IdAutor, @IdCentro, @IdRevista)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Titulo", articulo.Titulo);
            cmd.Parameters.AddWithValue("@PalabrasClave", articulo.PalabrasClave);
            cmd.Parameters.AddWithValue("@FechaPublicacion", articulo.FechaPublicacion);
            cmd.Parameters.AddWithValue("@IdAutor", articulo.IdAutor);
            cmd.Parameters.AddWithValue("@IdCentro", articulo.IdCentro);
            cmd.Parameters.AddWithValue("@IdRevista", articulo.IdRevista);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
