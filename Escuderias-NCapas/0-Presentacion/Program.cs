using _1_Aplicacion;
using _1_Aplicacion.DTO;
using _2_Dominio;
using _2_Dominio.Repositorio;
using _3_Infraestructura;

IEscuderiaRepositorio repositorioActual = new EscuderiaRepositorioEnMemoria();
CrearEscuderias creadorDeEscuderias = new CrearEscuderias(repositorioActual);
ObtenerEscuderias obtenedorDeEscuderias = new ObtenerEscuderias(repositorioActual);
BorrarEscuderia borradorDeEscuderias = new BorrarEscuderia(repositorioActual);
ActualizarEscuderia actualizadorDeEscuderias = new ActualizarEscuderia(repositorioActual);
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

while (true)
{
    int opcionElegida = menu();
    switch(opcionElegida)
    {
        case 1: anadirEscuderia(); break;
        case 2: eliminarEscuderia(); break;
        case 3: actualizarPrimeraEscuderia(); break;
        case 4: listarEscuderias(); break;
        case 5: elegirRepositorio(); break;
        default: Console.WriteLine("Opcion no Valida");break;
    }
    Console.ReadKey();
    Console.Clear();
}

void elegirRepositorio()
{
    int opcion = 0;
    Console.WriteLine("Ingrese una Opción: ");
    Console.WriteLine("Opcion 1: Repositorio en Memoria");
    Console.WriteLine("Opcion 2: Repositorio en SQL Server");
    Console.WriteLine("Opcion 3: Repositorio en MongoDB");
    Console.WriteLine("Ingresar Opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());
    do
    {
        switch (opcion)
        {
            case 1: 
                repositorioActual = new EscuderiaRepositorioEnMemoria();
                break;
            case 2:
                repositorioActual = new EscuderiaRepositorioSqlServer();
                break;
            case 3:
                repositorioActual = new EscuderiaRepositorioMongoDB();
                break;
        }
    } while (opcion <= 0 && opcion >= 4);
    creadorDeEscuderias = new CrearEscuderias(repositorioActual);
    obtenedorDeEscuderias = new ObtenerEscuderias(repositorioActual);
    borradorDeEscuderias = new BorrarEscuderia(repositorioActual);
    actualizadorDeEscuderias = new ActualizarEscuderia(repositorioActual);
}

int menu()
{
    int opcion = 0;
    Console.WriteLine("Repositorio Actual: " + repositorioActual.nombreEscuderia());
    Console.WriteLine("Ingrese una Opción: ");
    Console.WriteLine("Opcion 1: Agregar una Escuderia al Azar");
    Console.WriteLine("Opcion 2: Eliminar una Escuderia al Azar");
    Console.WriteLine("Opcion 3: Actualizar la primera Escuderia en la lista");
    Console.WriteLine("Opcion 4: Listar todas las Escuderias");
    Console.WriteLine("Opcion 5: Cambiar de Repositorio");
    Console.WriteLine("Ingresar Opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());
    return opcion;
}

void anadirEscuderia()
{
    Random rnd = new Random();
    int numeroRandom = rnd.Next(1, 4);
    switch(numeroRandom)
    {
        case 1: creadorDeEscuderias.ejecutar(ferrari);break;
        case 2: creadorDeEscuderias.ejecutar(mcClaren); break;
        case 3: creadorDeEscuderias.ejecutar(redBull); break;
    }
}

void listarEscuderias()
{
    Console.WriteLine("Listado de Escuderias: ");
    List<EscuderiaDTO> todasLasEscuderias = obtenedorDeEscuderias.ejecutar();
    foreach (EscuderiaDTO escuderia in todasLasEscuderias)
    {
        Console.WriteLine(escuderia.obtenerDatos());
    }
}

void eliminarEscuderia()
{
    List<EscuderiaDTO> todasLasEscuderias = obtenedorDeEscuderias.ejecutar();
    Random rnd = new Random();
    int numeroRandom = rnd.Next(1, todasLasEscuderias.Count());
    borradorDeEscuderias.ejecutar(todasLasEscuderias[numeroRandom]);
}

void actualizarPrimeraEscuderia()
{
    List<EscuderiaDTO> todasLasEscuderias = obtenedorDeEscuderias.ejecutar();
    var escuderiaAActualizar = todasLasEscuderias.First();
    EscuderiaDTO escuderiaActualizada = new EscuderiaDTO(
       escuderiaAActualizar.Id(),
       escuderiaAActualizar.Nombre(),
       escuderiaAActualizar.Nacionalidad(),
       1950,
       "Chevrolet"
    );
    actualizadorDeEscuderias.ejecutar(escuderiaActualizada);
}
