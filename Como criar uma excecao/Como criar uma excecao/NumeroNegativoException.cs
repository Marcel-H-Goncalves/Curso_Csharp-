﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Como_criar_uma_excecao
{
    internal class NumeroNegativoException: Exception
    {
        public NumeroNegativoException(int numero) : base("Número " + numero + " não é positivo")
        {

        }
    }
}
