using System;
namespace AircraftCarrier
{
    public class F16:Aircraft
    {
        public F16()
        {
            Damage = 30;
            MaxAmmo = 12;

        }

        public override string ToString()
        {
            return "F16";
        }
    }
}
