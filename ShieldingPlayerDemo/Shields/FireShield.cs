using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Shields
{
    class FireShield : Shield
    {
        public FireShield(IDamageTaker child) : base(40, Projectiles.DamageType.Fire, child) { }
    }
}
