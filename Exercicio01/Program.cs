using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muitas validações poderiam ser colocadas nesse processo
            try
            {
                Console.WriteLine("Exerc 01");
                int numero = 50;
                try
                {
                    Console.WriteLine("Número de inteiros no array:");
                    bool validated = int.TryParse(Console.ReadLine(), out numero);

                    if (validated)
                    {
                        int[] numeroInteiros = new int[numero];

                        for (int i = 0; i < numeroInteiros.Length; i++)
                        {
                            int r = new Random().Next(0, 10000);
                            numeroInteiros[i] = r;
                            Console.Write($"{r},");
                        }
                        Console.WriteLine("\n");
                        Array array = numeroInteiros;
                        Array.Sort(array);

                        int maior = (int)array.GetValue(array.Length - 1);
                        Console.WriteLine($"Maior número do array:{maior}");
                        Console.ReadLine();
                    }

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
