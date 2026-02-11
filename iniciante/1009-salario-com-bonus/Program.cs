/*
 * =======================================================================================================
 *   Beecrowd 1009 - Salário com Bônus
 *    Descrição:  leia o nome de um vendedor, o seu salário fixo e o total de vendas 
 *    efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão
 *    sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.
 *    
 *    Saída: Imprima o total que o funcionário deverá receber.
 * ========================================================================================================
*/

using System;
using System.Globalization;

namespace salario_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendendor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double taxa = 0.15;

            double bonus = totVendas * taxa;

            double salarioFinal = salarioFixo + bonus;

            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}