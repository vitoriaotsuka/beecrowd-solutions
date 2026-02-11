/*
 * ===========================================================================================================
 *   Beecrowd 1016 - Distância 
 *   Descrição: Leia a distância (em Km) e calcule quanto tempo leva (em minutos) 
 *   para o carro Y tomar essa distância do outro carro.
 *   
 *   
 *   Saída: Imprima o tempo necessário seguido da mensagem "minutos".
 * ===========================================================================================================
*/

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
