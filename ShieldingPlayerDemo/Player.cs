using ShieldingPlayerDemo.Projectiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo
{
    class Player : IDamageTaker
    {
        int life = 100;

        public IDamageTaker Child()
        {
            return null;
        }

        public void AttackWith(IProjectile projectile)
        {
            // player takes all kinds of damage
            projectile.Damage(this);
        }

        public int DoDamage(int value)
        {
            life -= value;
            return 0; // player is hit, so damage cannot be passed on
        }

        public bool IsDepleted()
        {
            return life <= 0;
        }

        public void PrintStatus()
        {
            if (life <= 0)
            {
                Console.WriteLine("The Player is Dead!");
            } else
            {
                Console.WriteLine("The Player has " + life + " life left.");
            }
        }
    }
}
