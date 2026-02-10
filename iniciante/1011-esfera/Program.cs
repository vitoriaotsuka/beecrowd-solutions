using System.Globalization;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
