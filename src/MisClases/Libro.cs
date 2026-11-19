public class Libro : Material, IRetirable
{
    private int diasMaximos;
    public int DiasMaximos
    {
        get { return diasMaximos; }
        set { diasMaximos = value; }
    }

    private string descripcionSoporte = "";
    public string DescripcionSoporte
    {
        get { return descripcionSoporte; }
        set { descripcionSoporte = value; }
    }
    
    
    public override double CalcularMulta(int diasAtraso)
    {
        return diasAtraso * 200;
    }

    public string DescribirSoporte()
    {
        return this.DescripcionSoporte;
    }

    public int ObtenerDiasMaximos()
    {
        return this.DiasMaximos;
    }

    public override bool PuedeRetirarse()
    {
        return true;
    }
}