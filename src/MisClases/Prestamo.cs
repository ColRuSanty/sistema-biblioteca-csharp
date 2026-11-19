public class Prestamo
{
    private Material material;
    public Material Material
    {
        get { return material; }
        set { material = value; }
    }
    private Socio socio;
    public Socio Socio
    {
        get { return socio; }
        set { socio = value; }
    }
    private int diasAtraso;
    public int DiasAtraso
    {
        get { return diasAtraso; }
        set { diasAtraso = value; }
    }
    private bool devuelto;
    public bool Devuelto
    {
        get { return devuelto; }
        set { devuelto = value; }
    }

    
    public Prestamo(Material material, Socio socio)
    {
        this.material = material;
        this.socio = socio;
    }


    public double CalcularMulta()
    {
        return this.Material.CalcularMulta(this.DiasAtraso);
    }
}