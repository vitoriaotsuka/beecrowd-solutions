/*
 * ==============================================================================
 *   Beecrowd 1006 - Média 2
 *    Descrição: Leia 3 valores, no caso, variáveis A, B e C 
 *    A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2,
 *    a nota B tem peso 3 e a nota C tem peso 5.
 *    
 *    Saída: Imprima a mensagem "MEDIA" e a média do aluno.
 * ==============================================================================
*/

using System;
using System.Globalization;

namespace media_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (A * 2 + B * 3 + C * 5) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}