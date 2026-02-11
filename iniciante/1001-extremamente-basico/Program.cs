/*
 * ===========================================================
 *   Beecrowd 1001 - Extremamente Básico
 *   Descrição: Leia dois valores inteiros A e B.
 *   A seguir, calcule a soma entre eles e imprima X = soma.
 * ===========================================================
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int X = A + B;

        Console.WriteLine("X = " + X);
    }
}
