using System;
namespace MusicInstruments
{
    public class BassGuitar : StringedInstruments
    {
        protected string SoundNoise { get; set; }

        public BassGuitar() : base()
        {
            Name = "Bass guitar";
            NumberOfStrings = 4;
            SoundNoise = "Duum-duum-duum";
        }

        public BassGuitar(int numberOfStrings) : base(numberOfStrings)
        {
            Name = "Bass guitar";
            NumberOfStrings = NumberOfStrings;
            SoundNoise = "Duum-duum-duum";
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}, {NumberOfStrings}-stringed instrument that {SoundNoise}.");
        }
    }
}
