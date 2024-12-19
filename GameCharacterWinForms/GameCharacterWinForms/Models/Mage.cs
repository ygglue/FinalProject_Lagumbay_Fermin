using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterWinForms.Models
{
    class Mage : GameCharacter
    {
        Random chance = new Random();
        private int spellPower;
        public Mage(string name, int level, int health, int mana, int intelligence, int spellPower = 10) : base(name, level, health, mana, 0, intelligence)
        {
            this.name = "Mage " + name;
            this.level = level;
            this.health = health;
            this.mana = mana;
            this.intelligence = intelligence;
            this.spellPower = spellPower;
        }

        public override void Attack()
        {
            int baseDmg = (intelligence * 2) + spellPower;
            int burn = chance.Next(0, 100);
            if (burn < 25)
            {
                Console.WriteLine($"{name} dealt {baseDmg} Magic Dmg!\nBurn effect applied to enemy.");
            }
            else
            {
                Console.WriteLine($"{name} dealt {baseDmg} Magic Dmg!");
            }
        }
        public override void Defend()
        {
            int evade = chance.Next(0, 100);
            int baseDmgRed = mana / 4;

            if (evade < 20)
            {
                Console.WriteLine($"{name} did a successful evade!");
            }
            else
            {
                Console.WriteLine($"{name} reduced the incoming Dmg by {baseDmgRed}.");
            }
        }
        public override void LevelUp()
        {
            level++;
            intelligence += 5;
            mana += 15;
            spellPower += 3;

            Console.WriteLine($"{name} leveled up to lv{level}!\nIntelligence, Mana, Spell Power has increased.");

        }

        public override string ToString()
        {
            return $"Name: {name}\r\nLevel: {level}\r\nHealth: {health}\r\nMana: {mana}\r\nStrength: {strength}\r\nIntelligence: {intelligence}\r\nSpell Power: {spellPower}";
        }
    }
}
