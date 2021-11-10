using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19338463_GADE6112_POE
{
    class Hero : Character
    {

        public Hero(int y, int x, int maxhp) : base(y, x, maxhp, 2, 'H')
        {
            this.ThisTileType = TileType.Hero;
        }

        public override Movement ReturnMove(Movement move)
        {
            return move;
        }

        public override string ToString()
        {
            return "Player Stats:\n" + "HP: " + hp + "/" + maxHP + "\nGold: " + purse + "\nDamage: 2\n" + "[" + Y + "," + X + "]";
        }
    }
}
