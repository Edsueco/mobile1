using System;

namespace triangulo
{
    class Program
    {
        protected static void Main(string[] args)
        {
            Triangulo t = new Triangulo();

            Console.WriteLine("Informe o lado A: ");
            t.setladoA(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o lado B: ");
            t.setladoB(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o lado C: ");
            t.setladoC(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("\nValores informado pelo usuario:");
            Console.WriteLine("Lado A: " + t.getladoA());
            Console.WriteLine("Lado B: " + t.getladoB());
            Console.WriteLine("Lado C: " + t.getladoC());
        }
    }
}
