using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Shields
{
    class BasicShield : Shield
    {
        public BasicShield(IDamageTaker child) : base(20, Projectiles.DamageType.Physical, child) { }
    }
}
