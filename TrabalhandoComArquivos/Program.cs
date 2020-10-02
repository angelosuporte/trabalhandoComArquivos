using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
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

            // Como o uso do FileStream e StreamReader está ligado a diálogo com o SO, vamos usar o bloco abaixo para fechamento manual
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
