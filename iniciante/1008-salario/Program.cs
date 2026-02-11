/*
 * ==============================================================================
 *   Beecrowd 1008 - Salário
 *    Descrição: Leia o número de um funcionário, seu número de horas trabalhadas,
 *    o valor que recebe por hora e calcula o salário desse funcionário. 
 *    A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
 *    
 *    Saída: Imprima o número e o salário do funcionário.
 * ==============================================================================
*/

using System;
using System.Globalization;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFuncionarios = int.Parse(Console.ReadLine());
            int numHorasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = numHorasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + numFuncionarios);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
