Libro unLibro = new Libro();
unLibro.Autor = "Jorge Luis Borges";
unLibro.Año = 2000;
unLibro.DiasMaximos = 7;
unLibro.DescripcionSoporte = "Un libro";
unLibro.Codigo = "01";
unLibro.Titulo = "Un comienzo";
Console.WriteLine(unLibro.ObtenerDiasMaximos());
Console.WriteLine(unLibro.DescribirSoporte());
Audiovisual unAudiovisual = new Audiovisual();
unAudiovisual.Autor = "Perez";
unAudiovisual.Año = 2010;
unAudiovisual.DiasMaximos = 16;
unAudiovisual.DescripcionSoporte = "Un audiovisual";
unAudiovisual.PeriodoTolerancia = 8;
unAudiovisual.Codigo = "02";
unAudiovisual.Titulo = "Algo increible";
Console.WriteLine(unAudiovisual.ObtenerDiasMaximos());
Console.WriteLine(unAudiovisual.DescribirSoporte());
Revista unaRevista = new Revista();
unaRevista.Autor = "Mario";
unaRevista.Año = 1998;
unaRevista.Codigo = "03";
unaRevista.Titulo = "La mejor revista";

Socio unSocio = new Socio();
unSocio.Nombre = "Manuel";
unSocio.Numero = 20203094;



Socio otroSocio = new Socio();
otroSocio.Nombre = "Raul";
otroSocio.Numero = 7945867;



Socio socioAudiovisual = new Socio();
socioAudiovisual.Nombre = "Ezequiel";
socioAudiovisual.Numero = 7968432;




Socio unSocioMas = new Socio();
unSocioMas.Nombre = "Martin";
unSocioMas.Numero = 3439054;


Revista otraRevista = new Revista();
otraRevista.Autor = "Dario";
otraRevista.Año = 2010;
otraRevista.Codigo = "03";
otraRevista.Titulo = "La revista duplicada";

Socio otroSocioMas = new Socio();
otroSocioMas.Nombre = "Juan";
otroSocioMas.Numero = 9586956;



Biblioteca biblioteca = new Biblioteca();
biblioteca.RegistrarMaterial(unLibro);
biblioteca.RegistrarMaterial(unAudiovisual);
biblioteca.RegistrarMaterial(unaRevista);
biblioteca.RegistrarMaterial(otraRevista);
Material? materialEncontrado = biblioteca.BuscarMaterial("01");

if (materialEncontrado != null)
{
    Console.WriteLine($"Material encontrado: {materialEncontrado.Titulo}");
}
else
{
    Console.WriteLine("Material no encontrado");
}
try
{
    biblioteca.PedirRetiro(unaRevista, unSocioMas);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
biblioteca.PedirRetiro(unLibro, otroSocioMas);

Prestamo prestamoLibro = biblioteca.Prestamos[biblioteca.Prestamos.Count - 1];

biblioteca.PedirRetiro(unAudiovisual, unSocio);

Prestamo prestamoAudiovisual = biblioteca.Prestamos[biblioteca.Prestamos.Count - 1];


biblioteca.PedirRetiro(unAudiovisual, otroSocio);
biblioteca.PedirRetiro(unAudiovisual, socioAudiovisual);
biblioteca.PedirRetiro(unAudiovisual, unSocioMas);



biblioteca.RegistrarDevolucion(prestamoAudiovisual, 20);
biblioteca.RegistrarDevolucion(prestamoLibro, 2);


Console.WriteLine($"Total multas: {biblioteca.CalcularTotalMultas()}");
Console.WriteLine($"Promedio de días de atraso: {biblioteca.CalcularPromedioDiasAtraso()}");
