using System;

namespace Laboratorio2
{ 
    class Program
    {
        static void Main(String[] args)
        {
            Client client = new Client();
            // Ejemplo utilizando las varibales de instancia de Clase.
            client.FirstName  = "Danny";
            client.LastName = "Rivera";
            client.Age = 27;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

        }

    }
    public class Client
    {
        //Declarando variables de instancia en clase.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            //Utilizadno variables de instancia dentro de metodos de la clase.
            return FirstName + " " + LastName + " "+ Age + " Años";
        }
    }
}
