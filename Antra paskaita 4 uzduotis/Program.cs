using System;

namespace AntraPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskita skaiciu N:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;


            while (n > 0)
            {
                sum += n;
                n--;
            }
            Console.WriteLine(sum);
        }
            
        }
    }
}
