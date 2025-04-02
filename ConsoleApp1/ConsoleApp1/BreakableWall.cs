using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class BreakableWall : IDamageable
    {
        public void TakeDamage(int damage)
        {
            Console.WriteLine("On no! The wall! It's broken!");       
        }
    }
}
