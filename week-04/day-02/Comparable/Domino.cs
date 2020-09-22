using System;
using System.Diagnostics.CodeAnalysis;

namespace Comparable
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo([AllowNull] Domino other)
        {
            return Values[0].CompareTo(other.Values[0]);
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}