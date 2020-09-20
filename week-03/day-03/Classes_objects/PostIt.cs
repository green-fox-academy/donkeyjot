using System;
namespace Classes_objects
{
    class PostIt
    {
        public string Text { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleColor TextColor { get; set; }

        public PostIt (string text, ConsoleColor backgroundColor, ConsoleColor textColor)
        {
            Text = text;
            BackgroundColor = backgroundColor;
            TextColor = textColor;

        }

        public PostIt()
        {

        }

        public void Post()
        {
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = TextColor;
            Console.WriteLine(Text);
        }

        public void Post(int lenght)
        {

        }
    }
}
