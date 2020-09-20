using System;
namespace Classes_objects
{
    public class Sharpie
    {
        private float InkAmount;
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
