public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string prmtIdCorrriente) : base(prmtIdCorrriente)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine(
            "CuentaCorriente.CalcularIntereses() efectuado para " +
            "la cuenta {0}", getIdCuenta());
    }
}
