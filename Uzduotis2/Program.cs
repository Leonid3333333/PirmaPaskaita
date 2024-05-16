using System;

namespace PirmaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Iveskyte gimimo metus: ");
            int birthday = int.Parse(Console.ReadLine());
            int today = 2024;
            int age = today - birthday;
            Console.WriteLine($"Jusu amzius = {age} ");

            
        }
    }
}