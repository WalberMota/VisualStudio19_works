using System;
using System.IO;
using System.Net.WebSockets;
using System.Windows;

namespace LerGravaArqtxt01 {
    internal class Program {
        static void Main(string[] args) {
            string dirDocumentos = (string)Microsoft.Win32.Registry.CurrentUser
                .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
                .GetValue("Personal"); //localiza a pasta documentos do usuários

            string acao;
            string caminho = dirDocumentos + "\\usuario.txt";//cria o arquivo usuario.txt
            string nome, email, telefone, rg;

            Console.WriteLine("##########################");
            Console.WriteLine("##########################");
            Console.WriteLine("###### G - Gravar ########");
            Console.WriteLine("###### L - Ler    ########");
            Console.WriteLine("###### S - SAIR   ########");
            Console.WriteLine("##########################");
            Console.WriteLine(" X - Apaga todos os dados ");
            Console.WriteLine("##########################");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");
            acao = Console.ReadLine().ToUpper();
            Console.WriteLine();
            while (acao != "S") {

                if (acao == "G") { //   adicionar item ao arquivo texto

                    Console.Write("Informe o nome: ");
                    nome = Console.ReadLine().ToUpper();

                    Console.Write("Informe o email: ");
                    email = Console.ReadLine().ToUpper();

                    Console.Write("Informe o telefone: ");
                    telefone = Console.ReadLine().ToUpper();

                    Console.Write("Informe o RG: ");
                    rg = Console.ReadLine().ToUpper();

                    StreamWriter sw = new StreamWriter(caminho, true);
                    sw.WriteLine("Nome:     " + nome);
                    sw.WriteLine("email:    " + email);
                    sw.WriteLine("Telefone: " + telefone);
                    sw.WriteLine("Rg:       " + rg);
                    sw.WriteLine("---------------------------------------");
                    sw.Close();
                }
                else if (acao == "L") {

                    StreamReader sr = new StreamReader(caminho);

                    while (sr.EndOfStream != true) {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
                else if (acao == "X") {
                    StreamWriter zerar = new StreamWriter(caminho, false);
                    zerar.WriteLine("");
                    zerar.Close();
                }
                Console.WriteLine();
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("##########################");
                Console.WriteLine("##########################");
                Console.WriteLine("###### G - Gravar ########");
                Console.WriteLine("###### L - Ler    ########");
                Console.WriteLine("###### S - SAIR   ########");
                Console.WriteLine("##########################");
                Console.WriteLine(" X - Apaga todos os dados ");
                Console.WriteLine("##########################");
                Console.WriteLine();
                Console.Write("Digite uma opção: ");
                acao = Console.ReadLine().ToUpper();
                Console.WriteLine();

            }

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            MessageBox.Show("SYSTEM CLOSED", "by walber 19/11/2022");
        }
    }

}
