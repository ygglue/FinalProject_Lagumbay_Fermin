using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterWinForms.Models
{
    class Warrior : GameCharacter
    {
        Random chance = new Random();
        private int armor;
        public Warrior(string name, int level, int health, int strength, int armor = 10) : base(name, level, health, 0, strength, 0)
        {
            this.name = "Warrior " + name;
            this.level = level;
            this.health = health;
            this.strength = strength;
            this.armor = armor;
        }

        public override void Attack()
        {
            int crit = chance.Next(0, 100);
            int baseDmg = strength * 2;
            int finalDmg;
            if (crit < 20)
            {
                finalDmg = baseDmg * 2;
                Console.WriteLine($"{name} attacked!\nA critical hit!\n{finalDmg} Physical Dmg is dealt.");
            }
            else
            {
                finalDmg = baseDmg;
                Console.WriteLine($"{name} attacked!\n{finalDmg} Physical Dmg is dealt.");
            }


        }
        public override void Defend()
        {
            int block = chance.Next(0, 100);
            int baseDmgRed = armor / 2;

            if (block < 15)
            {
                Console.WriteLine($"{name} did a successful block!");
            }
            else
            {
                Console.WriteLine($"{name} reduced the incoming Dmg by {baseDmgRed}.");
            }
        }
        public override void LevelUp()
        {
            level++;
            strength += 5;
            health += 20;
            armor += 2;

            Console.WriteLine($"{name} leveled up to lv{level}!\nHealth, Strength, Armor has increased.");

        }

        public override string ToString()
        {
            return $"Name: {name}\r\nLevel: {level}\r\nHealth: {health}\r\nMana: {mana}\r\nStrength: {strength}\r\nIntelligence: {intelligence}\r\nArmor: {armor}";
        }
    }
}
