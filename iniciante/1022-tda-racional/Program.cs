/*
 * ==================================================================================================================
 *   Beecrowd 1022 - TDA Racional
 *   Descrição: A entrada contem vários casos de teste. 
 *   A primeira linha de cada caso de teste contem um inteiro N (1 ≤ N ≤ 1*104),
 *   indicando a quantidade de casos de teste que devem ser lidos logo a seguir. 
 *   Cada caso de teste contém um valor racional X (1 ≤ X ≤ 1000), uma operação (-, +, * ou /) e 
 *   outro valor racional Y (1 ≤ Y ≤ 1000).
 *   
 *   Saída: A saída consiste em um valor racional, seguido de um sinal de igualdade e outro valor racional, 
 *   que é a simplificação do primeiro valor. No caso do primeiro valor não poder ser simplificado, 
 *   o mesmo deve ser repetido após o sinal de igualdade.
 * ==================================================================================================================
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        List<string> resultados = new List<string>();


        for (int i = 0; i < N; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            int N1 = int.Parse(entrada[0]);
            int D1 = int.Parse(entrada[2]);
            string operador = entrada[3];
            int N2 = int.Parse(entrada[4]);
            int D2 = int.Parse(entrada[6]);

            int numerador = 0;
            int denominador = 0;


            switch (operador)
            {
                case "+":
                    numerador = (N1 * D2) + (N2 * D1);
                    denominador = D1 * D2;
                    break;
                case "-":
                    numerador = (N1 * D2) - (N2 * D1);
                    denominador = D1 * D2;

                    break;
                case "*":
                    numerador = N1 * N2;
                    denominador = D1 * D2;
                    break;
                case "/":
                    numerador = N1 * D2;
                    denominador = N2 * D1;
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

            int a = Math.Abs(numerador);
            int b = Math.Abs(denominador);

            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }

            int mdc = a;

            int numSimplificado = numerador / mdc;
            int denSimplificado = denominador / mdc;

            resultados.Add($"{numerador}/{denominador} = {numSimplificado}/{denSimplificado}");

        }

        foreach (string r in resultados)
        {
            Console.WriteLine(r);

        }
    }
}

