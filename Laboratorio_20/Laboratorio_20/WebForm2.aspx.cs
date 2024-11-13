using System;

namespace Laboratorio_20
{
    public partial class MatrizDiagonal : System.Web.UI.Page
    {
        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtTamaño.Text, out n) && n > 0)
            {
                string matrizHtml = "<table border='1'>";
                for (int i = 0; i < n; i++)
                {
                    matrizHtml += "<tr>";
                    for (int j = 0; j < n; j++)
                    {
                        matrizHtml += (i + j == n - 1) ? "<td>1</td>" : "<td>0</td>";
                    }
                    matrizHtml += "</tr>";
                }
                matrizHtml += "</table>";
                lblMatriz.Text = matrizHtml;
            }
            else
            {
                lblMatriz.Text = "Por favor, ingrese un tamaño válido.";
            }
        }
    }
}
