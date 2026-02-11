/*
 * ==================================================================
 *   Beecrowd 1002 - Area do Círculo
 *    Descrição: Calcular a área de uma circunferência utilizando:
 *        area = π * raio²
 *       Considerar π = 3.14159.
 *
 *    Entrada:
 *      Um valor de ponto flutuante (double) representando o raio.
 *
 *    Saída:
 *      Imprimir "A=" seguido da área com 4 casas decimais.
 * ===================================================================
*/

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n = 3.14159;

        double area = n * Math.Pow(raio, 2.0);

        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
    }
}