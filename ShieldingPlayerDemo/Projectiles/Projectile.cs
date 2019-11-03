using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Projectiles
{
    class Projectile : IProjectile
    {
        DamageType type;
        public DamageType Type => type;
        int strength;

        public Projectile(DamageType type, int strength)
        {
            this.type = type;
            this.strength = strength;
        }

        public void Damage(IDamageTaker target)
        {
            strength -= target.DoDamage(strength);
        }
    }
}
