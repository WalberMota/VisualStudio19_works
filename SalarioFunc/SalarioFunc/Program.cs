using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioFunc {
    class Program {
        static void Main(string[] args) {
            //instancia um determinado funcionario
            Funcionario func = new Funcionario();

            //recebe os dados Nome, Salario Bruto e imposto sobre salario
            Console.WriteLine("Calculo de Reajuste de Salário");
            Console.WriteLine("Digite os dados do funcionário:");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            //caso aumente o salário
            Console.WriteLine("o funcionario receberá aumento do salário?");
            double porcentagem=double.Parse(Console.ReadLine());
            func.AumentarSalario(porcentagem);

            //imprime os dados atualizados
            Console.WriteLine();
            Console.WriteLine("Dados atuais: " + func);


        }
    }
}
