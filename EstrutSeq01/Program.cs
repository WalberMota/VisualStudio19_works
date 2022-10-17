using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrutSeq01 {
    class Program {
        static void Main(string[] args) {
            int A, B, soma;

            A = int.Parse (Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("---------------------");
            Console.WriteLine("SOMA = " + soma);
            Console.ReadKey();

        }

    }
}
