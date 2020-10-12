using System;
using System.Collections.Generic;

namespace AircraftCarrier
{
    public class Carrier
    {
        public List<Aircraft> myCarrier { get; protected set; }
        public int AmmoStorage { get; set; }
        public int HP { get; set; }

        public Carrier(int storageSize, int hP)
        {
            AmmoStorage = storageSize;
            HP = HP;
        }

        public void Add(Aircraft aircraft)
        {
            myCarrier.Add(aircraft);
        }

       
    }
}
