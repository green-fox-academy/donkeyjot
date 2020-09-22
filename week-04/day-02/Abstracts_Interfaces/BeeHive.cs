using System;
using System.Collections.Generic;

namespace Abstracts_Interfaces
{
    public class BeeHive
    {
        private List<Honeybee> bees;


        public BeeHive()
        {
            bees = new List<Honeybee>();

        }

        public void AddNewBee(Honeybee honeybee)
        {
            bees.Add(honeybee);
        }

        public void StartWorking()
        {
            foreach (Honeybee honeybee in bees)
            {
                honeybee.DoWork();
            }
        }

        public void Defend()
        {
            foreach (Honeybee bee in bees)
            {
                if (bee is IStinger)
                {
                    IStinger defendingBee = (IStinger)bee;
                    defendingBee.Sting();
                }
            }
        }
    }
}
