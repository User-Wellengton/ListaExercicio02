using System;

namespace Exercicio03.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Double peso;
            Double altura;
            Double IMC;

            Console.WriteLine("Digite o valor do peso: (Ex 100)");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura: (EX: 1,11");
            altura = Convert.ToDouble(Console.ReadLine());

            IMC = peso / (altura * altura);

            if (IMC <= 18.5)
            {
                Console.WriteLine("Seu IMC é igual a: " + IMC + " Abaixo do peso");
            }   
            else if (IMC > 18.5 && IMC <= 25)
            {
                Console.WriteLine("Seu IMC é igual a: " + IMC + " Peso normal");
            } 
            else if (IMC >25 && IMC <= 30)
            {
                Console.WriteLine("Seu IMC é igual a: " + IMC + " Acima do peso");

            }
            else if (IMC > 30)
            {
                Console.WriteLine("Seu IMC é igual a: " + IMC + " Obeso!!");

            }













        }
    }
}
