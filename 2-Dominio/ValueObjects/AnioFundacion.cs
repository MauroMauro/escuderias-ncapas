using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dominio.ValueObjects
{
    internal class AnioFundacion
    {
        private int valor;

        public AnioFundacion(int valor)
        {
            this.DebeSerUnValorEntre1900yHoy(valor);
            this.valor = valor;
        }

        public int Valor()
        {
            return this.valor;
        }

        private void DebeSerUnValorEntre1900yHoy(int valor)
        {
            if (valor < 1900 || valor > DateTime.Now.Year) { //REVISAR
                throw new Exception("El año de fundación no puede ser anterior a 1900 ni posterior a el año actual");
            }
        }
    }
}
