using System;

namespace triangulo
{
    class Program
    {
        protected static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Quadrado q = new Quadrado();

            /*
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
            */

            Console.WriteLine("Informe os lados do Quadrado: ");
            Console.WriteLine("lado A: ");
            q.setladoA(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("lado B: ");
            q.setladoB(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("lado C: ");
            q.setladoC(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("lado D: ");
            q.setladoD(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("\nValores informado pelo usuario:");
            Console.WriteLine("Lado A: " + q.getladoA());
            Console.WriteLine("Lado B: " + q.getladoB());
            Console.WriteLine("Lado C: " + q.getladoC());
            Console.WriteLine("Lado D: " + q.getladoD());
        }
    }
}
