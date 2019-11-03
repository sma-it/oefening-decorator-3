using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Projectiles
{
    class Arrow : Projectile
    {
        public Arrow() : base(DamageType.Physical, 19) { }
    }
}
