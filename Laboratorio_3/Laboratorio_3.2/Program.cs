using System;

public class CalculosMatematicos
{
    private double radio;

    // Constructor para inicializar el radio
    public CalculosMatematicos(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }
}


class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        CalculosMatematicos circulo = new CalculosMatematicos(radio);

        double area = circulo.CalcularArea();

        Console.WriteLine($"El área del círculo con radio {radio:F2} es {area:F2}");

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}


