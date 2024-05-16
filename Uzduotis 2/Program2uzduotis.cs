using System;

namespace PirmaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu 1");
            int number1 = int.Parse (Console.ReadLine());
            Console.WriteLine("iveskite skaiciu 2");
            int number2 = int.Parse (Console.ReadLine());

            int number3 = number1 + number2;
            int number4 = number1 - number2;
            int number5 = number1 * number2;
            int number6 = number1 / number2;


            Console.WriteLine($"suma =  {number3}, minusas = {number4}, dugyba = {number5}, padalinti = {number6}");

            
        }
    }
}