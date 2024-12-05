using System;

public class Articulo
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string PalabrasClave { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public int IdAutor { get; set; }
    public int IdCentro { get; set; }
    public int IdRevista { get; set; }
}
