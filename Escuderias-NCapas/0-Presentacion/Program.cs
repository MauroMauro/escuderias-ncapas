

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

Escuderia mcClaren = new Escuderia(
    Guid.NewGuid(),
    "MacClaren",
    "Britanica",
    1963,
    "Mercedes"
);

EscuderiaRepositorioEnMemoria escuderiaRepositorio = new EscuderiaRepositorioEnMemoria();

CrearEscuderias creadorDeEscuderias = new CrearEscuderias(
    escuderiaRepositorio
);

creadorDeEscuderias.ejecutar(ferrari);
creadorDeEscuderias.ejecutar(mcClaren);

ObtenerEscuderias obtenedorDeEscuderias = new ObtenerEscuderias(
    escuderiaRepositorio
);

List<Escuderia> todosLasEscuderias = obtenedorDeEscuderias.ejecutar();
foreach (Escuderia escuderia in todosLasEscuderias)
{
    Console.WriteLine(escuderia.obtenerDatos());
}
