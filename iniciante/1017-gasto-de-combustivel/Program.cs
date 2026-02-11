/*
 * ===================================================================================================================
 *   Beecrowd 1017 - Gasto de Combustível
 *   Descrição:  Fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). 
 *   Assim, pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários. 
 *   Mostre o valor com 3 casas decimais após o ponto.
 *   
 *   Saída: Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal.
 * ===================================================================================================================
*/

using System;
using System.Globalization;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine()); 

            double distancia = horas * velocidade;
            double litros = distancia / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
