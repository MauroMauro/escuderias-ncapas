using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dominio.ValueObjects
{
    internal class Motores
    {
        private String valor;

        public Motores(string valor)
        {
            this.DebeContenerMasDe4Caracteres(valor);
            this.valor = valor;
        }

        public String Valor()
        {
            return this.valor;
        }

        private void DebeContenerMasDe4Caracteres(String valor)
        {
            if (valor.Length < 4)
            {
                throw new Exception("El nombre del motor debe contener mas de cuatro caracteres");
            }
        }
    }
}
