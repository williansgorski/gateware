using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercicio03
{
    public static class Execute
    {
        public static bool ExecuteMethod()
        {
            bool ret;
            try
            {
                Console.WriteLine("Exerc 03");

                string origPath = @"C:\Users\willi\OneDrive\Documentos\Images";
                Console.WriteLine($"Pasta origem: {origPath}");
                string destPath = "C://Exericio03/";
                Console.WriteLine($"Pasta destino: {destPath}");

                bool exists = System.IO.Directory.Exists(System.IO.Path.Combine(destPath));

                if (!exists)
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(destPath));

                DirectoryInfo Dir = new DirectoryInfo(origPath);

                string[] patterns = new[] { ".jpg", ".jpeg", ".jpe", ".jif", ".jfif", ".jfi", ".webp", ".gif", ".png", ".apng", ".bmp", ".dib", ".tiff", ".tif", ".svg", ".svgz", ".ico", ".xbm" };


                FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
                if (Files.Length > 0)
                {
                    foreach (FileInfo File in Files)
                    {

                        int pos = Array.IndexOf(patterns, File.Extension);
                        if (pos > -1)
                        {
                            System.IO.File.Copy(File.FullName, Path.Combine(destPath, File.Name), true);
                            Console.WriteLine($"Arquivo copiado: {File.Name}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Não existe nenhum imagem texto nessa pasta: {origPath}");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
