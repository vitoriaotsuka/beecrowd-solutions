/*
 * ===========================================================================================================
 *   Beecrowd 1014 - Consumo
 *   Descrição: Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km)
 *   e o total de combustível gasto (em litros). 
 *   
 *   Saída: Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula,
 *   seguido da mensagem "km/l".
 * ===========================================================================================================
*/

using System;
using System.Globalization;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");


        }
    }
}
