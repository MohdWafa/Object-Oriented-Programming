using System;
using Enemies;

namespace Defenders
{
    class Warrior : IDefender
    {
        protected readonly string name;
        protected readonly int strength;
        protected static readonly Random rng = new Random(1597);

        public Warrior(string name, int strength)
        {
            this.name = name;
            this.strength = strength;
        }

        public virtual int VisitOgre(Ogre ogre)
        {
            Console.WriteLine(name + " will damage "  + ogre.Name + " for " + strength);
            return strength;
        }

        public virtual int VisitRat(Rat rat)
        {
            if (rng.NextDouble() < rat.Speed / 100)
            {
                Console.WriteLine(name + " will damage " + rat.Name + " for " + strength);
                return strength;
            }
            else
                Console.WriteLine(name + " missed against " + rat.Name);
            return 0;
        }

        public virtual int VisitGiant(Giant giant)
        {
            Console.WriteLine(name + " will damage " + giant.Name + " for " + strength);
            return strength;
        }
    }
}