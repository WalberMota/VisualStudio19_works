using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAluno {
    internal class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("nota do 1o, 2o e 3o Trimestre: ");
            aluno.Nota1=int.Parse(Console.ReadLine());
            aluno.Nota2=int.Parse(Console.ReadLine());
            aluno.Nota3=int.Parse(Console.ReadLine());

            Console.WriteLine("Notafinal :" + aluno.NotaFinal());
            if (aluno.Aprovado()){
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltou "+aluno.Faltou());
            }
        }
    }
}
