/*
 * ==================================================================================================================
 *   Beecrowd 1021 - Notas e Moedas
 *   Descrição: Leia um valor de ponto flutuante com duas casas decimais. 
 *   Este valor representa um valor monetário. 
 *   A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
 *   As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. 
 *   A seguir mostre a relação de notas necessárias.
 *   
 *   
 *   Saída: Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial
 * ==================================================================================================================
*/

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
        int valorEmCentavos = (int)(valor * 100);
        int[] notas = { 10000, 5000, 2000, 1000, 500, 200 };
        int[] moedas = { 100, 50, 25, 10, 5, 1 };
        Console.WriteLine("NOTAS:");
        foreach (int nota in notas)
        {
            int quantidade = valorEmCentavos / nota;
            Console.WriteLine($"{quantidade} nota(s) de R$ {(nota / 100.0):F2}");
            valorEmCentavos %= nota;
        }
        Console.WriteLine("MOEDAS:");
        foreach (int moeda in moedas)
        {
            int quantidade = valorEmCentavos / moeda;
            Console.WriteLine($"{quantidade} moeda(s) de R$ {(moeda / 100.0):F2}");
            valorEmCentavos %= moeda;
        }
    }
}