using System;
using System.Collections.Generic;

namespace Pirates
{
    public class Ship
    {
        public List<Pirate> Crew;
        public string Name { get; set; }

        public Ship(string name)
        {
            Crew = new List<Pirate>();
            Name = name;
        }

        public void FillShip()
        {
            if (Crew.Count != 0)
            {
                Console.WriteLine("This ship already has some crew...");
                return;
            }

            Pirate captain = new Pirate();
            captain.IsCaptain = true;
            Crew.Add(captain);

            int crewCount = 0;
            int randomCrew = new Random().Next(0, 10);

            for (int i = 0; i + randomCrew < 10; i++)
            {
                crewCount++;
                Crew.Add(new Pirate());
            }

            Console.WriteLine($"The captain of ship {Name} found a crew of {crewCount} " +
                $"members. There is a total of {crewCount + 1} people on board.");
        }

        public void Info()
        {
            if (Crew[0].IsDead)
            {
                Console.WriteLine("This ship's captain is dead. Will you be the new one?");
            }
            if (Crew[0].IsPassedOut)
            {
                Console.WriteLine("The captain had too many today. He won't be ready till the morning");
            }
            else
            {
                int aliveCounter = 1;
                int passedOutCounter = 0;
                for (int i = 1; i < Crew.Count; i++)
                {
                    if (!Crew[i].IsDead)
                    {
                        aliveCounter++;
                    }
                    if (Crew[i].IsPassedOut)
                    {
                        passedOutCounter++;
                    }
                }

                Console.WriteLine($"The captain is OK. He only had {Crew[0].CounterForDrinkSomeRum} drinks.");
                Console.WriteLine($"There are also {aliveCounter} pirates on board, of which {passedOutCounter}" +
                    $" are sleeping and will not get ready till morning");
            }
        }
        public bool Battle(Ship otherShip)
        {
            //this ships score:

            int thisShipAlive = 0;
            int thisShipPassedOut = 0;
            int thisShipCaptainRum = Crew[0].CounterForDrinkSomeRum;

            for (int i = 1; i < Crew.Count; i++)
            {
                if (!Crew[i].IsDead)
                {
                    thisShipAlive++;
                }
                if (Crew[i].IsPassedOut && !Crew[i].IsDead)
                {
                    thisShipPassedOut++;
                }
            }

            int thisShipScore = thisShipAlive - thisShipPassedOut - thisShipCaptainRum;

            //other ship score

            int otherShipAlive = 0;
            int otherShipPassedOut = 0;
            int otherShipCaptainRum = otherShip.Crew[0].CounterForDrinkSomeRum;

            for (int i = 1; i < otherShip.Crew.Count; i++)
            {
                if (!otherShip.Crew[i].IsDead)
                {
                    otherShipAlive++;
                }
                if (otherShip.Crew[i].IsPassedOut && !otherShip.Crew[i].IsDead)
                {
                    otherShipPassedOut++;
                }
            }

            int otherShipScore = otherShipAlive - otherShipPassedOut - otherShipCaptainRum;

            if(thisShipScore)

            bool result;
            return result;

        }
    }
}
}
