using System;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie red = new Sharpie("red", 0.3f);
            Sharpie blue = new Sharpie("blue", 0.2f);

            SharpieSet mySharpies = new SharpieSet();
            mySharpies.Add(red);
            mySharpies.Add(blue);
            mySharpies.CountUsable();
            for(int i = 0; i <100; i++)
            {
                red.Use();
            }
            mySharpies.CountUsable();
            mySharpies.RemoveTrash();

           


        }
    }
}
