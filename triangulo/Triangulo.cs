using System;
namespace triangulo
{
    public class Triangulo
    {
        private int ladoA;
        private int ladoB;
        private int ladoC;

        public void setladoA(int LadoA)
        {
            ladoA = LadoA;
        }

        public void setladoB(int LadoB)
        {
            ladoB = LadoB;
        }

        public void setladoC(int LadoC)
        {
            ladoC = LadoC;
        }

        public string getladoA()
        {
            return ladoA.ToString();
        }

        public string getladoB()
        {
            return ladoB.ToString();
        }

        public string getladoC()
        {
            return ladoC.ToString();
        }

        public Triangulo()
        {

        }
    }
}
