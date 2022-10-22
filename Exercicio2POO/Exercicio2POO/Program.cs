using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2POO {
    class Program {
        static void Main() {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do funcionario 1 :");
            Console.Write("Nome : ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário : ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do funcionario 2 :");
            Console.Write("Nome : ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário : ");
            f2.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("\tNOME\tSALARIO ");
            Console.WriteLine(" ");
            Console.WriteLine("\t" + f1.nome + "\tR$ " + f1.salario.ToString("F2"));
            Console.WriteLine(" ");
            Console.WriteLine("\t" + f2.nome + "\tR$ " + f2.salario.ToString("F2"));

            double vd = (f1.salario + f2.salario) / 2;

            Console.WriteLine("===============================");
            Console.WriteLine("Salario médio:\t\tR$ " + vd.ToString("F2"));
            //Console.WriteLine(vd);

            Console.ReadKey();

        }
    }
}
