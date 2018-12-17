using System;
using System.IO;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler arquivo txt na pasta Exercício 02
            try
            {
                Console.WriteLine("Exerc 02");

                string subPath = "C://Exericio02/";
                Console.WriteLine($"Pasta escolhida:{subPath}");

                bool exists = System.IO.Directory.Exists(System.IO.Path.Combine(subPath));

                if (!exists)
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(subPath));

                DirectoryInfo Dir = new DirectoryInfo(subPath);

                FileInfo[] Files = Dir.GetFiles("*txt", SearchOption.AllDirectories);

                if (Files.Length > 0)
                {
                    foreach (FileInfo File in Files)
                    {
                        string[] lines = System.IO.File.ReadAllLines(File.FullName);
                        Console.WriteLine();
                        for (int i = 0; i < lines.Length; i++)
                        {
                            Console.WriteLine($"Telefone {i+1}: {lines[i]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Não existe nenhum arquivo texto nessa pasta: {subPath}");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {

            }

        }
    }
}
