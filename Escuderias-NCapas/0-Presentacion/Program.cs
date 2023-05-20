

using _1_Aplicacion;
using _2_Dominio;
using _3_Infraestructura;




Escuderia ferrari = new Escuderia(
    Guid.NewGuid(),
    "Ferrari",
    "Italiana",
    1929,
    "Ferrari"
);

EscuderiaRepositorioEnMemoria escuderiaRepositorio = new EscuderiaRepositorioEnMemoria();

CrearEscuderias creadorDeEscuderias = new CrearEscuderias(
    escuderiaRepositorio
);

creadorDeEscuderias.ejecutar(ferrari);

ObtenerEscuderias obtenedorDeEscuderias = new ObtenerEscuderias(
    escuderiaRepositorio
);

List<Escuderia> todosLasEscuderias = obtenedorDeEscuderias.ejecutar();
foreach (Escuderia escuderia in todosLasEscuderias)
{
    Console.WriteLine(escuderia.obtenerDatos());
}
