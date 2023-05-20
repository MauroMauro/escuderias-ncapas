

using _2_Dominio;
using _2_Dominio.Repositorio;

namespace _1_Aplicacion
{
    public class ObtenerEscuderias
    {
        private IEscuderiaRepositorio repositorio;

        public ObtenerEscuderias(IEscuderiaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<Escuderia> ejecutar()
        {
            return this.repositorio.obtenerTodos();
        }
    }
}
