using ShieldingPlayerDemo.Projectiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo
{
    interface IDamageTaker
    {
        void AttackWith(IProjectile projectile);
        int DoDamage(int value);
        bool IsDepleted();
        IDamageTaker Child();
        void PrintStatus();
    }
}
