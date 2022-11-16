using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couse {
    class Program {
        static void Main(string[] args) {
            Produto p=new Produto();


            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade=int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: "+p);
        }
    }
}
