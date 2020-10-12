using System;

namespace Linq
{
    public class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Fox(string name, string color, string type)
        {
            Type = type;
            Color = color;
            Name = name;
        }
    }
}
