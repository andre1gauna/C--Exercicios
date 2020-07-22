using System;
using System.IO;

namespace Exercicio_I_O
{
    class Program
    {
        static void Main(string[] args)
        {
            //string SourcePath = @"C:\Exercicio I-O\Source.txt";
            //string TargetPath = @"\out";

            //Directory.CreateDirectory(SourcePath);

            //FileStream fs = null;
            //StreamReader sr = null;
            //try
            //{
            //    fs = new FileStream(SourcePath, FileMode.Open);
            //    sr = new StreamReader(fs);
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("erro ocurred");
            //    Console.WriteLine(ex.Message);
            //}

            string path = @"\Source.txt";
            try
            {
                using (FileStream fstream = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sreader = new StreamReader(fstream))
                    {
                        while (!sreader.EndOfStream)
                        {
                            string line = sreader.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                  
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
