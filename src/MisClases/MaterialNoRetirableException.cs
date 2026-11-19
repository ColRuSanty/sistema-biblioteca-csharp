
public class MaterialNoRetirableException : Exception
{
    public MaterialNoRetirableException()
        : base("El material solo puede consultarse en sala")
    {
    }
}
