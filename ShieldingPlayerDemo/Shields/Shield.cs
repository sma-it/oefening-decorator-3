using ShieldingPlayerDemo.Projectiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShieldingPlayerDemo.Shields
{
    class Shield : IDamageTaker
    {
        IDamageTaker child;
        DamageType absorbedDamageType;
        protected int Strength { get; set; }


        public Shield(int strength, DamageType absorbedDamageType, IDamageTaker child)
        {
            this.Strength = strength;
            this.absorbedDamageType = absorbedDamageType;
            this.child = child;
        }

        public IDamageTaker Child()
        {
            return child;
        }

        public virtual void AttackWith(IProjectile projectile)
        {
            if (projectile.Type == absorbedDamageType)
            {
                projectile.Damage(this);
            }

            passToChild(projectile);
        }

        public virtual int DoDamage(int value)
        {
            int absorbed = value;
            if (Strength < absorbed) absorbed = Strength;
            Strength -= absorbed;
            return absorbed;
        }

        protected void passToChild(IProjectile projectile)
        {
            child.AttackWith(projectile);
            if (child.IsDepleted())
            {
                if (child.Child() != null)
                {
                    child = child.Child();
                }
            }
        }

        public bool IsDepleted()
        {
            return Strength <= 0;
        }

        public virtual void PrintStatus()
        {
            Console.WriteLine(absorbedDamageType.ToString() + " shield is at strength " + Strength + ".");
            child.PrintStatus();
        }
    }
}
