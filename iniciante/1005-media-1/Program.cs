/*
 * ==============================================================================
 *   Beecrowd 1005 - Média 1
 *    Descrição: Leia 2 valores de ponto flutuante de dupla precisão A e B. 
 *    A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e
 *    a nota B tem peso 7.5 (A soma dos pesos portanto é 11). 
 *    
 *    Saída: Imprima a mensagem "MEDIA" e a média do aluno.
 * ==============================================================================
*/

using System;
using System.Globalization;


namespace media_1
{
    class Programm
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = (A * 3.5) + (B * 7.5);
            double media = soma / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5"), CultureInfo.InvariantCulture);



        }
    }

}
