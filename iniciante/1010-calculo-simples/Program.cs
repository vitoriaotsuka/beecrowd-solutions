/*
 * =======================================================================================================
 *   Beecrowd 1010 - Cálculo Simples
 *   Descrição:  Leia o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
 *   o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
 *   Após, calcule e mostre o valor a ser pago.
 *    
 *   Saída: Imprima o valor a ser pago, com duas casas decimais.
 * ========================================================================================================
*/

using System;
using System.Drawing;
using System.Globalization;


namespace calculo_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dados1 = Console.ReadLine().Split(' ');
            int cdPeca1 = int.Parse(dados1[0]);
            int numPecas1 = int.Parse(dados1[1]);
            double valorPeca1 = double.Parse(dados1[2], CultureInfo.InvariantCulture);

            string[] dados2 = Console.ReadLine().Split(' ');
            int cdPeca2 = int.Parse(dados2[0]);
            int numPecas2 = int.Parse(dados2[1]);
            double valorPeca2 = double.Parse(dados2[2], CultureInfo.InvariantCulture);

            double valorTotal = (numPecas1 * valorPeca1) + (numPecas2 * valorPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
