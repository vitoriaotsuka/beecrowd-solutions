using System;

namespace Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');

            int A = int.Parse(dados[0]);
            int B = int.Parse(dados[1]);
            int C = int.Parse(dados[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;

            if (maiorAB > C)
            {
                Console.WriteLine($"{maiorAB} eh o maior");
            }
            else
            {
                Console.WriteLine($"{C} eh o maior");
            }
        }
    }
}
