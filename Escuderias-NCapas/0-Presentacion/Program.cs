

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
//EscuderiaRepositorioSqlServer escuderiaRepositorio = new EscuderiaRepositorioSqlServer();
EscuderiaRepositorioMongoDB escuderiaRepositorio = new EscuderiaRepositorioMongoDB();

CrearEscuderias creadorDeEscuderias = new CrearEscuderias(escuderiaRepositorio);



creadorDeEscuderias.ejecutar(ferrari);
creadorDeEscuderias.ejecutar(mcClaren);
creadorDeEscuderias.ejecutar(redBull);

ObtenerEscuderias obtenedorDeEscuderias = new ObtenerEscuderias(
    escuderiaRepositorio
);

List<EscuderiaDTO> todasLasEscuderias = obtenedorDeEscuderias.ejecutar();
foreach (EscuderiaDTO escuderia in todasLasEscuderias)
{
    Console.WriteLine(escuderia.obtenerDatos());
}

Console.WriteLine("\nBorrar Escuderia: " + redBull.obtenerDatos());

BorrarEscuderia borrar = new BorrarEscuderia(escuderiaRepositorio);
borrar.ejecutar(redBull);

todasLasEscuderias = obtenedorDeEscuderias.ejecutar();
foreach (EscuderiaDTO escuderia in todasLasEscuderias)
{
    Console.WriteLine(escuderia.obtenerDatos());
}

ActualizarEscuderia actualizadorDeEscuderias = new ActualizarEscuderia(escuderiaRepositorio);


var escuderiaAActualizar = todasLasEscuderias.First();

EscuderiaDTO escuderiaActualizada = new EscuderiaDTO(
   escuderiaAActualizar.Id(),
   escuderiaAActualizar.Nombre(),
   escuderiaAActualizar.Nacionalidad(),
   1950,
   "Chevrolet"
);

actualizadorDeEscuderias.ejecutar(escuderiaActualizada);

Console.WriteLine("datos despues de la actualizacón");


todasLasEscuderias = obtenedorDeEscuderias.ejecutar();
foreach (EscuderiaDTO escuderia in todasLasEscuderias)
{
    Console.WriteLine(escuderia.obtenerDatos());
}

