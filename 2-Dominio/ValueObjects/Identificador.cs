﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dominio.ValueObjects
{
    internal class Identificador
    {
        private Guid valor;

        public Identificador(Guid valor) 
        {
            this.valor = valor;
        }

        public Guid Valor()
        {
            return this.valor;
        }
    }
}
