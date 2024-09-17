class program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el numero deseado");
        try
        {
            num = Int16.Parse(Console.ReadLine());
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("El numero introducido es grande");
            num = 1;
        }
        Console.WriteLine(num);
    }
}