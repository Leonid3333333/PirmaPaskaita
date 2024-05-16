using System;

namespace PirmaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Forengaeito laipsniai =");
            int temp = int.Parse(Console.ReadLine());
            int temp1 = ((temp - 32) * 5) / 9;
            Console.WriteLine($"Laipsniai celsijaus = {temp1} ");

        }
    }
}
