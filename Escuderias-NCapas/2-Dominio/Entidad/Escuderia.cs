using _2_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dominio
{
    public class Escuderia
    {
        private Identificador id;
        private Nombre nombre;
        private Nacionalidad nacionalidad;
        private AnioFundacion anioFundacion;
        private Motores motores;

        public Escuderia(
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

        public String obtenerDatos()
        {
            return "La escudería " + this.nombre.Valor() + ", de nacionalidad " + this.nacionalidad.Valor() + " fué fundada en " + this.anioFundacion.Valor() + ", utiliza motores " + this.motores.Valor();
        }
    }
}
