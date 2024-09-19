class Persona
{
    public string Nombre;

    public int Edad;
    // Campo de cada objeto Persona que almacena Su NIF

    public string NIF;

    void Cumpleaños()
    {
        Edad++;
    }

    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }
}
