/*
 * ===================================================================
 *   Beecrowd 1004 - Produto Simples
 *    Descrição: Leia dois valores inteiros. 
 *    A seguir, calcule o produto entre estes dois valores
 *    
 *    Saída: Imprima a mensagem "PROD" e o produto dos dois valores
 * ====================================================================
*/


using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int .Parse(Console.ReadLine());

        int PROD = A * B;

        Console.WriteLine("PROD = " + PROD);
    }
}