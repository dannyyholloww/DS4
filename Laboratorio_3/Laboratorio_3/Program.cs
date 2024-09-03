using System;

public class CalculosMatematicos
{
    public static double Calcular(double a, double b)
    {
        return (a + b) * (a - b);
    }
}


class Program
{
    private static void Main(string[] args)
    { 

        Console.Write("Introduce pro favor el primer numero: ");
        double a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce por favor el segundo numero: ");
        double b = Convert.ToInt32(Console.ReadLine());

        double resultado =CalculosMatematicos.Calcular(a, b);

        Console.WriteLine("El resultado final de la operacion (a+b)*(a-b) es: " + resultado);
    }
☺}