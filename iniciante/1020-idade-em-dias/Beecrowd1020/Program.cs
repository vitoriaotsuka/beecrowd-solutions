/*
 * ==================================================================================================================
 *   Beecrowd 1020 - Idade em Dias
 *   Descrição: Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias.
 *   
 *   Saída: Imprima a saída conforme exemplo fornecido.
 * ==================================================================================================================
*/

class Program
{
    static void Main(string[] args)
    {
        int dias = int.Parse(Console.ReadLine());

        int anos = dias / 365;
        int meses = (dias % 365) / 30;
        int diasRestantes = (dias % 365) % 30;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{diasRestantes} dia(s)");

    }
}