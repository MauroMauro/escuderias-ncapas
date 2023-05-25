

using _1_Aplicacion.DTO;
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

        public List<EscuderiaDTO> ejecutar()
        {
            List<Escuderia> escuderias = this.repositorio.obtenerTodos();
            List<EscuderiaDTO> escuderiasDTO = new List<EscuderiaDTO>();

            foreach (Escuderia escuderia in escuderias)
            {
                EscuderiaDTO escuderiaDTO = new EscuderiaDTO(escuderia.Id(), escuderia.Nombre(), escuderia.Nacionalidad(), escuderia.AnioFundacion(), escuderia.Motores());
                escuderiasDTO.Add(escuderiaDTO);
            } 
            return escuderiasDTO;
        }
    }
}
