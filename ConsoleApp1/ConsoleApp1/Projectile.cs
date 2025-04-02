using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Projectile
    {
        public int damage;
        public virtual void HitTarget(IDamageable target)
        {
            target.TakeDamage(damage);
        }
    }
}
