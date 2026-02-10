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
