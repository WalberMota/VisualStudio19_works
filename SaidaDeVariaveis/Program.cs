using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SaidaDeVariaveis {
    class Program {
        static void Main(string[] args) {
            char genero = 'F';
            int idade = 32;
            double saldo = 12500.35784;
            string nome = "Maria";

            Console.WriteLine("Nome : " + nome); //
            Console.WriteLine("Sexo : " + genero);
            Console.WriteLine("Idade : " + idade + "anos");
            //saida com virgula de separador decimal, configuração do computador.
            Console.WriteLine("Salário : R$ " + saldo);
            Console.WriteLine("Salário : R$ " + saldo.ToString("f2"));
            //ponto como separador decimal
            Console.WriteLine("Salário : R$ " + saldo.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("");

            Console.WriteLine("1 - usando Placeholders: {0} tem {1} anos e recebe {2:f2} reais,nome,idade,saldo");
            Console.WriteLine("{0} tem {1} anos e recebe {2:f2} reais", nome, idade, saldo);
            Console.WriteLine("");

            Console.WriteLine("2 - usando Interpolação: {nome} tem {idade} anos e recebe {saldo:f2} reais");
            Console.WriteLine($"{nome} tem {idade} anos e recebe {saldo:f2} reais");

            Console.WriteLine("");
            Console.WriteLine("tecla algo para fechar...git ");
            Console.ReadKey();
        }
    }
}
