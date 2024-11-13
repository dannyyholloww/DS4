using System;

namespace Laboratorio_20
{
    public partial class TablaMultiplicar : System.Web.UI.Page
    {
        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(txtNumero.Text, out numero))
            {
                string resultado = "";
                for (int i = 1; i <= 25; i++)
                {
                    resultado += $"{numero} x {i} = {numero * i}<br />";
                }
                lblResultado.Text = resultado;
            }
            else
            {
                lblResultado.Text = "Por favor, ingrese un número válido.";
            }
        }
    }
}
