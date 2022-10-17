using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {
            // Declare variables and then initialize to zero.
            double num1 = 0; double num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Calculadora no console em C#\r");
            Console.WriteLine("------------------------\n");

            // Pede ao usuário o primeiro numero.
            Console.WriteLine("Digite um numero, e tecle Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Pede o segundo numero.
            Console.WriteLine("Digite outro numero, e tecle Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Pede ao usuário que operação quer fazer.
            Console.WriteLine("Escolha uma opção da lista abaixo:");
            Console.WriteLine("\ta - SOMAR");
            Console.WriteLine("\ts - SUBTRAIR");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Sua opção? ");

            // Usa a declaração switch para fazer a matemática.
            switch (Console.ReadLine()) {
                case "a":
                    Console.WriteLine($"Seu Resultado de: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Seu Resultado de: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Seu Resultado de: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so.
                    while (num2 == 0) {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Aguarda o usuário teclar algo para fechar a solução.
            Console.Write("Pressione qualquer tecla para fechar a calculadora...");
            Console.ReadKey();
        }
    }
}
