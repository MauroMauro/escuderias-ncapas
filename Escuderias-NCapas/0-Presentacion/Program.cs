

using _1_Aplicacion;
using _1_Aplicacion.DTO;
using _2_Dominio;
using _3_Infraestructura;





EscuderiaDTO ferrari = new EscuderiaDTO(
    Guid.NewGuid(),
    "Ferrari",
    "Italiana",
    1929,
    "Ferrari"
);

EscuderiaDTO mcClaren = new EscuderiaDTO(
    Guid.NewGuid(),
    "MacClaren",
    "Britanica",
    1963,
    "Mercedes"
);

EscuderiaDTO redBull = new EscuderiaDTO(
    Guid.NewGuid(),
    "Red Bull",
    "Austríaca",
    2005,
    "Honda"
);

//EscuderiaRepositorioEnMemoria escuderiaRepositorio = new EscuderiaRepositorioEnMemoria();
EscuderiaRepositorioSqlServer escuderiaRepositorio = new EscuderiaRepositorioSqlServer();


CrearEscuderias creadorDeEscuderias = new CrearEscuderias(escuderiaRepositorio);



creadorDeEscuderias.ejecutar(ferrari);
creadorDeEscuderias.ejecutar(mcClaren);
creadorDeEscuderias.ejecutar(redBull);

ObtenerEscuderias obtenedorDeEscuderias = new ObtenerEscuderias(
    escuderiaRepositorio
);

List<EscuderiaDTO> todosLasEscuderias = obtenedorDeEscuderias.ejecutar();
foreach (EscuderiaDTO escuderia in todosLasEscuderias)
{
    Console.WriteLine(escuderia.obtenerDatos());
}
