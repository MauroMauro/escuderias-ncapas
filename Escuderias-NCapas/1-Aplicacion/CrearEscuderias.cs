using _2_Dominio;
using _2_Dominio.Repositorio;

namespace _1_Aplicacion
{
    public class CrearEscuderias
    {
        private IEscuderiaRepositorio repositorio;

        public CrearEscuderias(IEscuderiaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(Escuderia escuderia)
        {
            this.repositorio.grabar(escuderia);
        }
    }
}
