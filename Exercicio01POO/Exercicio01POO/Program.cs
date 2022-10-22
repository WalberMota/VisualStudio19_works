using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01POO {
    class Program {
        static void Main(string[] args) {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Saber qual é a pessoa mais velha de uma dupla:");
            Console.Write("nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("nome da primeira pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            pessoa2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            if (pessoa1.idade > pessoa2.idade) {
                Console.WriteLine(pessoa1.nome + " é a pessoa mais vela da dupla");
            }
            else {
                Console.WriteLine(pessoa2.nome + " é a pessoa mais vela da dupla");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
