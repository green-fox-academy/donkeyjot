using System;
namespace FirstApp.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public static int Counter { get; set; } = 1;

        public Greeting(string content)
        {
            Id = Counter;
            Content = content;
            Counter++;
        }

        public Greeting()
        {
            Id = Counter;
            Counter++;
        }
    }
}
