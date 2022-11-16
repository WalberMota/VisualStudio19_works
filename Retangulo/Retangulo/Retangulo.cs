using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo {
    internal class Retangulo {
        public double LadoA;
        public double LadoB;
        public double Perimetro() {
            return (2 * LadoA) + (2 * LadoB);
        }
        public double Area() {
            return LadoA * LadoB;
        }
        public double Diagonal() {
            return Math.Sqrt(Math.Pow(LadoA,2) + Math.Pow(LadoB,2));
        }



    }
}
