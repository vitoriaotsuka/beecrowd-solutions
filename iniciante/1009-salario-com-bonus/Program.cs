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