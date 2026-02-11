/*
 * ===========================================================================================================
 *   Beecrowd 1018 - Cédulas
 *   Descrição: Leia um valor inteiro. 
 *   A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. 
 *   As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. 
 *   A seguir mostre o valor lido e a relação de notas necessárias. 
 *   
 *   Saída: Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias.
 * ===========================================================================================================
*/


namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N > 0 || N < 1000000)
            {
                int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
                Console.WriteLine(N);
                for (int i = 0; i < cedulas.Length; i++)
                {
                    int quantidade = N / cedulas[i];
                    Console.WriteLine($"{quantidade} nota(s) de R$ {cedulas[i]},00");
                    N = N % cedulas[i];
                }
            }
        }

    }
}
