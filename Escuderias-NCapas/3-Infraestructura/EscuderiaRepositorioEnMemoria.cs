
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

        public void borrarEscuderia(Escuderia escuderia)
        {
            this.escuderias.Remove(escuderia);
        }

        public void actualizarEscuderia(Escuderia escuderia)
        {
            var escuderiaActual = escuderias.Find(e => e.Id() == escuderia.Id());
            var index = escuderias.IndexOf(escuderiaActual);
            escuderias[index] = escuderia;

        }

        public string nombreEscuderia()
        {
            return "Repositorio en Memoria";
        }
    }
}
