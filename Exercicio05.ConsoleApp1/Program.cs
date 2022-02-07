using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int A, B, C;

            Console.WriteLine("Digite o valor de A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
                Console.WriteLine("Os valores de A e B foram somados.   C = " + C);
            } 
            else
            {
                C = A * B;
                Console.WriteLine("Os valores de A e B foram multiplicados.   C = " + C);
            }

           
       
        }
    }
}
