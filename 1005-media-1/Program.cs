using System;
using System.ComponentModel;
using System.Globalization;


namespace media_1
{
    class Programm
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = (A * 3.5) + (B * 7.5);
            double media = soma / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5"), CultureInfo.InvariantCulture);



        }
    }

}
