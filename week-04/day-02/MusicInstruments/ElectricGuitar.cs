using System;
namespace MusicInstruments
{
    public class ElectricGuitar : StringedInstruments
    {
        protected string SoundNoise { get; set; }

        public ElectricGuitar() : base()
        {
            Name = "Electric guitar";
            NumberOfStrings = 6;
            SoundNoise = "Twang";
        }

        public ElectricGuitar(int numberOfStrings) : base(numberOfStrings)
        {
            Name = "Electric guitar";
            NumberOfStrings = numberOfStrings;
            SoundNoise = "Twang";
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}, {NumberOfStrings}-stringed instrument that {SoundNoise}.");
        }

    }
}
