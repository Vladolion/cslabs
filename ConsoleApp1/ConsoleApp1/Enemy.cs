using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Enemy: IDamageable
    {
        public int hp = 5;
        public void TakeDamage(int damage)
        {
            hp-= damage;
            if (hp <= 0)
            {
                Console.WriteLine("ded");
            }
            else
            {
                Console.WriteLine("tis a scratch");
            }
        }
    }
}
