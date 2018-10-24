using System;

namespace triangulo
{
    class Program
            {
        protected static void Main(string[] args)
        {
            int ladoA;
            int ladoB;
            int ladoC;

            string texto;

            Console.WriteLine("Digite um valor para o lado A: ");
            ladoA = Int32.Parse(Console.ReadLine());
            texto = "LadoA: " + ladoA;
            //Console.WriteLine(texto);
            
            Console.WriteLine("Digite um valor para o lado B: ");
            ladoB = Int32.Parse(Console.ReadLine());
            texto += "\nLadoB: " + ladoB;
            //Console.WriteLine(texto);

            Console.WriteLine("Digite um valor para o lado C: ");
            ladoC = Int32.Parse(Console.ReadLine());
            texto += "\nLadoC: " + ladoC;
            Console.WriteLine(texto);


        }
    }
}
