/*
 * ========================================================================================================
 *   Beecrowd 1011 - Esfera
 *   Descrição: Calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). 
 *   A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
 *   
 *   Saída: A saída deverá ser uma mensagem "VOLUME" e o valor do volume da esfera, 
 *   com 3 casas após o ponto decimal.
 * ========================================================================================================
*/

using System.Globalization;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
