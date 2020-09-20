using System;
namespace Classes_objects
{
    public class Counter
    {
        public int Count { get; set; }
        public static int instances = 0;

        public Counter()
        {
            Count = 0;
            instances++;
        }

        public Counter(int count)
        {
            this.Count = count;
            instances++;
        }

        public void Add(int number)
        {
            this.Count += number;

        }

        public void Add()
        {
            this.Count++;
        }

        public string Get()
        {
            return this.Count.ToString();
        }

        public void Reset()
        {
            Count = 0;
        }
        public static void Method1()
        {
            Console.WriteLine($"I created {instances} instances");
        }
    }
}
