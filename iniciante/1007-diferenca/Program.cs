/*
 * ==============================================================================
 *   Beecrowd 1007 - Diferença
 *    Descrição: Leia quatro valores inteiros A, B, C e D.  
 *    A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D
 *    segundo a fórmula: DIFERENCA = (A * B - C * D).
 *    
 *    Saída: Imprima a mensagem DIFERENCA com todas as letras maiúsculas.
 * ==============================================================================
*/


using System;

namespace diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
