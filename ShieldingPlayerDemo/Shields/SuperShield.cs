using ShieldingPlayerDemo.Projectiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Shields
{
    class SuperShield : Shield
    {
        public SuperShield(IDamageTaker child) : base(80, DamageType.Physical, child) { }

        public override void AttackWith(IProjectile projectile)
        {
            // absorbs every type of damage
            projectile.Damage(this);
            passToChild(projectile);
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Super shield is at strength " + Strength + ".");
            Child().PrintStatus();
        }
    }
}
