using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19338463_GADE6112_POE
{
    class Gold : Item
    {
        private int gold;
        private Random random = new Random();
        public Gold(int y, int x) : base(y, x)
        {
            gold = random.Next(1, 6);
            ThisTileType = Tile.TileType.Gold;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public int GetGold()
        {
            return gold;
        }
    }
}
