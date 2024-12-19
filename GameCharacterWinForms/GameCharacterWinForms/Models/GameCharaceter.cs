using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterWinForms.Models
{
    abstract class GameCharacter
    {
        public string name;
        public int level;
        public int health;
        public int mana;
        public int strength;
        public int intelligence;

        public GameCharacter(string name, int level, int health, int mana, int strength, int intelligence)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.mana = mana;
            this.strength = strength;
            this.intelligence = intelligence;
        }

        public abstract void Attack();
        public abstract void Defend();
        public abstract void LevelUp();
    }
}
