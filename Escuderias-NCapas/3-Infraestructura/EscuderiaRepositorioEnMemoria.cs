
using _2_Dominio;
using _2_Dominio.Repositorio;

namespace _3_Infraestructura
{
    public class EscuderiaRepositorioEnMemoria : IEscuderiaRepositorio
    {
        private List<Escuderia> escuderias = new List<Escuderia>();

        public void grabar(Escuderia escuderia)
        {
            this.escuderias.Add(escuderia);
        }

        public List<Escuderia> obtenerTodos()
        {
            return this.escuderias;
        }
    }
}
