using System;
using Enemies;

namespace Defenders
{
    interface IDefender
    {
        public int VisitOgre(Ogre ogre);

        public int VisitRat(Rat rat);

        public int VisitGiant(Giant giant);

    }
}