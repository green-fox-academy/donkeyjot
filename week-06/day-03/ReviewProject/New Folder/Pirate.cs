﻿using System;
namespace ReviewProject.NewFolder
{
    public class Pirate
    {
        public string Name { get; set; }
        public double DrunkLevel { get; set; }
        public PirateType Type { get; set; }

        public Pirate(string name, double drunkLevel, PirateType type)
        {
            Name = name;
            DrunkLevel = drunkLevel;
            Type = type;
        }

        public override string ToString()
        {
            return "Hello, I am" + Name;
        }
    }

    public enum PirateType
    {
        Pirate,
        Captain
    }
}
