using System;
using Enemies;

namespace Defenders
{
    class FireMage : Mage
    {
        private double killChance;
        protected static readonly Random rng = new Random(1597);

        public FireMage(string name, int mana, int manaRegen, int spellPower, double killChance) : base(name, mana, manaRegen, spellPower)
        {
            this.killChance = killChance;
        }

        public override int VisitOgre(Ogre ogre)
        {

            if (CanCastSpell())
            {
                if (rng.NextDouble() < killChance)
                {
                    Console.WriteLine(name + " killed " + ogre.Name);
                    return ogre.HP;
                }
                else
                {
                    Console.WriteLine(name + " is attacking " + ogre.Name + " for " + spellPower + " damage ");
                    return spellPower;
                }
            }
            else
            {
                Console.WriteLine(name + " cannot attack because lack of Mana ");
                return 0;
            }
           
        }

        public override int VisitRat(Rat rat)
        {
            if (CanCastSpell())
            {
                if (rng.NextDouble() < killChance)
                {
                    Console.WriteLine(name + " killed " + rat.Name);
                    return rat.HP;
                }
                else
                {
                    Console.WriteLine(name + " is attacking " + rat.Name + " for " + spellPower + " damage ");
                    return spellPower;
                }
            }
            else
            {
                Console.WriteLine(name + " cannot attack because lack of Mana ");
                return 0;
            }
            
        }

        public override int VisitGiant(Giant giant)
        {
            if (CanCastSpell())
            {
                if (rng.NextDouble() < killChance)
                {
                    Console.WriteLine(name + " killed " + giant.Name);
                    return giant.HP;
                }
                else
                {
                    Console.WriteLine(name + " is attacking " + giant.Name + " for " + spellPower + " damage ");
                    return spellPower;
                }
            }
            else
            {
                Console.WriteLine(name + " cannot attack because lack of Mana ");
                return 0;
            }
        }
    }

   
}