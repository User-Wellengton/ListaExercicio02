using System;

namespace Exercicio02.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


			int[] numeros = new int[3];

			for (int i = 0; i < numeros.Length; i++)
			{
				Console.Write("Digite um número: ");
				numeros[i] = Convert.ToInt32(Console.ReadLine());
			}

			Array.Sort(numeros);
			Console.Write("\n\n");
			foreach (int i in numeros) Console.WriteLine(i);
		}




	}
    
}
