using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exerc 05");
            Console.WriteLine();
            string QUERY =@"
SELECT
   SUM(SALARIOS.VALOR_PAGO) VALOR_PAGO_TOTAL,
   COLABORADORES.NOME_COLABORADOR,
   LOCAL_DE_TRABALHO.UF 
FROM
   SALARIOS 
   INNER JOIN
      COLABORADORES 
      ON COLABORADORES.ID_COLABORADOR = SALARIOS.ID_COLABORADOR 
   INNER JOIN
      LOCAL_DE_TRABALHO 
      ON LOCAL_DE_TRABALHO.ID_COLABORADOR = COLABORADORES.ID_COLABORADOR 
WHERE
   YEAR(SALARIOS.DATA_PAGAMENTO) = 2014 
GROUP BY
   COLABORADORES.NOME_COLABORADOR,
   LOCAL_DE_TRABALHO.UF";
            Console.WriteLine(QUERY);
            Console.ReadLine();
        }
    }
}
