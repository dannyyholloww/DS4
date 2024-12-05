using System;
using System.Web.UI;
using Parcial_3_app.Models;


public partial class Default : Page
{
    private DatabaseHelper dbHelper = new DatabaseHelper();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gvArticulos.DataSource = dbHelper.ObtenerArticulos();
            gvArticulos.DataBind();
        }
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Articulos.aspx");
    }
}
