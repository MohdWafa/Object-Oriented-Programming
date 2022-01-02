using System;
using Defenders;

namespace Enemies
{
    class Giant : Enemy
    {

        public Giant(string name, int hp) : base(name, hp)
        {
        }
        public override void Accept(IDefender defender)
        {
            int damage = defender.VisitGiant(this);
            GetDamage(damage);
        }
    }
}