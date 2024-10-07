namespace Laboratorio_12.2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void promedio_btn_Click(object sender, EventArgs e)
        {
            double promedio_uno = double.Parse(nota_uno_box.Text);
            double promedio_dos = double.Parse(nota_dos_box.Text);
            double promedio_tres = double.Parse(nota_tres_box.Text);

            CalcularPromedio calcular = new CalcularPromedio();
            double resultado = calcular.CalcularPromedioTotal(promedio_uno, promedio_dos, promedio_tres);
            resultado_box.Text = resultado.ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultado_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrar_btn_Click(object sender, EventArgs e)
        {
            nota_uno_box.Text = string.Empty;
            nota_dos_box.Text = string.Empty;
            nota_tres_box.Text = string.Empty;
            resultado_box.Text = string.Empty;
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}