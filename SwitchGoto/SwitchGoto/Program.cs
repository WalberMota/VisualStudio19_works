using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SwitchGoto {
    class Program {
        static void Main() {
            int tempo;
            char escolha;
            string meio="";

            inicio: // cria uma labem para retorno do Goto

            Console.Clear(); //limpa a tela

            Console.WriteLine("Escolha seu meio de transporte...");
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║ Belo Horizonte/MG à Vitória/ES ║");
            Console.WriteLine("╚════════════════════════════════╝");
            Console.WriteLine("\n");
            Console.Write("Escolha o transporte: [a]vião  [c]arro  [o]nibus :  ");

            escolha = char.Parse(Console.ReadLine());

            switch (escolha) {
                case 'a':
                case 'A':
                    meio = "Avião";
                    tempo = 50;
                    break;
                case 'c':
                case 'C':
                    meio = "Carro";
                    tempo = 480;
                    break;
                case 'o':
                case 'O':
                    meio = "Ônibus";
                    tempo = 680;
                    break;
                default:
                    tempo = -1;
                    break;

            }
            if (tempo < 0) {
                Console.WriteLine("\n");
                Console.WriteLine("transporte não disponível!\n");
            }
            else {
                
                //Console.Clear();
                Console.WriteLine("\n"); //line feed
                Console.WriteLine("Tempo de viagem de {0} é de {1} minutos de viagem.\n" , meio, tempo);
            }
            
            Console.WriteLine("--------------------------------------");
            Console.Write("Quer escolher outro tranporte ? [s/n]   ");
            escolha = char.Parse(Console.ReadLine());
            if (escolha=='s' || escolha == 'S') {
                // se 'sim' volta ao inicio do programa (label inicio)
                goto inicio;
            }
            else {
                Console.WriteLine("\n");
                Console.WriteLine("Obrigado...");
                Thread.Sleep(1300);// espera 1,3 seg antes de fechar o app
            }

        }

    }
}


