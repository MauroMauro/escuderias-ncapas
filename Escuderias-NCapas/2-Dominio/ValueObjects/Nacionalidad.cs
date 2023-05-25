using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dominio.ValueObjects
{
    public class Nacionalidad
    {
        private String valor;

        public Nacionalidad(String valor)
        {
            this.DebeContenerMasDe3Caracteres(valor);
            this.valor = valor;
        }

        public String Valor()
        {
            return this.valor;
        }

        private void DebeContenerMasDe3Caracteres(String valor)
        {
            if (valor.Length < 3)
            {
                throw new Exception("La nacionalidad debe contener mas de tres caracteres");
            }
        }
    }
}
