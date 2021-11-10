﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19338463_GADE6112_POE
{
    [System.Serializable()]
    abstract class Character : Tile
    {

        protected char symbol { get; set; }
        protected int hp { get; set; }
        protected int maxHP { get; set; }
        protected int damage { get; set; }
        protected Tile[] vision { get; set; }
        protected bool dead { get; set; }

        protected int purse { get; set; }

        public int Purse
        {
            get => purse;
            set => purse = value;
        }
        public char Symbol
        {
            get => symbol;
            set => symbol = value;
        }

        public int Hp
        {
            get => hp;
            set => hp = value;
        }

        public int MaxHp
        {
            get => maxHP;
            set => maxHP = value;
        }
        public int Damage
        {
            get => damage;
            set => damage = value;
        }
        public Tile[] Vision
        {
            get => vision;
            set => vision = value;
        }
        public bool Dead
        {
            get => dead;
            set => dead = value;
        }

        public enum Movement
        {
            NoMovement, Up, Down, Left, Right
        }
        public Character(int y, int x, int maxhp, int damage, char symbol) : base(y, x)
        {
            this.symbol = symbol;
            maxHP = maxhp;
            hp = maxhp;
            this.damage = damage;
            vision = new Tile[4];
        }

        public void Pickup(Item i)
        {
            if (i == null)
            {
                return;
            }
            if (i.GetType() == typeof(Gold))
            {
                purse += ((Gold)i).GetGold();
            }
        }

        public virtual void Attack(Character target)
        {
            target.hp -= this.damage;
            if (target.hp <= 0)
            {
                target.dead = true;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            if (DistanceTo(target) <= 1 && DistanceTo(target) >= -1)
            {
                return true;
            }
            return false;
        }

        public void Move(Movement move)
        {
            if (move == Movement.Down)
            {
                this.Y++;
            }
            if (move == Movement.Up)
            {
                this.Y--;
            }
            if (move == Movement.Right)
            {
                this.X++;
            }
            if (move == Movement.Left)
            {
                this.X--;
            }
        }

        public bool IsDead()
        {
            return dead;
        }
        private int DistanceTo(Character target)
        {
            return Math.Abs(target.X - this.X) + Math.Abs(target.Y - this.Y);
        }

        public abstract Movement ReturnMove(Movement move);

        public abstract override string ToString();
    }
}

