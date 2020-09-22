using System;
namespace PrintableInterface
{
    public class Domino : IPrintable
    {
        protected int sideA;
        protected int sideB;

        public Domino(int sideA, int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public void PrintAllFields()
        {
            Console.WriteLine($"Domino A side: {sideA}, B side: {sideB}");
        }
    }
}
