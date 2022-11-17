using System;

namespace ExtrairNumeros {
    internal class Program {
        static void Main(String[] args) {
            int modulo, tamanho;
            String n2 = "";
            string numinicial = "";
            Console.Write("Digite um numero qualquer com quantidade de digitos:");
            numinicial = Console.ReadLine();
            tamanho = numinicial.Length;
            for (int i = 0; i < tamanho; i++) {

                modulo = int.Parse(numinicial) % 10;
                n2 = Convert.ToString(modulo) + "   " + n2;
                numinicial = Convert.ToString(int.Parse(numinicial) / 10);
                //Console.WriteLine(numinicial);
                //Console.WriteLine(n2);
            }
            Console.WriteLine(n2);
            Console.ReadKey();

        }
    }
}

