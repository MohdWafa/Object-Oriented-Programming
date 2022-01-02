using System;
using Enemies;

namespace Defenders
{
    class Mage : IDefender
    {
        protected readonly string name;
        protected int mana;
        protected readonly int manaRegen;
        protected readonly int spellPower;

        public Mage(string name, int mana, int manaRegen, int spellPower)
        {
            this.name = name;
            this.mana = mana;
            this.manaRegen = manaRegen;
            this.spellPower = spellPower;
            
        }

        protected bool CanCastSpell()
        {
            if (mana >= spellPower)
            {
                mana -= spellPower;
                return true;
            }

            Console.WriteLine($" Mage {name} is recharging mana ");
            RechargeMana();
            return false;
        }


        private void RechargeMana()
        {
            mana += manaRegen;
        }

        public virtual int VisitOgre(Ogre ogre)
        {

            if (CanCastSpell())
            {
                Console.WriteLine(name + " is attacking " + ogre.Name + "for" + spellPower + "damage");
                return spellPower;
            }
            else
            {
                Console.WriteLine(name + " cannot attack because lack of Mana ");
                return 0;
            }
          
        }

        public virtual int VisitRat(Rat rat)
        {
            if (CanCastSpell())
            {
                Console.WriteLine(name + " is attacking " + rat.Name + " for " + spellPower + " damage ");
                return spellPower;

            }
            else
            {
                Console.WriteLine(name + " cannot attack because lack of Mana! ");
                return 0;
            }
           
        }

        public virtual int VisitGiant(Giant giant)
        {
            if (CanCastSpell())
            {
                Console.WriteLine(name + " is attacking " + giant.Name + " for " + spellPower + " damage ");
                return spellPower;
            }
            else
            {
                Console.WriteLine(name + " cannot attack because lack of Mana " );
                return 0;
            }
           
        }
    }
}