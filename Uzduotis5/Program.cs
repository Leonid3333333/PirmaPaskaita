using System;

namespace PirmaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string vardas = "Lio";
            string pavarde = "Jojo";
            int manometai = 1984;
            int siemetai = 2020;
            int amzius = siemetai - manometai;
                Console.WriteLine($"As esu {vardas} {pavarde} man yra {amzius} metai. ");
        }
    }
}