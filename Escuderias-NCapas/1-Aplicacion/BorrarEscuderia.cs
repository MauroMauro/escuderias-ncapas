using _1_Aplicacion.DTO;
using _2_Dominio;
using _2_Dominio.Repositorio;

namespace _1_Aplicacion
{
    public class BorrarEscuderia
    {
        private IEscuderiaRepositorio repositorio;

        public BorrarEscuderia(IEscuderiaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(EscuderiaDTO escuderia)
        {
            this.repositorio.borrarEscuderia(new Escuderia(escuderia.Id(), escuderia.Nombre(), escuderia.Nacionalidad(), escuderia.AnioFundacion(), escuderia.Motores()));
        }
    }
}
