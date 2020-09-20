using System;
namespace SharpieSet
{
    public class Sharpie
    {

        public int InkAmount;
        public string Color;
        public float Width;

        public Sharpie(string color, float width)
        {
            Color = color;
            Width = width;
            InkAmount = 100;
        }

        public void Use()
        {
            this.InkAmount--;
        }


    }
}
