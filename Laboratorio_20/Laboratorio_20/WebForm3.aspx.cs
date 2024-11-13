using System;

namespace Laboratorio_20
{
    public partial class FuncionalidadesLab14 : System.Web.UI.Page
    {
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado = 0;
            if (double.TryParse(txtNumero1.Text, out numero1) && double.TryParse(txtNumero2.Text, out numero2))
            {
                string operacion = ddlOperacion.SelectedValue;
                switch (operacion)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        if (numero2 != 0)
                            resultado = numero1 / numero2;
                        else
                            lblResultado.Text = "No se puede dividir entre cero.";
                        return;
                }
                lblResultado.Text = "Resultado: " + resultado;
            }
            else
            {
                lblResultado.Text = "Por favor, ingrese números válidos.";
            }
        }
    }
}
