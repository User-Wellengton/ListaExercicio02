using System;

namespace Exercicio02ConsoleApp1
{
    public class SomaABC
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Digite o valor de A:");
            decimal A = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            decimal B = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            decimal C = Convert.ToDecimal(Console.ReadLine());



            if (A + B < C)
            {
                Console.WriteLine("A soma de A + B é menor que C!!");
            }


           





           
        }
    }
}
