using System;
using System.Globalization;

namespace Distancia {
    class Program{
        static void Main(string[] args){
            string[] coordenadas1 = Console.ReadLine().Split(' ');
            string[] coordenadas2 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(coordenadas1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(coordenadas1[1], CultureInfo.InvariantCulture);
            double x2 = double.Parse(coordenadas2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(coordenadas2[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
}
}