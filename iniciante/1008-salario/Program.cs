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
