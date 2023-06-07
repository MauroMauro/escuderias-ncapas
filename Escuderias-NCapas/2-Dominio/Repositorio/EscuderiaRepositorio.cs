using _2_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dominio.Repositorio
{
    public interface IEscuderiaRepositorio
    {
        public List<Escuderia> obtenerTodos();
        public void grabar(Escuderia escuderia);

        public void borrarEscuderia(Escuderia escuderia);
    }
}
