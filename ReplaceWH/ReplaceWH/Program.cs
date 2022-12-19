using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWH {
    class Program {
        static void Main(string[] args) {
            Console.Title= "Hacker text by Walber Mota - November 11, 2022";
            Console.WriteLine("              CONVERSOR HACKER TEXT");
            Console.WriteLine(".............................................");
            Console.WriteLine("           Quando terminar aperte enter");
            Console.WriteLine(".............................................");
            Console.WriteLine();
            Console.WriteLine();
            string source = Console.ReadLine();


            // Replace all occurrences of one char with another.
            var repo1 = source.Replace('t', '7');
            var repo2 = repo1.Replace('T', '7');
            var repo3 = repo2.Replace('a', '4');
            var repo4 = repo3.Replace('A', '4');
            var repo5 = repo4.Replace('i', '1');
            var repo6 = repo5.Replace('I', '1');
            var repo7 = repo6.Replace('e', '3');
            var repo8 = repo7.Replace('E', '3');
            var repo9 = repo8.Replace('o', '0');
            var repo10 = repo9.Replace('O', '0');

            Console.WriteLine("\n\n.............................................");
            
            Console.WriteLine("\nTexto convertido :");
            Console.WriteLine("\n"+repo10);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
