using System;
using System.Linq;

namespace Pirates
{
    public class Pirate
    {
        public int CounterForDrinkSomeRum;
        public bool IsDead { get; set; }
        public bool IsPassedOut { get; set; }
        public bool HasParot { get; set; }
        public bool IsCaptain { get; set; }

        public Pirate()
        {
            CounterForDrinkSomeRum = 0;
            IsDead = false;
            IsPassedOut = false;
            HasParot = false;
            IsCaptain = false;
        }
        public void DrinkSomeRum()
        {
            if (IsDead)
            {
                Console.WriteLine("He's dead.");
                return;
            }
            else if (IsPassedOut)
            {
                Console.WriteLine("He's done for today");
                return;
            }

            CounterForDrinkSomeRum++;
            //intoxicates the pirate some


        }
        public void HowsItGoingMate()
        {
            //when called, the Pirate replies, if DrinkSomeRun was called:-
            //0 to 4 times, "Pour me anudder!"
            //else, "Arghh, I'ma Pirate. How d'ya d'ink its goin?", the pirate passes out and sleeps it off.
            if (IsDead)
            {
                Console.WriteLine("He's dead.");
                return;
            }
            else if (IsPassedOut)
            {
                Console.WriteLine("He's done for today");
                return;
            }

            if (CounterForDrinkSomeRum < 5)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                PassOut();
            }

        }
        public void PassOut()
        {
            IsPassedOut = true;
        }

        public void Die()
        {
            IsDead = true;

        }

        public void Brawl(Pirate otherPirate)
        {
            if (otherPirate.IsDead || IsDead)               //check for pirates condition
            {
                Console.WriteLine("He's dead.");
                return;
            }
            else if (otherPirate.IsPassedOut || IsPassedOut)
            {
                Console.WriteLine("He's done for today");
                return;
            }

                                                             //generate the random number from array and save it to chance
            Random random = new Random();
            int chance = random.Next(1, 4);

            switch (chance)                                     //three cases for the otcome of Brawl
            {
                case 1:
                    otherPirate.Die();
                    break;
                case 2:
                    Die();
                    break;
                case 3:
                    otherPirate.PassOut();
                    PassOut();
                    break;
            }
        }

    }
}
