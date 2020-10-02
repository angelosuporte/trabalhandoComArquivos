using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste\file1.txt";
            StreamReader sr = null;
            
            try
            {
                sr = File.OpenText(path);
                string line = sr.ReadLine();
                Console.WriteLine(line);
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occcorred");
                Console.WriteLine(e.Message);
            }

            
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
