using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Projectiles
{
    class FireArrow : Projectile
    {
        public FireArrow() : base(DamageType.Fire, 26) { }
    }
}
