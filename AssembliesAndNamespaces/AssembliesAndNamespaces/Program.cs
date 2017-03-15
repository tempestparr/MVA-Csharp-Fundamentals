using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // .Net framework class library is a collection of 
            // classes each containing methods filled
            // with functionlity that we can use

            // The library of code is split into mutiple files
            // called .Net assemblies

            // bin directory contains a Debug and Release version
            // the Debug version contains additional files required
            // by Visual Studio to connect to the execution of the
            // compiled executable to allow us to step through the
            // execution and pause the execution line by line

            // Namespaces - to differentiate classes of the same name
            // instead of using the full name
            // Example - using System;
            // System namespace contains the Console class so we 
            // don't have to write System.Console.ReadLine()


            string text = "Write this line to our file.";
            File.WriteAllText(@"C:\Users\Tempest\Downloads\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\Tempest\Downloads\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
