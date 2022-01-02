using System;
using Enemies;

namespace Defenders
{
    class RatCatcher : IDefender
    {
        protected readonly string name;
        private bool hasRat;

        public RatCatcher(string name)
        {
            this.name = name;
            hasRat=false;
        }

        public int VisitGiant(Giant giant)
        {
          
                Console.WriteLine(name + " will ignore " + giant.Name);
            return 0;
        }

        public int VisitOgre(Ogre ogre)
        {if(hasRat==true)
            {
                Console.WriteLine(name + " will kill " + ogre.Name);
                return ogre.HP;
            }
            else
                Console.WriteLine(name + " will ignore " + ogre.Name);
            return 0;
           
        }

        public int VisitRat(Rat rat)
        {if(hasRat==false)
            {
                Console.WriteLine(name + " will kill " + rat.Name);
                return rat.HP;
            }
        else
                Console.WriteLine(name + " will ignore rat " + rat.Name);
            return 0;
          
        }
    }
}