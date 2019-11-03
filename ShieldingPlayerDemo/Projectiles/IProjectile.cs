using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Projectiles
{
    interface IProjectile
    {
        void Damage(IDamageTaker target);
        DamageType Type { get; }
    }
}
