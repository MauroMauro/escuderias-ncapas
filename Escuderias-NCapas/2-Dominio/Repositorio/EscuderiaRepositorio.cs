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
    }
}
