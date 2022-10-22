using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWH {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite un texto");
            string source = Console.ReadLine();

            // Replace all occurrences of one char with another.
            var repo1 = source.Replace('t', '7');
            var repo2 = repo1.Replace('T', '7');
            var repo3 = repo2.Replace('a', '4');
            var repo4 = repo3.Replace('i', '1');
            var repo5 = repo4.Replace('e', '3');
            //Console.WriteLine(source);
            Console.WriteLine(repo5);
        }
    }
}
