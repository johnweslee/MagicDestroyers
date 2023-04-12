using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const string DEFAULT_NAME = "Warrior";

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        public Warrior() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Warrior(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Faction = DEFAULT_FACTION;
            base.Name = name;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.ISAlive = true;
            base.Score = 0;
        }

        public int Strike()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int Execute()
        {
            throw new NotImplementedException();
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }
    }
}
