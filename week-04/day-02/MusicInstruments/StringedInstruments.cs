using System;
namespace MusicInstruments
{
    public abstract class StringedInstruments : Instrument
    {
        protected int NumberOfStrings { get; set; }

        public StringedInstruments():base()
        {
            
        }
        public StringedInstruments(int numberOfStrings) : base()
        {
            NumberOfStrings = numberOfStrings;
        }

        public override void Play()
        {
            Sound();
        }
        public abstract void Sound();
        
    }
}
