using _2_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dominio.Entidad
{
    internal class Escudería
    {
        private Identificador id;
        private Nombre nombre;
        private Nacionalidad nacionalidad;
        private AnioFundacion anioFundacion;
        private Motores motores;

        private Escudería(
            Guid id,
            String nombre,
            String nacionalidad,
            int anioFundacion,
            String motores
        )
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.nacionalidad = new Nacionalidad(nacionalidad);
            this.anioFundacion = new AnioFundacion(anioFundacion);
            this.motores = new Motores(motores);
        }
    }
}
