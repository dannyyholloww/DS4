using System;

public class CalculosMatematicos
{
  
    public static int Perimetro(int a, int b)
    {
        return  2 * (a+b);
    }
}


class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la altura del rectangulo: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la base del rectangulo: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int resultado = CalculosMatematicos.Perimetro(a, b);

        Console.WriteLine("El perimetro del rectangulo es : " +  resultado);

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}