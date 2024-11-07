using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class WebForm1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Asegúrate de que este código solo se ejecute la primera vez que se carga la página
        if (!IsPostBack)
        {
            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["ConexiónNorthwind"];
            SqlConnection conexion = new SqlConnection(connString.ConnectionString);

            using (SqlCommand cmd = new SqlCommand("SalesByCategory", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = "Seafood";

                conexion.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            GridV.DataSource = reader;
                            GridV.DataBind();
                        }
                    }
                }
            }
        }
    }
}
