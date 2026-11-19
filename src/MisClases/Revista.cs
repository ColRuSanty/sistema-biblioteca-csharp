public class Revista : Material
{
    public override double CalcularMulta(int diasAtraso)
    {
        return diasAtraso * 100;
    }

    public override bool PuedeRetirarse()
    {
        return false;
    }
}