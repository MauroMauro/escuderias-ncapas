using _2_Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Aplicacion.DTO
{
    public class EscuderiaDTO
    {
        private Guid id;
        private int anioFundacion;
        private String motores;
        private String nacionalidad;
        private String nombre;


        public EscuderiaDTO
            (Guid id,
            String nombre,
            String nacionalidad,
            int anioFundacion,
            String motores
            ) 
        {
            this.id = id;
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
            this.anioFundacion = anioFundacion;
            this.motores = motores;
        }



        public Guid Id()
        {
            return this.id;
        }

        public String Nombre()
        {
            return this.nombre;
        }

        public String Nacionalidad()
        {
            return this.nacionalidad;
        }

        public int AnioFundacion()
        {
            return this.anioFundacion;
        }

        public String Motores()
        {
            return this.motores;
        }

        public String obtenerDatos()
        {
            return "La escudería " + this.nombre + ", de nacionalidad " + this.nacionalidad + " fué fundada en " + this.anioFundacion + ", utiliza motores " + this.motores;
        }

    }

    
    
}
