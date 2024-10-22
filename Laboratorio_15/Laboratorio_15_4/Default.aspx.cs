using System;

namespace WebAppSum
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Leer los valores de los TextBox
            int numero1 = int.Parse(TextBox1.Text);
            int numero2 = int.Parse(TextBox2.Text);

            // Sumar los dos números
            int resultado = numero1 + numero2;

            // Mostrar el resultado en el Label
            LabelResult.Text = "El resultado de la suma es: " + resultado.ToString();
        }
    }
}
