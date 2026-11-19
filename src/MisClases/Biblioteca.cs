public class Biblioteca
{
    private Dictionary<string, Material> materiales = new Dictionary<string, Material>();
    public Dictionary<string, Material> Materiales
    {
        get { return materiales; }
    }
    private List<Prestamo> prestamos = new List<Prestamo>();
    public List<Prestamo> Prestamos
    {
        get { return prestamos; }
    }
    

    public void RegistrarMaterial(Material material)
    {
        if (!this.Materiales.ContainsKey(material.Codigo))
        {
            this.Materiales.Add(material.Codigo, material);
        }
        else
        {
            Console.WriteLine("No se puede repetir codigo inventario");
        }
    }
    public Material? BuscarMaterial(string codigo)
    {
        if (this.Materiales.ContainsKey(codigo))
        {
            return this.Materiales[codigo];
        }

        return null;
    }

    public void PedirRetiro(Material material, Socio socio)
    {
        
        if (!material.PuedeRetirarse())
        {
            throw new MaterialNoRetirableException();
        }


        if (material.Prestado == true)
        {
            material.SociosEnEspera.Add(socio);

            Console.WriteLine($"{socio.Nombre} fue agregado a la lista de espera");
        }
        else
        {
            Prestamo prestamo = new Prestamo(material, socio);
            prestamo.DiasAtraso = 0;
            prestamo.Devuelto = false;

            this.Prestamos.Add(prestamo);
            material.Prestado = true;
        }
    }
    public void RegistrarDevolucion(Prestamo prestamo, int diasAtraso)
    {
        if (prestamo.Devuelto == true)
        {
            throw new Exception("Este prestamo ya fue devuelto");
        }

        if (diasAtraso < 0)
        {
            throw new Exception("Los dias de atraso no pueden ser negativos");
        }
        prestamo.DiasAtraso = diasAtraso;
        prestamo.Devuelto = true;
        prestamo.Material.Prestado = false;

        Console.WriteLine($"multa: {prestamo.CalcularMulta()}");

        if (prestamo.Material.SociosEnEspera.Count > 0)
        {
            Socio primerSocio = prestamo.Material.SociosEnEspera[0];

            prestamo.Material.SociosEnEspera.RemoveAt(0);

            Console.WriteLine($"El material corresponde a {primerSocio.Nombre}");

            this.PedirRetiro(prestamo.Material,primerSocio);
        }
        else
        {
            Console.WriteLine("No hay socios en la lista de espera");
        }
    }
    public double CalcularTotalMultas()
    {
        double total = 0;

        foreach (Prestamo prestamo in this.Prestamos)
        {
            if (prestamo.Devuelto == true)
            {
                total += prestamo.CalcularMulta();
            }
        }

        return total;
    }
    public double CalcularPromedioDiasAtraso()
    {
        double totalDias = 0;
        int cantidadPrestamos = 0;

        foreach (Prestamo prestamo in this.Prestamos)
        {
            if (prestamo.Devuelto == true && prestamo.DiasAtraso > 0)
            {
                totalDias += prestamo.DiasAtraso;
                cantidadPrestamos++;
            }
        }

        if (cantidadPrestamos == 0)
        {
            return 0;
        }

        return totalDias / cantidadPrestamos;
    }

    public void ConsultarMateriales()
    {
        foreach (var material in this.Materiales)
        {
            Console.WriteLine($"Codigo: {material.Key}, titulo: {material.Value.Titulo}");
        }
    }
}