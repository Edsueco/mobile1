using System;
namespace triangulo
{
    public class Quadrado
    {
        private int ladoA;
        private int ladoB;
        private int ladoC;
        private int ladoD;

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

        public void setladoD(int LadoD)
        {
            ladoD = LadoD;
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

        public string getladoD()
        {
            return ladoD.ToString();
        }

        public Quadrado()
        {
        }
    }
}
