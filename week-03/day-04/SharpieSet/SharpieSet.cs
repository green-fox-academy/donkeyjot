using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpieSet
{
    public class SharpieSet
    {
        public List<Sharpie> SetOfSharpies { get; set; }

        public SharpieSet()
        {
            SetOfSharpies = new List<Sharpie>();
        }

        public void CountUsable()
        {
            int usable = 0;
            foreach(Sharpie sharpie in SetOfSharpies)
            {
                if(sharpie.InkAmount != 0)
                {
                    usable++;
                }
            }
            Console.WriteLine($"In this SharpieSet is {usable} Sharpies.");
        }

        public void RemoveTrash()
        {
            for (int i = 0; i < SetOfSharpies.Count; i++)
            {
                Sharpie sharpie = SetOfSharpies[i];
                if (sharpie.InkAmount <= 0)
                {
                    SetOfSharpies.Remove(sharpie);
                    i--;
                }
            }
        }

        public void Remove()
        {
            foreach (Sharpie sharpie in SetOfSharpies.Reverse<Sharpie>())
            {
                if (sharpie.InkAmount <= 0)
                {
                    SetOfSharpies.Remove(sharpie);
                }
            }
        }

        public void Add(Sharpie sharpie)
        {
            SetOfSharpies.Add(sharpie);
        }
    }
}
