using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dominio.ValueObjects
{
    public class Nombre
    {
        private String valor;

        public Nombre(string valor)
        {
            this.DebeContenerMasde4caracteres(valor);
            this.valor = valor;
        }

        public String Valor()
        {
            return this.valor;
        }

        private void DebeContenerMasde4caracteres(String valor)
        {
            if (valor.Length < 4)
            {
                throw new Exception("El nombre tiene menos de cuatro caracteres");
            }
        }
    }
}
