using System;

namespace triangulo
{
    class Program
    {
        protected static void Main(string[] args)
        {
            Triangulo t = new Triangulo();

            t.ladoA = 12;
            t.ladoB = 13;
            t.ladoC = 14;

            Console.WriteLine("Informe o lado A: ");
            t.ladoA = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o lado B: ");
            t.ladoB = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o lado C: ");
            t.ladoC = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nValores informado pelo usuario:");
            Console.WriteLine("Lado A: " + t.ladoA);
            Console.WriteLine("Lado B: " + t.ladoB);
            Console.WriteLine("Lado C: " + t.ladoC);
        }
    }
}
