using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lógica para ler o primeiro arquivo e adicionar no segundo arquivo o texto com letras maiúsculas(método ToUpper)
            string sourcePath = @"c:\teste\file1.txt";
            string targetPath = @"c:\teste\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
