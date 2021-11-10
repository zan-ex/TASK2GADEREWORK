﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19338463_GADE6112_POE
{
    abstract class Enemy : Character
    {
        protected Random random = new Random();
        public Enemy(int y, int x, int maxHp, int Damage, char symbol) : base(y, x, maxHp, Damage, symbol)
        {

        }

        public override string ToString()
        {
            return nameof(Enemy) + "at [" + this.X + "," + this.Y + "] with (" + this.hp + ") hp";
        }
    }
}
