using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {
            Retangulo x;
            x = new Retangulo();

            Console.WriteLine("Digite as medidas do retangulo X :");
            x.LadoA = double.Parse(Console.ReadLine()); //CultureInfo.InvariantCulture
            x.LadoB = double.Parse(Console.ReadLine());
            double perimetro = x.Perimetro();
                Console.WriteLine("O Perimetro é " + perimetro + "\n");
            double area = x.Area();
                Console.WriteLine("A área é " + area + "\n");
            double diagonal = x.Diagonal();
                Console.WriteLine("A diagonal do retangulo é " + diagonal.ToString("F2") + "\n");

            Console.ReadKey();
        }
    }
}
