using System;

namespace Exercicio04.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Decimal n1;

            Console.WriteLine("Digite um numero qualquer:");
            n1 = Convert.ToDecimal(Console.ReadLine());

            if(n1 % 2 == 0)
            {
                Console.WriteLine("O numero que você informaou é PAR.");
            }
            else
            {
                Console.WriteLine("O numero que você informaou é IMPAR.");
            }
        }
    }
}
