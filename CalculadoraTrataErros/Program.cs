using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTrataErros {
    class Calculadora {
        public static double DoOperation(double num1, double num2, string op) {
            // Se o valor padrão não é um numero em uma operação, como uma divisão, resultará em erro.
            double result = double.NaN;

            // Usa a declaração switch para fazer a matemática
            switch (op) {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Solicita um divisor diferente de zero.
                    if (num2 != 0) {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }
    class Program {
        static void Main(string[] args) {
            bool endApp = false;
            // Mostra o título do app de console.
            Console.WriteLine("    Calculadora no Console em C#\r");
            Console.WriteLine("--------by Walber Mota 2022--------\n");

            while (!endApp) {
                // Cria as variáveis vazias.
                string numInput1;// = "";
                string numInput2;// = "";
                double result = 0;

                // Pede o primeiro numero ao usuario.
                Console.Write("Digite um número, e tecle Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1)) {
                    Console.Write("Entrada invalida. Digite um número: ");
                    numInput1 = Console.ReadLine();
                }

                // Pede o segundo numero ao usuario.
                Console.Write("Digite outro número, e tecle Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2)) {
                    Console.Write("Entrada invalida. Digite um número: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Escolha a operação matemática que deseja fazer:");
                Console.WriteLine("\ta - SOMAR");
                Console.WriteLine("\ts - SUBTRAIR");
                Console.WriteLine("\tm - MULTIPLICAR");
                Console.WriteLine("\td - DIVIDIR");
                Console.Write("Qual a opção? ");

                string op = Console.ReadLine();

                try {
                    result = Calculadora.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result)) {
                        Console.WriteLine("Divisão por zero - erro matemático.\n");
                    }
                    else Console.WriteLine("Seu Resultado: {0:0.##}\n", result);
                }
                catch (Exception e) {
                    Console.WriteLine("Ocorre um erro tentando fazer a matemática.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}
