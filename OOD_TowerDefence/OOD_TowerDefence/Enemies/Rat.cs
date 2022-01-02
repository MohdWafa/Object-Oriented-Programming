using System;
using Defenders;

namespace Enemies
{
    class Rat : Enemy
    {
        public int Speed { get; set; }

        public Rat(string name, int hp, int speed) : base(name, hp)
        {
            Speed = speed;
        }

        public override void GetHurt(int damage)
        {
            base.GetHurt(damage);
            if (damage > 0)
            {
                Speed += 1;

            }
        }
        public override void Accept(IDefender defender)
        { 
           int damage =  defender.VisitRat(this);
            GetDamage(damage);
        }
    }
}
