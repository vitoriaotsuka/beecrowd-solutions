
namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N > 0 || N < 1000000)
            {
                int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
                Console.WriteLine(N);
                for (int i = 0; i < cedulas.Length; i++)
                {
                    int quantidade = N / cedulas[i];
                    Console.WriteLine($"{quantidade} nota(s) de R$ {cedulas[i]},00");
                    N = N % cedulas[i];
                }
            }
        }

    }
}
