using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Projectiles
{
    class Spell : Projectile
    {
        public Spell() : base(DamageType.Arcane, 23) { }
    }
}
