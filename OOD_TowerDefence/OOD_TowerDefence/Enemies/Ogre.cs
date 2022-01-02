using System;
using Defenders;
namespace Enemies
{
    class Ogre : Enemy
    {
        public int Armor { get; }

        public Ogre(string name, int hp, int armor) : base(name, hp)
        {
            Armor = armor;
        }

        public override void GetHurt(int damage)
        {
            int d = Math.Max(1, Armor - damage);
            base.GetHurt(d);
            
        }
        public override void Accept(IDefender defender)
        {
            int damage = defender.VisitOgre(this);
            GetDamage(damage);
        }
    }
}