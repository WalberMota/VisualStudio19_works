﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couse {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
    }
}
