/*
 * ========================================================================================================
 *   Beecrowd 1012 - Área
 *   Descrição: Leia três valores com ponto flutuante de dupla precisão: A, B e C. 
 *   calcule e mostre:
 *      a) a área do triângulo retângulo que tem A por base e C por altura.
 *      b) a área do círculo de raio C. (pi = 3.14159)
 *      c) a área do trapézio que tem A e B por bases e C por altura.
 *      d) a área do quadrado que tem lado B.
 *       e) a área do retângulo que tem lados A e B.
 *   
 *   Saída: Deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas.
 *   O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
 * ========================================================================================================
*/


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
            double pi = 3.14159;

            double triangleArea = (A * C) / 2.0;
            double circleArea = pi * Math.Pow(C, 2);
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