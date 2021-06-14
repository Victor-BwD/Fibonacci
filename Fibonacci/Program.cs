using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1, n2 = 0, soma, tamDaSequencia;

            tamDaSequencia = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamDaSequencia; i++)
            {
                soma = n1 + n2;

                Console.WriteLine(soma);
                n2 = n1;
                n1 = soma;

            }
        }
    }
}
