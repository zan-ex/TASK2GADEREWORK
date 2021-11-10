using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19338463_GADE6112_POE
{
    class Goblin : Enemy
    {
        public Goblin(int y, int x) : base(y, x, 10, 1, 'G')
        {

        }

        public override Movement ReturnMove(Movement move)
        {
            int dir = random.Next(0, 5);
            while (vision[dir] != null)
            {
                dir = random.Next(0, 5);
            }
            return (Movement)dir;
        }
    }
}
