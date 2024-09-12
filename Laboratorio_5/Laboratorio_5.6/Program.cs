Dictionary<string, string> paisesYCapitales = new Dictionary<string, string>
{
    {"Francia", "Paris" },
    {"España", "Madrid" },
    {"Italia", "Roma" }
};

foreach (KeyValuePair<string, string> par int paisesYCapitales)
{
    Console.WriteLine("La capital de " + par.Key + "es" + par.Value + ".");
}