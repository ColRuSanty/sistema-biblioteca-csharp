public abstract class Material
{
    private string codigo = "";
    public string Codigo
    {
        get { return codigo ; }
        set { codigo  = value; }
    }
    
    
    private string titulo = "";

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }
    
    private string autor = "";
    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }
    
    private int año;
    public int Año
    {
        get { return año; }
        set { año = value; }
    }
    
    private bool prestado;
    public bool Prestado
    {
        get { return prestado; }
        set { prestado = value; }
    }
    private List<Socio> sociosEnEspera = new List<Socio>();
    public List<Socio> SociosEnEspera
    {
        get { return sociosEnEspera; }
    }
    
    public abstract double CalcularMulta(int diasAtraso);
    public abstract bool PuedeRetirarse();
}