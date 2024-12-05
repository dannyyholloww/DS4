using System;
using System.Web.UI;
using Parcial_3_app.Models;



public partial class Articulo : Page
{
    private DatabaseHelper dbHelper = new DatabaseHelper();

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        var articulo = new Articulo
        {
            Titulo = txtTitulo.Text,
            PalabrasClave = txtPalabrasClave.Text,
            FechaPublicacion = DateTime.Parse(txtFecha.Text),
            IdAutor = 1,  // Cambiar por selección dinámica
            IdCentro = 1,
            IdRevista = 1
        };

        dbHelper.InsertarArticulo(articulo);
        Response.Redirect("Default.aspx");
    }
}
