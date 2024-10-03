using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Por favor escriba  un numero (Debe ser impar): ");
        int N = int.Parse(Console.ReadLine());


        if (N % 2 == 0)
        {
            Console.WriteLine("Incorrecto,el numero que escribio es par");
        }

        int[,] matriz = new int[N, N];
        Random random = new Random();

        
        for (int i = 0; i < N; i++)
        {
            matriz[i, i] = random.Next(1, 101); 
            matriz[i, N - 1 - i] = random.Next(1, 101); 
        }

      
        Console.WriteLine("\nMatriz:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        
        int sumaDeLaDiagonaPrincipal = 0;
        int sumaDeLaDiagonalInversa = 0;

        for (int i = 0; i < N; i++)
        {
            sumaDeLaDiagonaPrincipal += matriz[i, i];
            sumaDeLaDiagonalInversa += matriz[i, N - 1 - i];
        }


        Console.WriteLine("\nSuma de la diagonal principal: " + sumaDeLaDiagonaPrincipal);
        Console.WriteLine("\nSuma de la diagonal inversa: " + sumaDeLaDiagonalInversa);
    }
}