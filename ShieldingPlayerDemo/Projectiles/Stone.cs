using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Projectiles
{
    class Stone : Projectile
    {
        public Stone() : base(DamageType.Physical, 15) { }
    }
}
