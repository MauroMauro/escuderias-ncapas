using _1_Aplicacion.DTO;
using _2_Dominio.Repositorio;
using _2_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Aplicacion
{
    public class ActualizarEscuderia
    {
        private IEscuderiaRepositorio repositorio;

        public ActualizarEscuderia(IEscuderiaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(EscuderiaDTO escuderia)
        {
            this.repositorio.actualizarEscuderia(new Escuderia(escuderia.Id(), escuderia.Nombre(), escuderia.Nacionalidad(), escuderia.AnioFundacion(), escuderia.Motores()));
        }
    }
}
