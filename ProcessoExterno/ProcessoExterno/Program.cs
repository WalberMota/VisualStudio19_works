using System;
using System.Diagnostics;
using System.ComponentModel;

namespace MyProcessSample {
    class MyProcess {
        // o navegador
        void OpenApplication(string myFavoritesPath) {
            // Inicia o programa.exe.
            Process.Start(@"C:\Program Files (x86)\AVAST Software\Browser\Application\AvastBrowser.exe", myFavoritesPath);

            // Display the contents of the favorites folder in the browser.
            //Process.Start(myFavoritesPath);
        }

        // ----------abrir urls e .html usando o navegador.
        void OpenWithArguments() {
            // url's are not considered documents. They can only be opened
            // by passing them as arguments.
            Process.Start(@"C:\Program Files (x86)\AVAST Software\Browser\Application\AvastBrowser.exe", "www.google.com");

            // Start a Web page using a browser associated with .html and .asp files.
            Process.Start(@"C:\Program Files (x86)\AVAST Software\Browser\Application\AvastBrowser.exe", "C:\\myPath\\myFile.htm");
            Process.Start(@"C:\Program Files (x86)\AVAST Software\Browser\Application\AvastBrowser.exe", "C:\\myPath\\myFile.asp");
        }

        // -------------usao o  ProcessStartInfo class para iniciar um novo processo,
        // em modo maximizado.
        void OpenWithStartInfo() {
            Process p = new Process();
            p.StartInfo.WorkingDirectory = @"C:\Program Files (x86)\AVAST Software\Browser\Application";
            p.StartInfo.FileName = @"AvastBrowser.exe";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            p.StartInfo.Arguments = "www.yahoo.com";
            p.Start();

        }
        static void Main() {
            // pega o caminho dos favoritos. - aqui so serve no Edge
            string myFavoritesPath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);

            MyProcess myProcess = new MyProcess();

            myProcess.OpenApplication(myFavoritesPath);
            //myProcess.OpenWithArguments();
            //myProcess.OpenWithStartInfo();

        }
    }
}
//No caso da calculadora, bastaria isso:
//System.Diagnostics.Process.Start("calc");
//Quando você quiser abrir algum executável "não Windows", forneça o path completo:
//System.Diagnostics.Process.Start("c:\Folder\arquivo.exe");
//Você pode passar parâmetros para eles também:
//System.Diagnostics.Process.Start("notepad", "c:\Folder\arquivo.txt");
//... e abrir o aplicativo associado a uma extensão, por exemplo, se você apontar um arquivo doc, o word abriria:
//System.Diagnostics.Process.Start("c:\Folder\arquivo.doc");