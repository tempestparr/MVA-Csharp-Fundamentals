using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:Lesson\Example.txt");
                Console.WriteLine(content);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Check the file name");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Check if the directory exists");
            }
            // catch all
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // code to finalize
                // set objects to null
                // close database connections
                Console.WriteLine("Closing application now");
            }
            Console.ReadLine();
        }
    }
}
