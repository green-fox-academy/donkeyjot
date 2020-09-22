using System;
namespace MusicInstruments
{
    public class Violin:StringedInstruments
    {
        protected string SoundNoise { get; set; }

        public Violin() : base()
        {
            Name = "Violin";
            NumberOfStrings = 4;
            SoundNoise = "Screech";
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}, {NumberOfStrings}-stringed instrument that {SoundNoise}.");
        }
    }
}
