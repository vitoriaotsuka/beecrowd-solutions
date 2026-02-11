/*
 * ===========================================================================================================
 *   Beecrowd 1015 - Distância Entre Dois Pontos
 *   Descrição: Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano,
 *   p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais, 
 *   segundo a fórmula: distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
 *   
 *   
 *   Saída: Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.
 * ===========================================================================================================
*/

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