using System;
namespace AircraftCarrier
{
    public class Aircraft
    {
        public int Ammo { get; protected set; }
        public int Damage { get; protected set; }
        public int MaxAmmo { get; protected set; }

        public Aircraft()
        {
            Ammo = 0;

        }

        public int Fight()
        {
            int actualDamage = Ammo * Damage;
            Ammo = 0;
            return actualDamage;
        }

        public int Refill(int amountToRefill)
        {
            int toRefill = MaxAmmo - Ammo;
            Ammo += toRefill;
            amountToRefill -= toRefill;
            return amountToRefill;

        }

        public string GetType()
        {
            return ToString();
        }

        public string GetStatus()
        {
            return $"Type {ToString()}, Ammo: {Ammo}, Base Damage: {Damage}, All Damage: {Ammo * Damage}";
        }

        public bool IsPriority()
        {
            if (GetType() == "F35")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
