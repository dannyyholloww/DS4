using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el lado 1 del triángulo: ");
        int lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el lado 2 del triángulo: ");
        int lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el lado 3 del triángulo: ");
        int lado3 = int.Parse(Console.ReadLine());

        if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("No es un triángulo válido.");
        }
    }
}


