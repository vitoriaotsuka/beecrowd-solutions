/*
 * =======================================================
 *   Beecrowd 1003 - Soma Simples
 *    Descrição: Leia dois valores inteiros A e B.
 *    Calcule a soma e armazene na variável SOMA.
 *
 *    Saída:
 *      Imprimir: SOMA = valor
 * =======================================================
*/


using System;
class Program
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int SOMA = A + B;

        Console.WriteLine("SOMA = " + SOMA);
    }
}
