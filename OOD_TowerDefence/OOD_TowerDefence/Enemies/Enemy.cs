using System;
using Defenders;
namespace Enemies
{
    abstract class Enemy
    {
        public string Name { get; }

        public bool Alive { get; private set; }
        public int HP { get; private set; }

        protected Enemy(string name, int hp)
        {
            Name = name;
            HP = hp;
            Alive = true;
        }
        public abstract void Accept(IDefender defender);
        protected void GetDamage(int damage)
        {
            HP -= damage;
            if(HP<=0)
            {
                Console.WriteLine($"{Name} is dead...");
                Alive = false;
            }
        }

       public virtual void GetHurt(int damage)
        {
            GetDamage(damage);
        }
    }
}