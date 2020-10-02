using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\teste\file1.txt";
            string targetPath = @"c:\teste\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath); //para ler o conteúdo do arquivo
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occcorred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
