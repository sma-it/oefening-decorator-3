using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Shields
{
    class ArcaneShield : Shield
    {
        public ArcaneShield(IDamageTaker child) : base(50, Projectiles.DamageType.Arcane, child) { }
    }
}
