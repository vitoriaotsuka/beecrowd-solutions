/*
 * ==================================================================================================================
 *   Beecrowd 1019 - Conversão de Tempo
 *   Descrição: Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica,
 *   e informe-o expresso no formato horas:minutos:segundos.
 *   
 *   Saída: Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos.
 * ==================================================================================================================
*/


using System;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            int horas = N / 3600;
            int minutos = (N % 3600) / 60;
            int segundos = N % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");

        }
    }
}
