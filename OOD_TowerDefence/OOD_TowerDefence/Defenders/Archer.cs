using System;
using Enemies;

namespace Defenders
{
    class Archer : Warrior
    {
        private int arrows;

        public Archer(string name, int strength, int arrows) : base(name, strength)
        {
            this.arrows = arrows;
        }
        public override int VisitOgre(Ogre ogre)
        { if (arrows >= 1) { 
                Console.WriteLine(name + " will damage " + ogre.Name + " for " + strength);
            return strength;
        }
        else
            { Console.WriteLine(name + " is out of arrows ");
                return 0;
            } }

        public override int VisitRat(Rat rat)
        {
            if (arrows >= 1)
            {
                if (rng.NextDouble() < rat.Speed / 100)
                {
                    Console.WriteLine(name + " will damage " + rat.Name + " for " + strength);
                    return strength;
                }
                else
                {
                    Console.WriteLine(name + " missed against " + rat.Name);
                    return 0;
                }
            }
            else
            {
                Console.WriteLine(name + " is out of arrows ");
                return 0;
            }
        }

        public override int VisitGiant(Giant giant)
        {
            int garr = 2 * strength;
            if (arrows >= 2)
            {
                Console.WriteLine(name + " will damage " + giant.Name + " for " + garr);
                return garr;
            }

            else
            {
                Console.WriteLine(name + " is out of arrows ");
                return 0;
            }
        }
    }
}