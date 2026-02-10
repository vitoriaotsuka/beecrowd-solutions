using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');
          
            double A = double.Parse(dados[0], CultureInfo.InvariantCulture);
            double B = double.Parse(dados[1], CultureInfo.InvariantCulture);
            double C = double.Parse(dados[2], CultureInfo.InvariantCulture);

            double triangleArea = (A * C) / 2.0;
            double circleArea = Math.PI * Math.Pow(C, 2);
            double trapezoidArea = ((A + B) * C) / 2.0;
            double squareArea = Math.Pow(B, 2);
            double rectangleArea = A * B;

            Console.WriteLine("TRIANGULO: " + triangleArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circleArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezoidArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " +  squareArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + rectangleArea.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}