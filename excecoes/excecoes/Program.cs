using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace excecoes {

    class Program {

        static void Main() {

            try {
                int x = 3, y=0, z;
                z = x / y;
            }
            catch {
                Console.WriteLine("!!!!!!!!!!!!!");
                Console.WriteLine("divisão por 0 !");
             }
        }
    }
}
