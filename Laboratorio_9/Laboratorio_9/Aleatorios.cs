using System;

class Aleatorios
{
    private Random random = new Random();

    public int GenerarNumeroEntre(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public int[] GenerarArregloDeNumeros(int cantidad, int min, int max)
    {
        int[] numeros = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            numeros[i] = random.Next(min, max + 1);
        }
        return numeros;
    }

    public int[] GenerarNumerosNoRepetidos(int cantidad, int min, int max)
    {
        if (max - min + 1 < cantidad)
        {
            throw new ArgumentException("El rango no es suficiente para generar números no repetidos.");
        }

        int[] numeros = new int[cantidad];
        int index = 0;

        while (index < cantidad)
        {
            int numero = random.Next(min, max + 1);
            if (Array.IndexOf(numeros, numero) == -1)
            {
                numeros[index] = numero;
                index++;
            }
        }

        return numeros;
    }
}
