using System;
namespace MusicInstruments
{
    public abstract class Instrument
    {
        protected string Name { get; set; }

        public Instrument()
        {
        }

        public abstract void Play();
        
    }
}
