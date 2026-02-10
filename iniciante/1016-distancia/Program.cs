using System;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int distacia = int.Parse(Console.ReadLine());

            int kmMinutos = distacia * 2;

            Console.WriteLine($"{kmMinutos} minutos");
        }
        
    }
}
