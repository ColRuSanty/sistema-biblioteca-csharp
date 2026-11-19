public class Audiovisual : Material, IRetirable
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
    
    private int periodoTolerancia;
    public int PeriodoTolerancia
    {
        get { return periodoTolerancia; }
        set { periodoTolerancia = value; }
    }
    
    public override double CalcularMulta(int diasAtraso)
    {
        double multa = diasAtraso * 500;
        if (diasAtraso > this.PeriodoTolerancia)
        {
            multa += 3000;
        }
        return multa;
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