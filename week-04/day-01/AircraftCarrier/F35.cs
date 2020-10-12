using System;
namespace AircraftCarrier
{
    public class F35:Aircraft
    {
        public F35():base()
        {
            MaxAmmo = 12;
            Damage = 50;
        }

        public override string ToString()
        {
            return "F35";
        }
    }
}
